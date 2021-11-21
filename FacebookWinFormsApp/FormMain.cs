using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using CheckersUIWindows;
using System.Text;
using BasicFacebookFeatures.Checkers;
using Logic;

namespace BasicFacebookFeatures
{
     public partial class FormMain : Form
     {
          private readonly string r_UnavailableDataStr = "Whoops, Facebook isn't sending this data anymore :(";
          private const string k_FailedToPost = "Failed to post! Please try again later";
          private const string k_PostedSuccessfully = "Status postd! ID: ";
          private const string k_FailedToLogout = "Failed to logout! Please try again later";
          private const string k_FailedToLogin = "Failed to login! Please try again later";
          private const string k_CaptionError = "Error!";
          private const string k_FailedToGetInfo = "N/A";
          private const string k_DayForHoroscope = "today";
          private const int k_NewsFeedIndex = 0;
          private const int k_PostIndex = 1;
          private const int k_FriendsIndex = 2;
          private const int k_AlbumIndex = 3;
          private const int k_LikedPagesIndex = 4;
          private const int k_EventsIndex = 5;
          private const int k_UserInfoIndex = 6;
          private const int k_GamesIndex = 7;
          private const int k_HoroscopeIndex = 8;
          private AppSettings m_AppSettings = null;
          private LoginResult m_LoginResult = null;
          private UserInfo m_UserInfo = null;
          private string m_CurrentUserToken = "";
          private readonly bool r_LoginState = true;
          private string[] m_Permissions;
          private readonly Control[] r_PermissionsControls;
          private readonly Control[] r_LoggedInControls;
          private readonly Control[] r_AlbumsControls;
          private readonly Control[] r_LikedPagesControls;
          private readonly Control[] r_FriendsControls;
          private readonly Control[] r_HoroscopeControls;

          public FormMain()
          {
               InitializeComponent();
               r_PermissionsControls = new Control[] { checkBoxSelectAllPermissions, checkedListBoxPermissions, labelPermissions };
               r_LoggedInControls = new Control[] { pictureBoxProfilePic, tabControlMain, buttonLogout, checkBoxRememberUser };
               r_AlbumsControls = new Control[] { listBoxAlbums, pictureBoxAlbumCoverPhoto };
               r_LikedPagesControls = new Control[] { listBoxLikedPages, pictureBoxLikedPage };
               r_FriendsControls = new Control[] { listBoxFriends, pictureBoxFriends };
               r_HoroscopeControls = new Control[] { listBoxHoroscopeDay, buttonGetHoroscope, listBoxFriendsHoroscope };

               FacebookService.s_CollectionLimit = 100;
               changeControlsVisibilityAccordingToState(!r_LoginState);
               loadAppSettings();
          }

          private void loadAppSettings()
          {
               m_AppSettings = AppSettings.LoadFromFile();
               StartPosition = FormStartPosition.Manual;
               Size = m_AppSettings.LastWindowSize;
               Location = m_AppSettings.LastWindowLocation;
               checkBoxRememberUser.Checked = m_AppSettings.IsRememberUser;
               if (m_AppSettings.IsRememberUser && !string.IsNullOrEmpty(m_AppSettings.LastAccessToken))
               {
                    m_LoginResult = FacebookService.Connect(m_AppSettings.LastAccessToken);
                    login();
               }
          }

          private void buttonLogin_Click(object i_Sender, EventArgs i_EventArgs)
          {
               m_Permissions = UserInfo.SetUsersChosenPermissions(checkedListBoxPermissions);
               int numOfPermissions = checkedListBoxPermissions.CheckedItems.Count;

               m_LoginResult = BasicFacebookLogic.Login(numOfPermissions, m_Permissions);
               login();
          }

