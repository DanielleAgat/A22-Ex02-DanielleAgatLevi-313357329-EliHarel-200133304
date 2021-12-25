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
        private static SingletonUserInfo sr_UserInfo;
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
                  if (sr_UserInfo == null)
                  {
                       lock (sr_Lock)
                       {
                            if (sr_UserInfo == null)
                            {
                                 sr_UserInfo = new SingletonUserInfo();
                            }
                       }
                  }

                  return sr_UserInfo;
             }
        }

          public static string[] SetUsersChosenPermissions(CheckedListBox i_CheckedListBoxPermissions)
        {
            int checkedItemsCount = i_CheckedListBoxPermissions.CheckedItems.Count;
            string[] permissions = new string[checkedItemsCount + BasicFacebookLogic.sr_ConstantPermissions.Length];

            for (int i = 0; i < checkedItemsCount; i++)
            {
                permissions[i] = i_CheckedListBoxPermissions.CheckedItems[i].ToString();
            }

            return permissions;
        }

        public void FetchNewsFeed(ListBox io_ListBoxNewsFeed)
        {
            if (m_LoggedInUser != null)
            {
                // io_ListBoxNewsFeed.Items.Clear(); // Old, pre-threads

                io_ListBoxNewsFeed.Invoke(new Action( () => io_ListBoxNewsFeed.Items.Clear()));

                //addPostsToListBox(ref io_ListBoxNewsFeed, m_LoggedInUser.NewsFeed);
                addPostsToListBox(io_ListBoxNewsFeed, m_LoggedInUser.NewsFeed); // Trying without "ref", because threads didn't allow it

            }
        }

        private void addPostsToListBox(ListBox io_ListBox, FacebookObjectCollection<Post> i_Posts)
        {
            foreach (Post post in i_Posts)
            {
                if (post.Message != null)
                {
                    // io_ListBox.Items.Add(post.Message);

                    io_ListBox.Invoke(new Action(() => io_ListBox.Items.Add(post.Message)));
                }
            }
        }

        private void addPostsToListBox(ref ListBox io_ListBox, FacebookObjectCollection<Post> i_Posts)
        {
            foreach (Post post in i_Posts)
            {
                if (post.Message != null)
                {
                    io_ListBox.Items.Add(post.Message);
                }
            }
        }

        public void FetchPosts(ListBox io_ListBoxPosts)
        {
            if (m_LoggedInUser != null)
            {
                io_ListBoxPosts.Items.Clear();
                addPostsToListBoxPosts(io_ListBoxPosts);
            }
        }

        private void addPostsToListBoxPosts(ListBox io_ListBoxPosts)
        {
            foreach (Post post in m_LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                     io_ListBoxPosts.Invoke(new Action(
                          () => io_ListBoxPosts.Items.Add(post.Message)));
                }
                else if (post.Caption != null)
                {
                     io_ListBoxPosts.Invoke(new Action(
                          () => io_ListBoxPosts.Items.Add(post.Caption)));
                }
                else
                {
                     io_ListBoxPosts.Invoke(new Action(
                          () => io_ListBoxPosts.Items.Add(string.Format("[{0}]", post.Type))));
                }
            }
        }

        public bool FetchListBox<T>(BindingSource i_PageBindingSource, ListBox io_ListBoxLikedPages, FacebookObjectCollection<T> i_Collection)
        {
            i_PageBindingSource.DataSource = i_Collection;
            return i_Collection.Count > 0;
        }

        public bool FetchListBox<T>(ListBox io_ListBox, FacebookObjectCollection<T> i_Collection)
        {
            io_ListBox.Items.Clear();
            bool isFetchedObjects = false;

            try
            {
                foreach (T obj in i_Collection)
                {
                    io_ListBox.Items.Add(obj);
                }

                isFetchedObjects = io_ListBox.Items.Count > 0;
            }
            catch (Exception ex)
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

                io_LabelHoroscopeResult.Text = horoscope.ToString();
            }
            catch (Exception exception)
            {
                io_LabelHoroscopeResult.Text = k_NoItemsToShow;
            }
        }

        public void FetchBirthday(ref Label io_LabelBirthday)
        {
            string birthDay = getUserBirthday();

            if (birthDay == null)
            {
                io_LabelBirthday.Text = k_FailedToGetInfo;
            }
            else
            {
                io_LabelBirthday.Text = birthDay;
            }
        }

        private string getUserBirthday()
        {
            string birthDay;

            try
            {
                birthDay = m_LoggedInUser.Birthday;
            }
            catch (Exception exception)
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
            catch (Exception exception)
            {
                birthDay = null;
            }

            return birthDay;
        }

        public void FetchUserEducation(ref Label io_LabelEducation)
        {
            try
            {
                io_LabelEducation.Text = m_LoggedInUser.Educations?.ToString();
            }
            catch (Exception ex)
            {
                io_LabelEducation.Text = k_FailedToGetInfo;
            }
        }

        public void FetchHometown(ref Label io_LabelEducation)
        {
            try
            {
                io_LabelEducation.Text = m_LoggedInUser.Hometown?.Name;
            }
            catch (Exception exception)
            {
                io_LabelEducation.Text = k_FailedToGetInfo;
            }
        }

        public void FetchInterestedIn(ref Label io_LabelInterestedIn)
        {
            try
            {
                io_LabelInterestedIn.Text = m_LoggedInUser.InterestedIn?.ToString();
            }
            catch (Exception e)
            {
                io_LabelInterestedIn.Text = k_FailedToGetInfo;
            }
        }

        public void FetchGender(ref Label io_LabelGender)
        {
            try
            {
                switch (m_LoggedInUser.Gender)
                {
                    case User.eGender.female:
                        io_LabelGender.Text = k_FemaleGender;
                        break;
                    case User.eGender.male:
                        io_LabelGender.Text = k_MaleGender;
                        break;
                    default:
                        io_LabelGender.Text = k_IrrelevantGender;
                        break;
                }
            }
            catch (Exception e)
            {
                io_LabelGender.Text = k_FailedToGetInfo;
            }
        }

        public void FetchEmail(ref Label io_LabelEmail)
        {
            try
            {
                io_LabelEmail.Text = m_LoggedInUser.Email;
            }
            catch (Exception e)
            {
                io_LabelEmail.Text = k_FailedToGetInfo;
            }
        }

        public void FetchEvents(BindingSource i_EventBindingSource, FacebookObjectCollection<Event> i_Events, ListBox i_EventsListBox)
        {
            // TODO: delete if all else works
            //i_EventsListBox.Items.Clear();
            //foreach (Event fbEvent in i_Events)
            //{
            //     i_EventsListBox.Items.Add(fbEvent);
            //}

            i_EventBindingSource.DataSource = i_Events;
            VisibilityManager.ChangeListBoxVisibilityAccordingToEmptiness(i_EventsListBox);
        }

        public void FetchAlbumCover(Album i_SelectedAlbum, PictureBox io_PictureBoxAlbumCover,
                                     PictureBox i_PictureBoxProfilePic)
        {
            try
            {
                if (i_SelectedAlbum.PictureAlbumURL != null)
                {
                    io_PictureBoxAlbumCover.LoadAsync(i_SelectedAlbum.PictureAlbumURL);
                    io_PictureBoxAlbumCover.Visible = true;
                }
                else
                {
                    io_PictureBoxAlbumCover.Image = i_PictureBoxProfilePic.ErrorImage;
                }
            }
            catch (Exception ex)
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
            catch (Exception ex)
            {
                io_PictureBoxFriendProfilePic.Image = io_PictureBoxFriendProfilePic.ErrorImage;
            }
        }
    }
}
