using System;
using Logic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
     public sealed class SingletonUserInfo
     {
          private const string k_FailedToGetInfo = "N/A";
          private const string k_NoItemsToShow = "Whoops, there is nothing here, Maybe try to check your permissions";
          private const string k_IrrelevantGender = "irrelevant";
          private const string k_FemaleGender = "female";
          private const string k_MaleGender = "male";
          private User m_LoggedInUser;
          private static SingletonUserInfo s_Instance;
          private static readonly object sr_Lock = new object();

          public User LoggedInUser
          {
               get
               {
                    return m_LoggedInUser;
               }
               set
               {
                    m_LoggedInUser = value;
               }
          }

          private SingletonUserInfo()
          {
          }


          public static SingletonUserInfo Instance
          {
               get
               {
                    if(s_Instance == null)
                    {
                         lock(sr_Lock)
                         {
                              if(s_Instance == null)
                              {
                                   s_Instance = new SingletonUserInfo();
                              }
                         }
                    }

                    return s_Instance;
               }
          }

          public static string[] SetUsersChosenPermissions(CheckedListBox i_CheckedListBoxPermissions)
          {
               int checkedItemsCount = i_CheckedListBoxPermissions.CheckedItems.Count;
               string[] permissions = new string[checkedItemsCount + BasicFacebookLogic.sr_ConstantPermissions.Length];

               for(int i = 0; i < checkedItemsCount; i++)
               {
                    permissions[i] = i_CheckedListBoxPermissions.CheckedItems[i].ToString();
               }

               return permissions;
          }

          public void FetchNewsFeed(ListBox io_ListBoxNewsFeed)
          {
               if(m_LoggedInUser != null)
               {
                    try
                    {
                         io_ListBoxNewsFeed.Invoke(new Action(() => io_ListBoxNewsFeed.Items.Clear()));
                         addPostsToListBox(io_ListBoxNewsFeed, m_LoggedInUser.NewsFeed);
                    }
                    catch(Exception ex)
                    {
                         string errorMessage = string.Format("Facebook API error: {0}", ex.ToString());
                         MessageBox.Show(errorMessage);
                    }
               }
          }

          private void addPostsToListBox(ListBox io_ListBox, FacebookObjectCollection<Post> i_Posts)
          {
               foreach(Post post in i_Posts)
               {
                    if(post.Message != null)
                    {
                         io_ListBox.Invoke(new Action(() => io_ListBox.Items.Add(post.Message)));
                    }
               }
          }

          public void FetchPosts(ListBox io_ListBoxPosts)
          {
               if(m_LoggedInUser != null)
               {
                    io_ListBoxPosts.Invoke(new Action(() => io_ListBoxPosts.Items.Clear()));
                    addPostsToListBoxPosts(io_ListBoxPosts);
               }
          }

          private void addPostsToListBoxPosts(ListBox io_ListBoxPosts)
          {
               foreach(Post post in m_LoggedInUser.Posts)
               {
                    if(post.Message != null)
                    {
                         io_ListBoxPosts.Invoke(new Action(() => io_ListBoxPosts.Items.Add(post.Message)));
                    }
                    else if(post.Caption != null)
                    {
                         io_ListBoxPosts.Invoke(new Action(() => io_ListBoxPosts.Items.Add(post.Caption)));
                    }
                    else
                    {
                         io_ListBoxPosts.Invoke(
                              new Action(() => io_ListBoxPosts.Items.Add(string.Format("[{0}]", post.Type))));
                    }
               }
          }

          public bool FetchListBox<T>(
               BindingSource i_PageBindingSource,
               ListBox io_ListBoxLikedPages,
               FacebookObjectCollection<T> i_Collection)
          {
               i_PageBindingSource.DataSource = i_Collection;
               return i_Collection.Count > 0;
          }

          public bool FetchListBox<T>(ListBox io_ListBox, FacebookObjectCollection<T> i_Collection)
          {
               io_ListBox.Invoke(new Action(() => io_ListBox.Items.Clear()));
               bool isFetchedObjects = false;

               try
               {
                    foreach(T obj in i_Collection)
                    {
                         io_ListBox.Invoke(new Action(() => io_ListBox.Items.Add(obj)));
                    }

                    isFetchedObjects = io_ListBox.Items.Count > 0;
               }
               catch(Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }

               return isFetchedObjects;
          }

          public async void FetchHoroscope(Label io_LabelHoroscopeResult, string i_Day, User i_SelectedUser)
          {
               try
               {
                    string userBirthday = getUserBirthday(i_SelectedUser);
                    string sign = Horoscope.GetUserSign(userBirthday);
                    Horoscope horoscope = await Horoscope.GetHoroscopeForUser(sign, i_Day);

                    io_LabelHoroscopeResult.Invoke(new Action(() => io_LabelHoroscopeResult.Text = horoscope.ToString()));
               }
               catch(Exception exception)
               {
                    io_LabelHoroscopeResult.Invoke(new Action(() => io_LabelHoroscopeResult.Text = k_NoItemsToShow));
               }
          }

          public void FetchBirthday(Label io_LabelBirthday)
          {
               string birthDay = getUserBirthday();

               if(birthDay == null)
               {
                    io_LabelBirthday.Invoke(new Action(() => io_LabelBirthday.Text = k_FailedToGetInfo));
               }
               else
               {
                    io_LabelBirthday.Invoke(new Action(() => io_LabelBirthday.Text = birthDay));
               }
          }

          private string getUserBirthday()
          {
               string birthDay;

               try
               {
                    birthDay = m_LoggedInUser.Birthday;
               }
               catch(Exception exception)
               {
                    birthDay = null;
               }

               return birthDay;
          }

          private string getUserBirthday(User i_SelectedUser)
          {
               string birthDay;

               try
               {
                    birthDay = i_SelectedUser.Birthday;
               }
               catch(Exception exception)
               {
                    birthDay = null;
               }

               return birthDay;
          }

          public void FetchUserEducation(Label io_LabelEducation)
          {
               FetchPersonalInfo fetch = new FetchPersonalInfo(() => (m_LoggedInUser.Educations?.ToString()));
               fetch.Fetch(io_LabelEducation);
               /*try
               {
                    io_LabelEducation.Text = m_LoggedInUser.Educations?.ToString();
               }
               catch(Exception ex)
               {
                    io_LabelEducation.Text = k_FailedToGetInfo;
               }*/
          }

          public void FetchHometown(Label io_LabelHomeTown)
          {
               FetchPersonalInfo fetch = new FetchPersonalInfo(() => (m_LoggedInUser.Hometown?.Name));
               fetch.Fetch(io_LabelHomeTown);
          }

          public void FetchInterestedIn(Label io_LabelInterestedIn)
          {
               FetchPersonalInfo fetch = new FetchPersonalInfo(() => (m_LoggedInUser.InterestedIn?.ToString()));
               fetch.Fetch(io_LabelInterestedIn);
          }

          public void FetchGender(Label io_LabelGender)
          {
               FetchPersonalInfo fetch = new FetchPersonalInfo(getGender);
               fetch.Fetch(io_LabelGender);
          }

          private string getGender()
          {
               string genderToReturn;
               switch (m_LoggedInUser.Gender)
               {
                    case User.eGender.female:
                         genderToReturn = k_FemaleGender;
                         break;
                    case User.eGender.male:
                         genderToReturn = k_MaleGender;
                         break;
                    default:
                         genderToReturn = k_IrrelevantGender;
                         break;
               }

               return genderToReturn;
          }

          public void FetchEmail(Label io_LabelEmail)
          {
               FetchPersonalInfo fetch = new FetchPersonalInfo(() => (m_LoggedInUser.Email));
               fetch.Fetch(io_LabelEmail);
          }

          public void FetchEvents(
               BindingSource i_EventBindingSource,
               FacebookObjectCollection<Event> i_Events,
               ListBox i_EventsListBox)
          {
               i_EventBindingSource.DataSource = i_Events;
               VisibilityManager.ChangeListBoxVisibilityAccordingToEmptiness(i_EventsListBox);
          }

          public void FetchAlbumCover(
               Album i_SelectedAlbum,
               PictureBox io_PictureBoxAlbumCover,
               PictureBox i_PictureBoxProfilePic)
          {
               try
               {
                    if(i_SelectedAlbum.PictureAlbumURL != null)
                    {
                         io_PictureBoxAlbumCover.LoadAsync(i_SelectedAlbum.PictureAlbumURL);
                         io_PictureBoxAlbumCover.Visible = true;
                    }
                    else
                    {
                         io_PictureBoxAlbumCover.Image = i_PictureBoxProfilePic.ErrorImage;
                    }
               }
               catch(Exception ex)
               {
                    MessageBox.Show(ex.Message);
               }
          }

          public void FetchFriendProfilePic(User i_Friend, PictureBox io_PictureBoxFriendProfilePic)
          {
               try
               {
                    io_PictureBoxFriendProfilePic.LoadAsync(i_Friend.PictureLargeURL);
               }
               catch(Exception ex)
               {
                    io_PictureBoxFriendProfilePic.Image = io_PictureBoxFriendProfilePic.ErrorImage;
               }
          }

          private class FetchPersonalInfo
          {
               private Func<string> getInfoFunc { get; set; }

               public FetchPersonalInfo(Func<string> i_GetInfoFunc)
               {
                    getInfoFunc = i_GetInfoFunc;
               }

               public void Fetch(Label io_Label)
               {
                    try
                    {
                         io_Label.Invoke(new Action(() => getInfoFunc.Invoke()));
                    }
                    catch(Exception e)
                    {
                         io_Label.Invoke(new Action(() => io_Label.Text = k_FailedToGetInfo));
                    }
               }
          }
     }
}