          private void login()
          {
               if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
               {
                    m_CurrentUserToken = m_LoginResult.AccessToken;
                    loginFetchUserData(m_LoginResult);
               }
               else
               {
                    MessageBox.Show(k_FailedToLogin, k_CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
          }

          private void loginFetchUserData(LoginResult i_LoginResult)
          {
               User tempUser = i_LoginResult.LoggedInUser;
               m_UserInfo = new UserInfo(tempUser);

               changeLoginButtonAccordingToState(!r_LoginState);
               changeControlsVisibilityAccordingToState(r_LoginState);
               pictureBoxProfilePic.LoadAsync(m_UserInfo.LoggedInUser.PictureNormalURL);
               m_UserInfo.FetchNewsFeed(listBoxNewsFeed);
          }

          private void changeControlsVisibilityAccordingToState(bool i_IsLoginState)
          {
               VisibilityManager.ChangeControlsVisibility(!i_IsLoginState, r_PermissionsControls);
               VisibilityManager.ChangeControlsVisibility(i_IsLoginState, r_LoggedInControls);
          }

          private void changeLoginButtonAccordingToState(bool i_IsLoginState)
          {
               buttonLogin.Text = (i_IsLoginState) ? "Login" : $"{m_UserInfo.LoggedInUser.Name}";
               buttonLogin.Enabled = i_IsLoginState;
          }

          private void fetchInfo() // Not in use - we keep it in case we will want to trigger full fetch in the future
          {
               pictureBoxProfilePic.LoadAsync(m_UserInfo.LoggedInUser.PictureNormalURL);
               m_UserInfo.FetchNewsFeed(listBoxNewsFeed);
               m_UserInfo.FetchPosts(listBoxPosts);
               fetchUserData();
               bool isAnyAlbumsFetched = m_UserInfo.FetchListBox(listBoxAlbums, m_UserInfo.LoggedInUser.Albums);
               bool isAnyPagesFetched = m_UserInfo.FetchListBox(listBoxLikedPages, m_UserInfo.LoggedInUser.LikedPages);
               bool isAnyFriendsFetched = m_UserInfo.FetchListBox(listBoxFriends, m_UserInfo.LoggedInUser.Friends);

               changeTabsVisibilityAfterFetch(isAnyAlbumsFetched, isAnyPagesFetched, isAnyFriendsFetched);
          }

          private void changeTabsVisibilityAfterFetch(bool i_Albums, bool i_LikedPages, bool i_Friends)
          {
               VisibilityManager.ChangeTabVisibility(r_AlbumsControls, labelNoItemsAlbums, i_Albums);
               VisibilityManager.ChangeTabVisibility(r_LikedPagesControls, labelNoLikedPages, i_LikedPages);
               VisibilityManager.ChangeTabVisibility(r_FriendsControls, labelNoFriends, i_Friends);
          }

          private void fetchUserData()
          {
               m_UserInfo.FetchUserEducation(ref labelEducationText);
               m_UserInfo.FetchHometown(ref labelHometownText);
               m_UserInfo.FetchBirthday(ref labelBirthdayText);
               m_UserInfo.FetchGender(ref labelGenderText);
               m_UserInfo.FetchEmail(ref labelEmailText);
               m_UserInfo.FetchInterestedIn(ref labelInterestedInText);
          }

          private void buttonLogout_Click(object i_Sender, EventArgs i_EventArgs)
          {
               logoutProcess();
          }

          private void logoutProcess()
          {
               FacebookService.Logout(null, m_CurrentUserToken, buttonLogout_LogoutFailed);
               resetControllersToLoginState();
          }

          private void resetControllersToLoginState()
          {
               m_UserInfo.LoggedInUser = null;
               changeLoginButtonAccordingToState(r_LoginState);
               pictureBoxProfilePic.Image = null;
               changeControlsVisibilityAccordingToState(!r_LoginState);
               listBoxPosts.Items.Clear();
               listBoxAlbums.Items.Clear();
          }

          private void buttonLogout_LogoutFailed()
          {
               MessageBox.Show(k_FailedToLogout, k_CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
          }

          private void listBoxPosts_SelectedIndexChanged(object i_Sender, EventArgs i_EventArgs)
          {
               try
               {
                    Post selected = m_UserInfo.LoggedInUser.Posts[listBoxPosts.SelectedIndex];

                    listBoxPostComments.DataSource = selected.Comments;
               }
               catch (Exception exception)
               {
                    MessageBox.Show(r_UnavailableDataStr);
               }
          }

          private void listBoxAlbums_SelectedIndexChanged(object i_Sender, EventArgs i_EventArgs)
          {
               if (listBoxAlbums.SelectedItems.Count == 1)
               {
                    Album selectedAlbum = listBoxAlbums.SelectedItem as Album;

                    m_UserInfo.FetchAlbumCover(selectedAlbum, pictureBoxAlbumCoverPhoto, pictureBoxProfilePic);
               }
          }

          private void listBoxFriends_SelectedIndexChanged(object i_Sender, EventArgs i_EventArgs)
          {
               if (listBoxFriends.SelectedItems.Count == 1)
               {
                    User selectedFriend = listBoxFriends.SelectedItem as User;

                    m_UserInfo.FetchFriendProfilePic(selectedFriend, pictureBoxFriends);
               }
          }

          private void buttonPublish_Click(object i_Sender, EventArgs i_)
          {
               try
               {
                    Status postedStatus = m_UserInfo.LoggedInUser.PostStatus(textBoxWritePost.Text);

                    MessageBox.Show(k_PostedSuccessfully + postedStatus.Id);
                    textBoxWritePost.Clear();
                    m_UserInfo.FetchPosts(listBoxPosts);
               }
               catch (Exception ex)
               {
                    MessageBox.Show(k_FailedToPost);
               }
          }

          private void listBoxLikedPages_SelectedIndexChanged(object i_Sender, EventArgs i_)
          {
               try
               {
                    if (listBoxLikedPages.SelectedItems.Count == 1)
                    {
                         Page selectedPage = listBoxLikedPages.SelectedItem as Page;

                         pictureBoxLikedPage.LoadAsync(selectedPage.PictureLargeURL);
                    }
               }
               catch (Exception ex)
               {
               }
          }

          private void listBoxEvents_SelectedIndexChanged(object i_Sender, EventArgs i_)
          {
               try
               {
                    if (listBoxEvents.SelectedItems.Count == 1)
                    {
                         Event selectedEvent = listBoxEvents.SelectedItem as Event;

                         pictureBoxEvent.LoadAsync(selectedEvent.Cover.SourceURL);
                    }
               }
               catch (Exception ex)
               {
               }
          }

          private void buttonCheckersLaunch_Click(object i_Sender, EventArgs i_EventArgs)
          {
               FormGameSettings gameSettings = new FormGameSettings(m_UserInfo);

               gameSettings.ShowDialog();
               if (gameSettings.DialogResult == DialogResult.OK)
               {
                    FormBoard board = new FormBoard(gameSettings, m_UserInfo.LoggedInUser);

                    board.ShowDialog();
                    FormPostResult postResultForm = new FormPostResult(board);

                    postResultForm.ShowDialog();
                    if (postResultForm.DialogResult == DialogResult.Yes)
                    {
                         try
                         {
                              Status postedStatus = m_UserInfo.LoggedInUser.PostStatus(postResultForm.getMessageToPost());

                              MessageBox.Show(k_PostedSuccessfully + postedStatus.Id);
                         }
                         catch (Exception ex)
                         {
                              MessageBox.Show(k_FailedToPost);
                         }
                    }
               }
          }

          private void checkBoxSelectAll_CheckedChanged(object i_Sender, EventArgs i_EventArgs)
          {
               for (int i = 0; i < checkedListBoxPermissions.Items.Count; i++)
               {
                    checkedListBoxPermissions.SetItemChecked(i, checkBoxSelectAllPermissions.Checked);
               }
          }

          private void listBoxNewsFeed_SelectedIndexChanged(object i_Sender, EventArgs i_EventArgs)
          {
               try
               {
                    Post selected = m_UserInfo.LoggedInUser.NewsFeed[listBoxNewsFeed.SelectedIndex];

                    listBoxNewsFeedComments.DataSource = selected.Comments;
               }
               catch (Exception exception)
               {
                    MessageBox.Show(k_FailedToGetInfo);
               }
          }

          private void tabPageEventsCreated_Click(object i_Sender, EventArgs i_EventArgs)
          {
               m_UserInfo.FetchEvents(m_UserInfo.LoggedInUser.EventsCreated, listBoxEventsCreated);
          }

          private void tabPageEventsDeclined_Click(object i_Sender, EventArgs i_EventArgs)
          {
               m_UserInfo.FetchEvents(m_UserInfo.LoggedInUser.EventsDeclined, listBoxEventsDeclinde);
          }

          private void tabPageEventsMaybe_Click(object i_Sender, EventArgs i_EventArgs)
          {
               m_UserInfo.FetchEvents(m_UserInfo.LoggedInUser.EventsMaybe, listBoxEventsMaybe);
          }

          private void tabPageEventsNotYetReplied_Click(object i_Sender, EventArgs i_EventArgs)
          {
               m_UserInfo.FetchEvents(m_UserInfo.LoggedInUser.EventsNotYetReplied, listBoxEventsNotYetReplied);
          }

          private void tabPageEvents_Click(object i_Sender, EventArgs i_EventArgs)
          {
               m_UserInfo.FetchEvents(m_UserInfo.LoggedInUser.Events, listBoxEvents);
          }

          private void fetchAllEvents()
          {
               m_UserInfo.FetchEvents(m_UserInfo.LoggedInUser.EventsCreated, listBoxEventsCreated);
               m_UserInfo.FetchEvents(m_UserInfo.LoggedInUser.EventsDeclined, listBoxEventsDeclinde);
               m_UserInfo.FetchEvents(m_UserInfo.LoggedInUser.EventsMaybe, listBoxEventsMaybe);
               m_UserInfo.FetchEvents(m_UserInfo.LoggedInUser.EventsNotYetReplied, listBoxEventsNotYetReplied);
               m_UserInfo.FetchEvents(m_UserInfo.LoggedInUser.Events, listBoxEvents);
          }

          private void tabControlMain_SelectedIndexChanges(object i_Sender, EventArgs i_EventArgs)
          {
               switch (tabControlMain.SelectedIndex)
               {
                    case k_NewsFeedIndex:
                         m_UserInfo.FetchNewsFeed(listBoxNewsFeed);
                         break;
                    case k_PostIndex:
                         m_UserInfo.FetchPosts(listBoxPosts);
                         break;
                    case k_AlbumIndex:
                         bool isAnyAlbumsFetched = m_UserInfo.FetchListBox(listBoxAlbums, m_UserInfo.LoggedInUser.Albums);

                         VisibilityManager.ChangeTabVisibility(r_AlbumsControls, labelNoItemsAlbums, isAnyAlbumsFetched);
                         break;
                    case k_EventsIndex:
                         fetchAllEvents();
                         break;
                    case k_FriendsIndex:
                         bool isAnyFriendsFetched = m_UserInfo.FetchListBox(listBoxFriends, m_UserInfo.LoggedInUser.Friends);

                         VisibilityManager.ChangeTabVisibility(r_FriendsControls, labelNoFriends, isAnyFriendsFetched);
                         break;
                    case k_HoroscopeIndex:
                         FacebookObjectCollection<User> usersToSend = getCollectionOfUserAndFriends(); // Add logged in user to top of list

                         isAnyFriendsFetched = m_UserInfo.FetchListBox(listBoxFriendsHoroscope, usersToSend);
                         listBoxFriendsHoroscope.SelectedIndex = 0;
                         listBoxHoroscopeDay.SelectedIndex = 0;
                         break;
                    case k_UserInfoIndex:
                         fetchUserData();
                         break;
                    case k_LikedPagesIndex:
                         bool isAnyPagesFetched = m_UserInfo.FetchListBox(listBoxLikedPages, m_UserInfo.LoggedInUser.LikedPages);

                         VisibilityManager.ChangeTabVisibility(r_LikedPagesControls, labelNoLikedPages, isAnyPagesFetched);
                         break;
                    default:
                         break;
               }
          }

          private FacebookObjectCollection<User> getCollectionOfUserAndFriends()
          {
               FacebookObjectCollection<User> userCollection = new FacebookObjectCollection<User> { m_UserInfo.LoggedInUser };

               foreach (User user in m_UserInfo.LoggedInUser.Friends)
               {
                    userCollection.Add(user);
               }

               return userCollection;
          }

          private void buttonGetHoroscope_Click(object i_Sender, EventArgs i_EventArgs)
          {
               string horoscopeMessageToPost;
               string horoscopeTitle = "Horoscope!";
               string day = listBoxHoroscopeDay.Text;
               User chosenUser = listBoxFriendsHoroscope.SelectedItem as User;

               m_UserInfo.FetchHoroscope(labelHoroscopeResult, day, chosenUser);
               labelHoroscopeResult.Visible = true;
               horoscopeMessageToPost = getHoroscopeMessageToPost(chosenUser);
          }

          private void offerToPost(string i_MessageToPost, string i_Title)
          {
               DialogResult dialogResult = MessageBox.Show(i_MessageToPost, i_Title, MessageBoxButtons.YesNo);

               if (dialogResult == DialogResult.Yes)
               {
                    m_UserInfo.LoggedInUser.PostStatus(i_MessageToPost);
               }
          }

          private string getHoroscopeMessageToPost(User i_ChosenUser)
          {
               string horoscopeMessageToPost = null;
               string userName;

               if (!string.IsNullOrEmpty(labelHoroscopeResult.Text) && i_ChosenUser != null)
               {
                    if (i_ChosenUser.Equals(m_UserInfo.LoggedInUser))
                    {
                         userName = "me";
                    }
                    else
                    {
                         userName = i_ChosenUser.Name;
                    }

                    horoscopeMessageToPost = $"This is what the stars foresee for {userName}:{Environment.NewLine}{Environment.NewLine}{labelHoroscopeResult}";
               }

               return horoscopeMessageToPost;
          }

          protected override void OnFormClosing(FormClosingEventArgs i_EventArgs)
          {
               base.OnFormClosing(i_EventArgs);
               if (checkBoxRememberUser.Checked)
               {
                    m_AppSettings.LastWindowSize = Size;
                    m_AppSettings.LastWindowLocation = Location;
                    m_AppSettings.IsRememberUser = checkBoxRememberUser.Checked;
                    m_AppSettings.LastAccessToken = m_LoginResult.AccessToken;
                    m_AppSettings.SaveToFile();
               }
               else
               {
                    m_AppSettings.SaveDefault();
               }
          }
     }
}
