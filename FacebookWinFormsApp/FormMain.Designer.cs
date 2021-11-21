using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
     partial class FormMain
     {
          /// <summary>
          /// Required designer variable.
          /// </summary>
          private IContainer components = null;

          /// <summary>
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.buttonLogin = new System.Windows.Forms.Button();
               this.buttonLogout = new System.Windows.Forms.Button();
               this.pictureBoxProfilePic = new System.Windows.Forms.PictureBox();
               this.listBoxPosts = new System.Windows.Forms.ListBox();
               this.listBoxAlbums = new System.Windows.Forms.ListBox();
               this.tabControlMain = new System.Windows.Forms.TabControl();
               this.tabPageNewsFeed = new System.Windows.Forms.TabPage();
               this.labelNewsFeed = new System.Windows.Forms.Label();
               this.labelCommentsNewsFeed = new System.Windows.Forms.Label();
               this.listBoxNewsFeedComments = new System.Windows.Forms.ListBox();
               this.listBoxNewsFeed = new System.Windows.Forms.ListBox();
               this.tabPagePosts = new System.Windows.Forms.TabPage();
               this.buttonPublish = new System.Windows.Forms.Button();
               this.labelWritePosts = new System.Windows.Forms.Label();
               this.labelPosts = new System.Windows.Forms.Label();
               this.textBoxWritePost = new System.Windows.Forms.TextBox();
               this.labelComments = new System.Windows.Forms.Label();
               this.listBoxPostComments = new System.Windows.Forms.ListBox();
               this.tabPageFriends = new System.Windows.Forms.TabPage();
               this.pictureBoxFriends = new System.Windows.Forms.PictureBox();
               this.labelNoFriends = new System.Windows.Forms.Label();
               this.listBoxFriends = new System.Windows.Forms.ListBox();
               this.tabPageAlbums = new System.Windows.Forms.TabPage();
               this.labelNoItemsAlbums = new System.Windows.Forms.Label();
               this.pictureBoxAlbumCoverPhoto = new System.Windows.Forms.PictureBox();
               this.tabPageLikedPages = new System.Windows.Forms.TabPage();
               this.labelNoLikedPages = new System.Windows.Forms.Label();
               this.pictureBoxLikedPage = new System.Windows.Forms.PictureBox();
               this.listBoxLikedPages = new System.Windows.Forms.ListBox();
               this.tabPageEvents = new System.Windows.Forms.TabPage();
               this.tabControlEvents = new System.Windows.Forms.TabControl();
               this.tabPageEventsEvents = new System.Windows.Forms.TabPage();
               this.pictureBoxEvent = new System.Windows.Forms.PictureBox();
               this.listBoxEvents = new System.Windows.Forms.ListBox();
               this.tabPageEventsCreated = new System.Windows.Forms.TabPage();
               this.pictureBoxEventsCreated = new System.Windows.Forms.PictureBox();
               this.listBoxEventsCreated = new System.Windows.Forms.ListBox();
               this.tabPageEventsDeclined = new System.Windows.Forms.TabPage();
               this.pictureBoxEventsDeclined = new System.Windows.Forms.PictureBox();
               this.listBoxEventsDeclinde = new System.Windows.Forms.ListBox();
               this.tabPageEventsMaybe = new System.Windows.Forms.TabPage();
               this.pictureBoxEventsMaybe = new System.Windows.Forms.PictureBox();
               this.listBoxEventsMaybe = new System.Windows.Forms.ListBox();
               this.tabPageEventsNotYetReplied = new System.Windows.Forms.TabPage();
               this.pictureBoxEventsNotYetReplied = new System.Windows.Forms.PictureBox();
               this.listBoxEventsNotYetReplied = new System.Windows.Forms.ListBox();
               this.tabPageUserInfo = new System.Windows.Forms.TabPage();
               this.labelInterestedInText = new System.Windows.Forms.Label();
               this.labelInterestedIn = new System.Windows.Forms.Label();
               this.labelEmailText = new System.Windows.Forms.Label();
               this.labelEmail = new System.Windows.Forms.Label();
               this.labelGenderText = new System.Windows.Forms.Label();
               this.labelGender = new System.Windows.Forms.Label();
               this.labelBirthdayText = new System.Windows.Forms.Label();
               this.labelBirthday = new System.Windows.Forms.Label();
               this.labelHometown = new System.Windows.Forms.Label();
               this.labelEducation = new System.Windows.Forms.Label();
               this.labelHometownText = new System.Windows.Forms.Label();
               this.labelEducationText = new System.Windows.Forms.Label();
               this.tabPageGames = new System.Windows.Forms.TabPage();
               this.labelGamesTabText = new System.Windows.Forms.Label();
               this.buttonCheckersLaunch = new System.Windows.Forms.Button();
               this.tabPageHoroscope = new System.Windows.Forms.TabPage();
               this.labelFriendsHoroscope = new System.Windows.Forms.Label();
               this.listBoxFriendsHoroscope = new System.Windows.Forms.ListBox();
               this.listBoxHoroscopeDay = new System.Windows.Forms.ListBox();
               this.buttonGetHoroscope = new System.Windows.Forms.Button();
               this.labelHoroscopeResult = new System.Windows.Forms.Label();
               this.checkedListBoxPermissions = new System.Windows.Forms.CheckedListBox();
               this.labelPermissions = new System.Windows.Forms.Label();
               this.checkBoxSelectAllPermissions = new System.Windows.Forms.CheckBox();
               this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePic)).BeginInit();
               this.tabControlMain.SuspendLayout();
               this.tabPageNewsFeed.SuspendLayout();
               this.tabPagePosts.SuspendLayout();
               this.tabPageFriends.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).BeginInit();
               this.tabPageAlbums.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumCoverPhoto)).BeginInit();
               this.tabPageLikedPages.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPage)).BeginInit();
               this.tabPageEvents.SuspendLayout();
               this.tabControlEvents.SuspendLayout();
               this.tabPageEventsEvents.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).BeginInit();
               this.tabPageEventsCreated.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventsCreated)).BeginInit();
               this.tabPageEventsDeclined.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventsDeclined)).BeginInit();
               this.tabPageEventsMaybe.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventsMaybe)).BeginInit();
               this.tabPageEventsNotYetReplied.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventsNotYetReplied)).BeginInit();
               this.tabPageUserInfo.SuspendLayout();
               this.tabPageGames.SuspendLayout();
               this.tabPageHoroscope.SuspendLayout();
               this.SuspendLayout();
               // 
               // buttonLogin
               // 
               this.buttonLogin.Location = new System.Drawing.Point(8, 9);
               this.buttonLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.buttonLogin.Name = "buttonLogin";
               this.buttonLogin.Size = new System.Drawing.Size(104, 23);
               this.buttonLogin.TabIndex = 36;
               this.buttonLogin.Text = "Login";
               this.buttonLogin.UseVisualStyleBackColor = true;
               this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
               // 
               // buttonLogout
               // 
               this.buttonLogout.Location = new System.Drawing.Point(8, 495);
               this.buttonLogout.Margin = new System.Windows.Forms.Padding(2, 156, 2, 3);
               this.buttonLogout.MinimumSize = new System.Drawing.Size(112, 23);
               this.buttonLogout.Name = "buttonLogout";
               this.buttonLogout.Size = new System.Drawing.Size(112, 23);
               this.buttonLogout.TabIndex = 52;
               this.buttonLogout.Text = "Logout";
               this.buttonLogout.UseVisualStyleBackColor = true;
               this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
               // 
               // pictureBoxProfilePic
               // 
               this.pictureBoxProfilePic.Location = new System.Drawing.Point(12, 77);
               this.pictureBoxProfilePic.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.pictureBoxProfilePic.Name = "pictureBoxProfilePic";
               this.pictureBoxProfilePic.Size = new System.Drawing.Size(100, 98);
               this.pictureBoxProfilePic.TabIndex = 54;
               this.pictureBoxProfilePic.TabStop = false;
               // 
               // listBoxPosts
               // 
               this.listBoxPosts.AccessibleName = "";
               this.listBoxPosts.FormattingEnabled = true;
               this.listBoxPosts.Location = new System.Drawing.Point(10, 141);
               this.listBoxPosts.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.listBoxPosts.MaximumSize = new System.Drawing.Size(380, 356);
               this.listBoxPosts.MinimumSize = new System.Drawing.Size(377, 314);
               this.listBoxPosts.Name = "listBoxPosts";
               this.listBoxPosts.Size = new System.Drawing.Size(380, 342);
               this.listBoxPosts.TabIndex = 55;
               this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
               // 
               // listBoxAlbums
               // 
               this.listBoxAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
               | System.Windows.Forms.AnchorStyles.Left)
               | System.Windows.Forms.AnchorStyles.Right)));
               this.listBoxAlbums.FormattingEnabled = true;
               this.listBoxAlbums.Location = new System.Drawing.Point(6, 3);
               this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.listBoxAlbums.Name = "listBoxAlbums";
               this.listBoxAlbums.Size = new System.Drawing.Size(209, 459);
               this.listBoxAlbums.TabIndex = 56;
               this.listBoxAlbums.Visible = false;
               this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
               // 
               // tabControlMain
               // 
               this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
               | System.Windows.Forms.AnchorStyles.Left)
               | System.Windows.Forms.AnchorStyles.Right)));
               this.tabControlMain.Controls.Add(this.tabPageNewsFeed);
               this.tabControlMain.Controls.Add(this.tabPagePosts);
               this.tabControlMain.Controls.Add(this.tabPageFriends);
               this.tabControlMain.Controls.Add(this.tabPageAlbums);
               this.tabControlMain.Controls.Add(this.tabPageLikedPages);
               this.tabControlMain.Controls.Add(this.tabPageEvents);
               this.tabControlMain.Controls.Add(this.tabPageUserInfo);
               this.tabControlMain.Controls.Add(this.tabPageGames);
               this.tabControlMain.Controls.Add(this.tabPageHoroscope);
               this.tabControlMain.Location = new System.Drawing.Point(132, 9);
               this.tabControlMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.tabControlMain.Name = "tabControlMain";
               this.tabControlMain.SelectedIndex = 0;
               this.tabControlMain.Size = new System.Drawing.Size(607, 539);
               this.tabControlMain.TabIndex = 57;
               this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanges);
               // 
               // tabPageNewsFeed
               // 
               this.tabPageNewsFeed.Controls.Add(this.labelNewsFeed);
               this.tabPageNewsFeed.Controls.Add(this.labelCommentsNewsFeed);
               this.tabPageNewsFeed.Controls.Add(this.listBoxNewsFeedComments);
               this.tabPageNewsFeed.Controls.Add(this.listBoxNewsFeed);
               this.tabPageNewsFeed.Location = new System.Drawing.Point(4, 22);
               this.tabPageNewsFeed.Name = "tabPageNewsFeed";
               this.tabPageNewsFeed.Padding = new System.Windows.Forms.Padding(3);
               this.tabPageNewsFeed.Size = new System.Drawing.Size(599, 513);
               this.tabPageNewsFeed.TabIndex = 9;
               this.tabPageNewsFeed.Text = "Feed";
               this.tabPageNewsFeed.UseVisualStyleBackColor = true;
               // 
               // labelNewsFeed
               // 
               this.labelNewsFeed.AutoSize = true;
               this.labelNewsFeed.Location = new System.Drawing.Point(5, 12);
               this.labelNewsFeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.labelNewsFeed.Name = "labelNewsFeed";
               this.labelNewsFeed.Size = new System.Drawing.Size(61, 13);
               this.labelNewsFeed.TabIndex = 63;
               this.labelNewsFeed.Text = "News Feed";
               // 
               // labelCommentsNewsFeed
               // 
               this.labelCommentsNewsFeed.AutoSize = true;
               this.labelCommentsNewsFeed.Location = new System.Drawing.Point(392, 12);
               this.labelCommentsNewsFeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.labelCommentsNewsFeed.Name = "labelCommentsNewsFeed";
               this.labelCommentsNewsFeed.Size = new System.Drawing.Size(56, 13);
               this.labelCommentsNewsFeed.TabIndex = 62;
               this.labelCommentsNewsFeed.Text = "Comments";
               // 
               // listBoxNewsFeedComments
               // 
               this.listBoxNewsFeedComments.FormattingEnabled = true;
               this.listBoxNewsFeedComments.HorizontalScrollbar = true;
               this.listBoxNewsFeedComments.Location = new System.Drawing.Point(395, 27);
               this.listBoxNewsFeedComments.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.listBoxNewsFeedComments.MaximumSize = new System.Drawing.Size(187, 356);
               this.listBoxNewsFeedComments.MinimumSize = new System.Drawing.Size(152, 314);
               this.listBoxNewsFeedComments.Name = "listBoxNewsFeedComments";
               this.listBoxNewsFeedComments.Size = new System.Drawing.Size(187, 342);
               this.listBoxNewsFeedComments.TabIndex = 61;
               // 
               // listBoxNewsFeed
               // 
               this.listBoxNewsFeed.AccessibleName = "";
               this.listBoxNewsFeed.FormattingEnabled = true;
               this.listBoxNewsFeed.Location = new System.Drawing.Point(5, 27);
               this.listBoxNewsFeed.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.listBoxNewsFeed.MaximumSize = new System.Drawing.Size(380, 356);
               this.listBoxNewsFeed.MinimumSize = new System.Drawing.Size(377, 314);
               this.listBoxNewsFeed.Name = "listBoxNewsFeed";
               this.listBoxNewsFeed.Size = new System.Drawing.Size(380, 342);
               this.listBoxNewsFeed.TabIndex = 60;
               this.listBoxNewsFeed.SelectedIndexChanged += new System.EventHandler(this.listBoxNewsFeed_SelectedIndexChanged);
               // 
               // tabPagePosts
               // 
               this.tabPagePosts.Controls.Add(this.buttonPublish);
               this.tabPagePosts.Controls.Add(this.labelWritePosts);
               this.tabPagePosts.Controls.Add(this.labelPosts);
               this.tabPagePosts.Controls.Add(this.textBoxWritePost);
               this.tabPagePosts.Controls.Add(this.labelComments);
               this.tabPagePosts.Controls.Add(this.listBoxPostComments);
               this.tabPagePosts.Controls.Add(this.listBoxPosts);
               this.tabPagePosts.Location = new System.Drawing.Point(4, 22);
               this.tabPagePosts.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.tabPagePosts.Name = "tabPagePosts";
               this.tabPagePosts.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.tabPagePosts.Size = new System.Drawing.Size(599, 513);
               this.tabPagePosts.TabIndex = 1;
               this.tabPagePosts.Text = "Posts";
               this.tabPagePosts.UseVisualStyleBackColor = true;
               this.tabPagePosts.Click += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
               // 
               // buttonPublish
               // 
               this.buttonPublish.Location = new System.Drawing.Point(500, 54);
               this.buttonPublish.Margin = new System.Windows.Forms.Padding(2);
               this.buttonPublish.Name = "buttonPublish";
               this.buttonPublish.Size = new System.Drawing.Size(90, 35);
               this.buttonPublish.TabIndex = 61;
               this.buttonPublish.Text = "Publish";
               this.buttonPublish.UseVisualStyleBackColor = true;
               this.buttonPublish.Click += new System.EventHandler(this.buttonPublish_Click);
               // 
               // labelWritePosts
               // 
               this.labelWritePosts.AutoSize = true;
               this.labelWritePosts.Location = new System.Drawing.Point(10, 17);
               this.labelWritePosts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.labelWritePosts.Name = "labelWritePosts";
               this.labelWritePosts.Size = new System.Drawing.Size(59, 13);
               this.labelWritePosts.TabIndex = 60;
               this.labelWritePosts.Text = "Write Post:";
               // 
               // labelPosts
               // 
               this.labelPosts.AutoSize = true;
               this.labelPosts.Location = new System.Drawing.Point(10, 126);
               this.labelPosts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.labelPosts.Name = "labelPosts";
               this.labelPosts.Size = new System.Drawing.Size(36, 13);
               this.labelPosts.TabIndex = 59;
               this.labelPosts.Text = "Posts:";
               // 
               // textBoxWritePost
               // 
               this.textBoxWritePost.AcceptsReturn = true;
               this.textBoxWritePost.Location = new System.Drawing.Point(12, 32);
               this.textBoxWritePost.Margin = new System.Windows.Forms.Padding(2);
               this.textBoxWritePost.MaximumSize = new System.Drawing.Size(477, 88);
               this.textBoxWritePost.MinimumSize = new System.Drawing.Size(352, 54);
               this.textBoxWritePost.Multiline = true;
               this.textBoxWritePost.Name = "textBoxWritePost";
               this.textBoxWritePost.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
               this.textBoxWritePost.Size = new System.Drawing.Size(477, 88);
               this.textBoxWritePost.TabIndex = 58;
               // 
               // labelComments
               // 
               this.labelComments.AutoSize = true;
               this.labelComments.Location = new System.Drawing.Point(397, 126);
               this.labelComments.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.labelComments.Name = "labelComments";
               this.labelComments.Size = new System.Drawing.Size(56, 13);
               this.labelComments.TabIndex = 57;
               this.labelComments.Text = "Comments";
               // 
               // listBoxPostComments
               // 
               this.listBoxPostComments.FormattingEnabled = true;
               this.listBoxPostComments.HorizontalScrollbar = true;
               this.listBoxPostComments.Location = new System.Drawing.Point(400, 141);
               this.listBoxPostComments.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.listBoxPostComments.MaximumSize = new System.Drawing.Size(187, 356);
               this.listBoxPostComments.MinimumSize = new System.Drawing.Size(152, 314);
               this.listBoxPostComments.Name = "listBoxPostComments";
               this.listBoxPostComments.Size = new System.Drawing.Size(187, 342);
               this.listBoxPostComments.TabIndex = 56;
               // 
               // tabPageFriends
               // 
               this.tabPageFriends.Controls.Add(this.pictureBoxFriends);
               this.tabPageFriends.Controls.Add(this.labelNoFriends);
               this.tabPageFriends.Controls.Add(this.listBoxFriends);
               this.tabPageFriends.Location = new System.Drawing.Point(4, 22);
               this.tabPageFriends.Name = "tabPageFriends";
               this.tabPageFriends.Padding = new System.Windows.Forms.Padding(3);
               this.tabPageFriends.Size = new System.Drawing.Size(599, 513);
               this.tabPageFriends.TabIndex = 8;
               this.tabPageFriends.Text = "Friends";
               this.tabPageFriends.UseVisualStyleBackColor = true;
               // 
               // pictureBoxFriends
               // 
               this.pictureBoxFriends.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.pictureBoxFriends.Location = new System.Drawing.Point(219, 3);
               this.pictureBoxFriends.Margin = new System.Windows.Forms.Padding(2);
               this.pictureBoxFriends.Name = "pictureBoxFriends";
               this.pictureBoxFriends.Size = new System.Drawing.Size(254, 261);
               this.pictureBoxFriends.TabIndex = 58;
               this.pictureBoxFriends.TabStop = false;
               this.pictureBoxFriends.Visible = false;
               // 
               // labelNoFriends
               // 
               this.labelNoFriends.AutoSize = true;
               this.labelNoFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelNoFriends.Location = new System.Drawing.Point(160, 164);
               this.labelNoFriends.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.labelNoFriends.Name = "labelNoFriends";
               this.labelNoFriends.Size = new System.Drawing.Size(250, 22);
               this.labelNoFriends.TabIndex = 2;
               this.labelNoFriends.Text = "Whoops, there\'s nothing here!";
               // 
               // listBoxFriends
               // 
               this.listBoxFriends.FormattingEnabled = true;
               this.listBoxFriends.Location = new System.Drawing.Point(6, 3);
               this.listBoxFriends.Name = "listBoxFriends";
               this.listBoxFriends.Size = new System.Drawing.Size(209, 459);
               this.listBoxFriends.TabIndex = 1;
               this.listBoxFriends.Visible = false;
               this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
               // 
               // tabPageAlbums
               // 
               this.tabPageAlbums.Controls.Add(this.labelNoItemsAlbums);
               this.tabPageAlbums.Controls.Add(this.pictureBoxAlbumCoverPhoto);
               this.tabPageAlbums.Controls.Add(this.listBoxAlbums);
               this.tabPageAlbums.Location = new System.Drawing.Point(4, 22);
               this.tabPageAlbums.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.tabPageAlbums.Name = "tabPageAlbums";
               this.tabPageAlbums.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.tabPageAlbums.Size = new System.Drawing.Size(599, 513);
               this.tabPageAlbums.TabIndex = 2;
               this.tabPageAlbums.Text = "Albums";
               this.tabPageAlbums.UseVisualStyleBackColor = true;
               // 
               // labelNoItemsAlbums
               // 
               this.labelNoItemsAlbums.AutoSize = true;
               this.labelNoItemsAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelNoItemsAlbums.Location = new System.Drawing.Point(160, 164);
               this.labelNoItemsAlbums.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.labelNoItemsAlbums.Name = "labelNoItemsAlbums";
               this.labelNoItemsAlbums.Size = new System.Drawing.Size(250, 22);
               this.labelNoItemsAlbums.TabIndex = 58;
               this.labelNoItemsAlbums.Text = "Whoops, there\'s nothing here!";
               this.labelNoItemsAlbums.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // pictureBoxAlbumCoverPhoto
               // 
               this.pictureBoxAlbumCoverPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.pictureBoxAlbumCoverPhoto.Location = new System.Drawing.Point(219, 3);
               this.pictureBoxAlbumCoverPhoto.Margin = new System.Windows.Forms.Padding(2);
               this.pictureBoxAlbumCoverPhoto.Name = "pictureBoxAlbumCoverPhoto";
               this.pictureBoxAlbumCoverPhoto.Size = new System.Drawing.Size(262, 261);
               this.pictureBoxAlbumCoverPhoto.TabIndex = 57;
               this.pictureBoxAlbumCoverPhoto.TabStop = false;
               this.pictureBoxAlbumCoverPhoto.Visible = false;
               // 
               // tabPageLikedPages
               // 
               this.tabPageLikedPages.Controls.Add(this.labelNoLikedPages);
               this.tabPageLikedPages.Controls.Add(this.pictureBoxLikedPage);
               this.tabPageLikedPages.Controls.Add(this.listBoxLikedPages);
               this.tabPageLikedPages.Location = new System.Drawing.Point(4, 22);
               this.tabPageLikedPages.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.tabPageLikedPages.Name = "tabPageLikedPages";
               this.tabPageLikedPages.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.tabPageLikedPages.Size = new System.Drawing.Size(599, 513);
               this.tabPageLikedPages.TabIndex = 4;
               this.tabPageLikedPages.Text = "Liked Pages";
               this.tabPageLikedPages.UseVisualStyleBackColor = true;
               // 
               // labelNoLikedPages
               // 
               this.labelNoLikedPages.AllowDrop = true;
               this.labelNoLikedPages.AutoSize = true;
               this.labelNoLikedPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelNoLikedPages.Location = new System.Drawing.Point(160, 164);
               this.labelNoLikedPages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.labelNoLikedPages.Name = "labelNoLikedPages";
               this.labelNoLikedPages.Size = new System.Drawing.Size(250, 22);
               this.labelNoLikedPages.TabIndex = 2;
               this.labelNoLikedPages.Text = "Whoops, there\'s nothing here!";
               this.labelNoLikedPages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // pictureBoxLikedPage
               // 
               this.pictureBoxLikedPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.pictureBoxLikedPage.Location = new System.Drawing.Point(219, 3);
               this.pictureBoxLikedPage.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.pictureBoxLikedPage.Name = "pictureBoxLikedPage";
               this.pictureBoxLikedPage.Size = new System.Drawing.Size(254, 261);
               this.pictureBoxLikedPage.TabIndex = 1;
               this.pictureBoxLikedPage.TabStop = false;
               this.pictureBoxLikedPage.Visible = false;
               // 
               // listBoxLikedPages
               // 
               this.listBoxLikedPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
               | System.Windows.Forms.AnchorStyles.Left)
               | System.Windows.Forms.AnchorStyles.Right)));
               this.listBoxLikedPages.FormattingEnabled = true;
               this.listBoxLikedPages.Location = new System.Drawing.Point(6, 3);
               this.listBoxLikedPages.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.listBoxLikedPages.Name = "listBoxLikedPages";
               this.listBoxLikedPages.Size = new System.Drawing.Size(209, 459);
               this.listBoxLikedPages.TabIndex = 0;
               this.listBoxLikedPages.Visible = false;
               this.listBoxLikedPages.SelectedIndexChanged += new System.EventHandler(this.listBoxLikedPages_SelectedIndexChanged);
               // 
               // tabPageEvents
               // 
               this.tabPageEvents.Controls.Add(this.tabControlEvents);
               this.tabPageEvents.Location = new System.Drawing.Point(4, 22);
               this.tabPageEvents.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.tabPageEvents.Name = "tabPageEvents";
               this.tabPageEvents.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.tabPageEvents.Size = new System.Drawing.Size(599, 513);
               this.tabPageEvents.TabIndex = 5;
               this.tabPageEvents.Text = "Events";
               this.tabPageEvents.UseVisualStyleBackColor = true;
               this.tabPageEvents.Click += new System.EventHandler(this.tabPageEvents_Click);
               // 
               // tabControlEvents
               // 
               this.tabControlEvents.Controls.Add(this.tabPageEventsEvents);
               this.tabControlEvents.Controls.Add(this.tabPageEventsCreated);
               this.tabControlEvents.Controls.Add(this.tabPageEventsDeclined);
               this.tabControlEvents.Controls.Add(this.tabPageEventsMaybe);
               this.tabControlEvents.Controls.Add(this.tabPageEventsNotYetReplied);
               this.tabControlEvents.Location = new System.Drawing.Point(5, 9);
               this.tabControlEvents.Name = "tabControlEvents";
               this.tabControlEvents.SelectedIndex = 0;
               this.tabControlEvents.Size = new System.Drawing.Size(589, 498);
               this.tabControlEvents.TabIndex = 4;
               // 
               // tabPageEventsEvents
               // 
               this.tabPageEventsEvents.Controls.Add(this.pictureBoxEvent);
               this.tabPageEventsEvents.Controls.Add(this.listBoxEvents);
               this.tabPageEventsEvents.Location = new System.Drawing.Point(4, 22);
               this.tabPageEventsEvents.Name = "tabPageEventsEvents";
               this.tabPageEventsEvents.Padding = new System.Windows.Forms.Padding(3);
               this.tabPageEventsEvents.Size = new System.Drawing.Size(581, 472);
               this.tabPageEventsEvents.TabIndex = 0;
               this.tabPageEventsEvents.Text = "Events";
               this.tabPageEventsEvents.UseVisualStyleBackColor = true;
               // 
               // pictureBoxEvent
               // 
               this.pictureBoxEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.pictureBoxEvent.Location = new System.Drawing.Point(322, 3);
               this.pictureBoxEvent.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.pictureBoxEvent.Name = "pictureBoxEvent";
               this.pictureBoxEvent.Size = new System.Drawing.Size(250, 250);
               this.pictureBoxEvent.TabIndex = 3;
               this.pictureBoxEvent.TabStop = false;
               // 
               // listBoxEvents
               // 
               this.listBoxEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
               | System.Windows.Forms.AnchorStyles.Left)
               | System.Windows.Forms.AnchorStyles.Right)));
               this.listBoxEvents.FormattingEnabled = true;
               this.listBoxEvents.Location = new System.Drawing.Point(3, 3);
               this.listBoxEvents.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.listBoxEvents.Name = "listBoxEvents";
               this.listBoxEvents.Size = new System.Drawing.Size(316, 303);
               this.listBoxEvents.TabIndex = 2;
               this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
               // 
               // tabPageEventsCreated
               // 
               this.tabPageEventsCreated.Controls.Add(this.pictureBoxEventsCreated);
               this.tabPageEventsCreated.Controls.Add(this.listBoxEventsCreated);
               this.tabPageEventsCreated.Location = new System.Drawing.Point(4, 22);
               this.tabPageEventsCreated.Name = "tabPageEventsCreated";
               this.tabPageEventsCreated.Padding = new System.Windows.Forms.Padding(3);
               this.tabPageEventsCreated.Size = new System.Drawing.Size(581, 472);
               this.tabPageEventsCreated.TabIndex = 1;
               this.tabPageEventsCreated.Text = "Created";
               this.tabPageEventsCreated.UseVisualStyleBackColor = true;
               this.tabPageEventsCreated.Click += new System.EventHandler(this.tabPageEventsCreated_Click);
               // 
               // pictureBoxEventsCreated
               // 
               this.pictureBoxEventsCreated.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.pictureBoxEventsCreated.Location = new System.Drawing.Point(322, 3);
               this.pictureBoxEventsCreated.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.pictureBoxEventsCreated.Name = "pictureBoxEventsCreated";
               this.pictureBoxEventsCreated.Size = new System.Drawing.Size(250, 250);
               this.pictureBoxEventsCreated.TabIndex = 5;
               this.pictureBoxEventsCreated.TabStop = false;
               // 
               // listBoxEventsCreated
               // 
               this.listBoxEventsCreated.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
               | System.Windows.Forms.AnchorStyles.Left)
               | System.Windows.Forms.AnchorStyles.Right)));
               this.listBoxEventsCreated.FormattingEnabled = true;
               this.listBoxEventsCreated.Location = new System.Drawing.Point(3, 3);
               this.listBoxEventsCreated.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.listBoxEventsCreated.Name = "listBoxEventsCreated";
               this.listBoxEventsCreated.Size = new System.Drawing.Size(316, 303);
               this.listBoxEventsCreated.TabIndex = 4;
               // 
               // tabPageEventsDeclined
               // 
               this.tabPageEventsDeclined.Controls.Add(this.pictureBoxEventsDeclined);
               this.tabPageEventsDeclined.Controls.Add(this.listBoxEventsDeclinde);
               this.tabPageEventsDeclined.Location = new System.Drawing.Point(4, 22);
               this.tabPageEventsDeclined.Name = "tabPageEventsDeclined";
               this.tabPageEventsDeclined.Padding = new System.Windows.Forms.Padding(3);
               this.tabPageEventsDeclined.Size = new System.Drawing.Size(581, 472);
               this.tabPageEventsDeclined.TabIndex = 2;
               this.tabPageEventsDeclined.Text = "Declined";
               this.tabPageEventsDeclined.UseVisualStyleBackColor = true;
               this.tabPageEventsDeclined.Click += new System.EventHandler(this.tabPageEventsDeclined_Click);
               // 
               // pictureBoxEventsDeclined
               // 
               this.pictureBoxEventsDeclined.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.pictureBoxEventsDeclined.Location = new System.Drawing.Point(322, 3);
               this.pictureBoxEventsDeclined.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.pictureBoxEventsDeclined.Name = "pictureBoxEventsDeclined";
               this.pictureBoxEventsDeclined.Size = new System.Drawing.Size(250, 250);
               this.pictureBoxEventsDeclined.TabIndex = 7;
               this.pictureBoxEventsDeclined.TabStop = false;
               // 
               // listBoxEventsDeclinde
               // 
               this.listBoxEventsDeclinde.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
               | System.Windows.Forms.AnchorStyles.Left)
               | System.Windows.Forms.AnchorStyles.Right)));
               this.listBoxEventsDeclinde.FormattingEnabled = true;
               this.listBoxEventsDeclinde.Location = new System.Drawing.Point(3, 3);
               this.listBoxEventsDeclinde.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.listBoxEventsDeclinde.Name = "listBoxEventsDeclinde";
               this.listBoxEventsDeclinde.Size = new System.Drawing.Size(316, 303);
               this.listBoxEventsDeclinde.TabIndex = 6;
               // 
               // tabPageEventsMaybe
               // 
               this.tabPageEventsMaybe.Controls.Add(this.pictureBoxEventsMaybe);
               this.tabPageEventsMaybe.Controls.Add(this.listBoxEventsMaybe);
               this.tabPageEventsMaybe.Location = new System.Drawing.Point(4, 22);
               this.tabPageEventsMaybe.Name = "tabPageEventsMaybe";
               this.tabPageEventsMaybe.Padding = new System.Windows.Forms.Padding(3);
               this.tabPageEventsMaybe.Size = new System.Drawing.Size(581, 472);
               this.tabPageEventsMaybe.TabIndex = 3;
               this.tabPageEventsMaybe.Text = "Maybe";
               this.tabPageEventsMaybe.UseVisualStyleBackColor = true;
               this.tabPageEventsMaybe.Click += new System.EventHandler(this.tabPageEventsMaybe_Click);
               // 
               // pictureBoxEventsMaybe
               // 
               this.pictureBoxEventsMaybe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.pictureBoxEventsMaybe.Location = new System.Drawing.Point(322, 3);
               this.pictureBoxEventsMaybe.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.pictureBoxEventsMaybe.Name = "pictureBoxEventsMaybe";
               this.pictureBoxEventsMaybe.Size = new System.Drawing.Size(250, 250);
               this.pictureBoxEventsMaybe.TabIndex = 7;
               this.pictureBoxEventsMaybe.TabStop = false;
               // 
               // listBoxEventsMaybe
               // 
               this.listBoxEventsMaybe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
               | System.Windows.Forms.AnchorStyles.Left)
               | System.Windows.Forms.AnchorStyles.Right)));
               this.listBoxEventsMaybe.FormattingEnabled = true;
               this.listBoxEventsMaybe.Location = new System.Drawing.Point(3, 3);
               this.listBoxEventsMaybe.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.listBoxEventsMaybe.Name = "listBoxEventsMaybe";
               this.listBoxEventsMaybe.Size = new System.Drawing.Size(316, 303);
               this.listBoxEventsMaybe.TabIndex = 6;
               // 
               // tabPageEventsNotYetReplied
               // 
               this.tabPageEventsNotYetReplied.Controls.Add(this.pictureBoxEventsNotYetReplied);
               this.tabPageEventsNotYetReplied.Controls.Add(this.listBoxEventsNotYetReplied);
               this.tabPageEventsNotYetReplied.Location = new System.Drawing.Point(4, 22);
               this.tabPageEventsNotYetReplied.Name = "tabPageEventsNotYetReplied";
               this.tabPageEventsNotYetReplied.Padding = new System.Windows.Forms.Padding(3);
               this.tabPageEventsNotYetReplied.Size = new System.Drawing.Size(581, 472);
               this.tabPageEventsNotYetReplied.TabIndex = 4;
               this.tabPageEventsNotYetReplied.Text = "Not Yet Replied";
               this.tabPageEventsNotYetReplied.UseVisualStyleBackColor = true;
               this.tabPageEventsNotYetReplied.Click += new System.EventHandler(this.tabPageEventsNotYetReplied_Click);
               // 
               // pictureBoxEventsNotYetReplied
               // 
               this.pictureBoxEventsNotYetReplied.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
               this.pictureBoxEventsNotYetReplied.Location = new System.Drawing.Point(322, 3);
               this.pictureBoxEventsNotYetReplied.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.pictureBoxEventsNotYetReplied.Name = "pictureBoxEventsNotYetReplied";
               this.pictureBoxEventsNotYetReplied.Size = new System.Drawing.Size(250, 250);
               this.pictureBoxEventsNotYetReplied.TabIndex = 7;
               this.pictureBoxEventsNotYetReplied.TabStop = false;
               // 
               // listBoxEventsNotYetReplied
               // 
               this.listBoxEventsNotYetReplied.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
               | System.Windows.Forms.AnchorStyles.Left)
               | System.Windows.Forms.AnchorStyles.Right)));
               this.listBoxEventsNotYetReplied.FormattingEnabled = true;
               this.listBoxEventsNotYetReplied.Location = new System.Drawing.Point(3, 3);
               this.listBoxEventsNotYetReplied.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.listBoxEventsNotYetReplied.Name = "listBoxEventsNotYetReplied";
               this.listBoxEventsNotYetReplied.Size = new System.Drawing.Size(316, 303);
               this.listBoxEventsNotYetReplied.TabIndex = 6;
               // 
               // tabPageUserInfo
               // 
               this.tabPageUserInfo.Controls.Add(this.labelInterestedInText);
               this.tabPageUserInfo.Controls.Add(this.labelInterestedIn);
               this.tabPageUserInfo.Controls.Add(this.labelEmailText);
               this.tabPageUserInfo.Controls.Add(this.labelEmail);
               this.tabPageUserInfo.Controls.Add(this.labelGenderText);
               this.tabPageUserInfo.Controls.Add(this.labelGender);
               this.tabPageUserInfo.Controls.Add(this.labelBirthdayText);
               this.tabPageUserInfo.Controls.Add(this.labelBirthday);
               this.tabPageUserInfo.Controls.Add(this.labelHometown);
               this.tabPageUserInfo.Controls.Add(this.labelEducation);
               this.tabPageUserInfo.Controls.Add(this.labelHometownText);
               this.tabPageUserInfo.Controls.Add(this.labelEducationText);
               this.tabPageUserInfo.Location = new System.Drawing.Point(4, 22);
               this.tabPageUserInfo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.tabPageUserInfo.Name = "tabPageUserInfo";
               this.tabPageUserInfo.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.tabPageUserInfo.Size = new System.Drawing.Size(599, 513);
               this.tabPageUserInfo.TabIndex = 3;
               this.tabPageUserInfo.Text = "User Info";
               this.tabPageUserInfo.UseVisualStyleBackColor = true;
               // 
               // labelInterestedInText
               // 
               this.labelInterestedInText.AutoSize = true;
               this.labelInterestedInText.Location = new System.Drawing.Point(129, 147);
               this.labelInterestedInText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.labelInterestedInText.Name = "labelInterestedInText";
               this.labelInterestedInText.Size = new System.Drawing.Size(27, 13);
               this.labelInterestedInText.TabIndex = 13;
               this.labelInterestedInText.Text = "N\\A";
               // 
               // labelInterestedIn
               // 
               this.labelInterestedIn.AutoSize = true;
               this.labelInterestedIn.Location = new System.Drawing.Point(55, 147);
               this.labelInterestedIn.Name = "labelInterestedIn";
               this.labelInterestedIn.Size = new System.Drawing.Size(69, 13);
               this.labelInterestedIn.TabIndex = 12;
               this.labelInterestedIn.Text = "Interested In:";
               // 
               // labelEmailText
               // 
               this.labelEmailText.AutoSize = true;
               this.labelEmailText.Location = new System.Drawing.Point(129, 178);
               this.labelEmailText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.labelEmailText.Name = "labelEmailText";
               this.labelEmailText.Size = new System.Drawing.Size(27, 13);
               this.labelEmailText.TabIndex = 11;
               this.labelEmailText.Text = "N\\A";
               // 
               // labelEmail
               // 
               this.labelEmail.AutoSize = true;
               this.labelEmail.Location = new System.Drawing.Point(55, 178);
               this.labelEmail.Name = "labelEmail";
               this.labelEmail.Size = new System.Drawing.Size(35, 13);
               this.labelEmail.TabIndex = 10;
               this.labelEmail.Text = "Email:";
               // 
               // labelGenderText
               // 
               this.labelGenderText.AutoSize = true;
               this.labelGenderText.Location = new System.Drawing.Point(129, 115);
               this.labelGenderText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.labelGenderText.Name = "labelGenderText";
               this.labelGenderText.Size = new System.Drawing.Size(27, 13);
               this.labelGenderText.TabIndex = 9;
               this.labelGenderText.Text = "N\\A";
               // 
               // labelGender
               // 
               this.labelGender.AutoSize = true;
               this.labelGender.Location = new System.Drawing.Point(55, 115);
               this.labelGender.Name = "labelGender";
               this.labelGender.Size = new System.Drawing.Size(45, 13);
               this.labelGender.TabIndex = 8;
               this.labelGender.Text = "Gender:";
               // 
               // labelBirthdayText
               // 
               this.labelBirthdayText.AutoSize = true;
               this.labelBirthdayText.Location = new System.Drawing.Point(129, 82);
               this.labelBirthdayText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.labelBirthdayText.Name = "labelBirthdayText";
               this.labelBirthdayText.Size = new System.Drawing.Size(27, 13);
               this.labelBirthdayText.TabIndex = 7;
               this.labelBirthdayText.Text = "N\\A";
               // 
               // labelBirthday
               // 
               this.labelBirthday.AutoSize = true;
               this.labelBirthday.Location = new System.Drawing.Point(55, 82);
               this.labelBirthday.Name = "labelBirthday";
               this.labelBirthday.Size = new System.Drawing.Size(48, 13);
               this.labelBirthday.TabIndex = 6;
               this.labelBirthday.Text = "Birthday:";
               // 
               // labelHometown
               // 
               this.labelHometown.AutoSize = true;
               this.labelHometown.Location = new System.Drawing.Point(55, 51);
               this.labelHometown.Name = "labelHometown";
               this.labelHometown.Size = new System.Drawing.Size(61, 13);
               this.labelHometown.TabIndex = 5;
               this.labelHometown.Text = "Hometown:";
               // 
               // labelEducation
               // 
               this.labelEducation.AutoSize = true;
               this.labelEducation.Location = new System.Drawing.Point(55, 23);
               this.labelEducation.Name = "labelEducation";
               this.labelEducation.Size = new System.Drawing.Size(58, 13);
               this.labelEducation.TabIndex = 4;
               this.labelEducation.Text = "Education:";
               // 
               // labelHometownText
               // 
               this.labelHometownText.AutoSize = true;
               this.labelHometownText.Location = new System.Drawing.Point(129, 51);
               this.labelHometownText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.labelHometownText.Name = "labelHometownText";
               this.labelHometownText.Size = new System.Drawing.Size(27, 13);
               this.labelHometownText.TabIndex = 1;
               this.labelHometownText.Text = "N\\A";
               // 
               // labelEducationText
               // 
               this.labelEducationText.AutoSize = true;
               this.labelEducationText.Location = new System.Drawing.Point(129, 23);
               this.labelEducationText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.labelEducationText.Name = "labelEducationText";
               this.labelEducationText.Size = new System.Drawing.Size(27, 13);
               this.labelEducationText.TabIndex = 0;
               this.labelEducationText.Text = "N\\A";
               // 
               // tabPageGames
               // 
               this.tabPageGames.Controls.Add(this.labelGamesTabText);
               this.tabPageGames.Controls.Add(this.buttonCheckersLaunch);
               this.tabPageGames.Location = new System.Drawing.Point(4, 22);
               this.tabPageGames.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.tabPageGames.Name = "tabPageGames";
               this.tabPageGames.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.tabPageGames.Size = new System.Drawing.Size(599, 513);
               this.tabPageGames.TabIndex = 6;
               this.tabPageGames.Text = "Games";
               this.tabPageGames.UseVisualStyleBackColor = true;
               // 
               // labelGamesTabText
               // 
               this.labelGamesTabText.AllowDrop = true;
               this.labelGamesTabText.AutoSize = true;
               this.labelGamesTabText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.labelGamesTabText.Location = new System.Drawing.Point(91, 228);
               this.labelGamesTabText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.labelGamesTabText.Name = "labelGamesTabText";
               this.labelGamesTabText.Size = new System.Drawing.Size(360, 22);
               this.labelGamesTabText.TabIndex = 3;
               this.labelGamesTabText.Text = "That\'s all for now, but we hope to add more!";
               this.labelGamesTabText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // buttonCheckersLaunch
               // 
               this.buttonCheckersLaunch.Location = new System.Drawing.Point(159, 94);
               this.buttonCheckersLaunch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.buttonCheckersLaunch.Name = "buttonCheckersLaunch";
               this.buttonCheckersLaunch.Size = new System.Drawing.Size(220, 85);
               this.buttonCheckersLaunch.TabIndex = 0;
               this.buttonCheckersLaunch.Text = "Checkers! :D";
               this.buttonCheckersLaunch.UseVisualStyleBackColor = true;
               this.buttonCheckersLaunch.Click += new System.EventHandler(this.buttonCheckersLaunch_Click);
               // 
               // tabPageHoroscope
               // 
               this.tabPageHoroscope.Controls.Add(this.labelFriendsHoroscope);
               this.tabPageHoroscope.Controls.Add(this.listBoxFriendsHoroscope);
               this.tabPageHoroscope.Controls.Add(this.listBoxHoroscopeDay);
               this.tabPageHoroscope.Controls.Add(this.buttonGetHoroscope);
               this.tabPageHoroscope.Controls.Add(this.labelHoroscopeResult);
               this.tabPageHoroscope.Location = new System.Drawing.Point(4, 22);
               this.tabPageHoroscope.Margin = new System.Windows.Forms.Padding(2);
               this.tabPageHoroscope.Name = "tabPageHoroscope";
               this.tabPageHoroscope.Padding = new System.Windows.Forms.Padding(2);
               this.tabPageHoroscope.Size = new System.Drawing.Size(599, 513);
               this.tabPageHoroscope.TabIndex = 7;
               this.tabPageHoroscope.Text = "Horoscope";
               this.tabPageHoroscope.UseVisualStyleBackColor = true;
               // 
               // labelFriendsHoroscope
               // 
               this.labelFriendsHoroscope.AutoSize = true;
               this.labelFriendsHoroscope.Location = new System.Drawing.Point(23, 130);
               this.labelFriendsHoroscope.Name = "labelFriendsHoroscope";
               this.labelFriendsHoroscope.Size = new System.Drawing.Size(134, 13);
               this.labelFriendsHoroscope.TabIndex = 6;
               this.labelFriendsHoroscope.Text = "Friends to spy on (and you)";
               // 
               // listBoxFriendsHoroscope
               // 
               this.listBoxFriendsHoroscope.FormattingEnabled = true;
               this.listBoxFriendsHoroscope.Location = new System.Drawing.Point(23, 147);
               this.listBoxFriendsHoroscope.Name = "listBoxFriendsHoroscope";
               this.listBoxFriendsHoroscope.Size = new System.Drawing.Size(134, 251);
               this.listBoxFriendsHoroscope.TabIndex = 2;
               // 
               // listBoxHoroscopeDay
               // 
               this.listBoxHoroscopeDay.FormattingEnabled = true;
               this.listBoxHoroscopeDay.Items.AddRange(new object[] {
            "today",
            "yesterday",
            "tomorrow"});
               this.listBoxHoroscopeDay.Location = new System.Drawing.Point(26, 46);
               this.listBoxHoroscopeDay.Name = "listBoxHoroscopeDay";
               this.listBoxHoroscopeDay.Size = new System.Drawing.Size(131, 56);
               this.listBoxHoroscopeDay.TabIndex = 1;
               // 
               // buttonGetHoroscope
               // 
               this.buttonGetHoroscope.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.buttonGetHoroscope.Location = new System.Drawing.Point(23, 7);
               this.buttonGetHoroscope.Margin = new System.Windows.Forms.Padding(2);
               this.buttonGetHoroscope.Name = "buttonGetHoroscope";
               this.buttonGetHoroscope.Size = new System.Drawing.Size(134, 29);
               this.buttonGetHoroscope.TabIndex = 0;
               this.buttonGetHoroscope.Text = "Get horoscope!";
               this.buttonGetHoroscope.UseVisualStyleBackColor = true;
               this.buttonGetHoroscope.Click += new System.EventHandler(this.buttonGetHoroscope_Click);
               // 
               // labelHoroscopeResult
               // 
               this.labelHoroscopeResult.AllowDrop = true;
               this.labelHoroscopeResult.AutoSize = true;
               this.labelHoroscopeResult.Location = new System.Drawing.Point(202, 7);
               this.labelHoroscopeResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.labelHoroscopeResult.MaximumSize = new System.Drawing.Size(350, 312);
               this.labelHoroscopeResult.Name = "labelHoroscopeResult";
               this.labelHoroscopeResult.Size = new System.Drawing.Size(89, 13);
               this.labelHoroscopeResult.TabIndex = 0;
               this.labelHoroscopeResult.Text = "HoroscopeResult";
               // 
               // checkedListBoxPermissions
               // 
               this.checkedListBoxPermissions.CheckOnClick = true;
               this.checkedListBoxPermissions.FormattingEnabled = true;
               this.checkedListBoxPermissions.HorizontalScrollbar = true;
               this.checkedListBoxPermissions.Items.AddRange(new object[] {
            "user_friends",
            "user_posts",
            "user_photos",
            "pages_manage_posts",
            "pages_read_engagement",
            "user_gender",
            "user_hometown"});
               this.checkedListBoxPermissions.Location = new System.Drawing.Point(8, 68);
               this.checkedListBoxPermissions.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.checkedListBoxPermissions.Name = "checkedListBoxPermissions";
               this.checkedListBoxPermissions.Size = new System.Drawing.Size(156, 124);
               this.checkedListBoxPermissions.TabIndex = 58;
               // 
               // labelPermissions
               // 
               this.labelPermissions.AutoSize = true;
               this.labelPermissions.Location = new System.Drawing.Point(6, 45);
               this.labelPermissions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.labelPermissions.Name = "labelPermissions";
               this.labelPermissions.Size = new System.Drawing.Size(62, 13);
               this.labelPermissions.TabIndex = 59;
               this.labelPermissions.Text = "Permissions";
               // 
               // checkBoxSelectAllPermissions
               // 
               this.checkBoxSelectAllPermissions.AutoSize = true;
               this.checkBoxSelectAllPermissions.Location = new System.Drawing.Point(8, 213);
               this.checkBoxSelectAllPermissions.Name = "checkBoxSelectAllPermissions";
               this.checkBoxSelectAllPermissions.Size = new System.Drawing.Size(70, 17);
               this.checkBoxSelectAllPermissions.TabIndex = 60;
               this.checkBoxSelectAllPermissions.Text = "Select All";
               this.checkBoxSelectAllPermissions.UseVisualStyleBackColor = true;
               this.checkBoxSelectAllPermissions.CheckedChanged += new System.EventHandler(this.checkBoxSelectAll_CheckedChanged);
               // 
               // checkBoxRememberUser
               // 
               this.checkBoxRememberUser.AutoSize = true;
               this.checkBoxRememberUser.Location = new System.Drawing.Point(9, 40);
               this.checkBoxRememberUser.Name = "checkBoxRememberUser";
               this.checkBoxRememberUser.Size = new System.Drawing.Size(95, 17);
               this.checkBoxRememberUser.TabIndex = 61;
               this.checkBoxRememberUser.Text = "Remember Me";
               this.checkBoxRememberUser.UseVisualStyleBackColor = true;
               // 
               // FormMain
               // 
               this.AcceptButton = this.buttonLogin;
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.AutoScroll = true;
               this.ClientSize = new System.Drawing.Size(737, 520);
               this.Controls.Add(this.checkBoxRememberUser);
               this.Controls.Add(this.checkBoxSelectAllPermissions);
               this.Controls.Add(this.labelPermissions);
               this.Controls.Add(this.pictureBoxProfilePic);
               this.Controls.Add(this.checkedListBoxPermissions);
               this.Controls.Add(this.buttonLogout);
               this.Controls.Add(this.buttonLogin);
               this.Controls.Add(this.tabControlMain);
               this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
               this.Name = "FormMain";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Facebook (Sort of)";
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePic)).EndInit();
               this.tabControlMain.ResumeLayout(false);
               this.tabPageNewsFeed.ResumeLayout(false);
               this.tabPageNewsFeed.PerformLayout();
               this.tabPagePosts.ResumeLayout(false);
               this.tabPagePosts.PerformLayout();
               this.tabPageFriends.ResumeLayout(false);
               this.tabPageFriends.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).EndInit();
               this.tabPageAlbums.ResumeLayout(false);
               this.tabPageAlbums.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumCoverPhoto)).EndInit();
               this.tabPageLikedPages.ResumeLayout(false);
               this.tabPageLikedPages.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPage)).EndInit();
               this.tabPageEvents.ResumeLayout(false);
               this.tabControlEvents.ResumeLayout(false);
               this.tabPageEventsEvents.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEvent)).EndInit();
               this.tabPageEventsCreated.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventsCreated)).EndInit();
               this.tabPageEventsDeclined.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventsDeclined)).EndInit();
               this.tabPageEventsMaybe.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventsMaybe)).EndInit();
               this.tabPageEventsNotYetReplied.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventsNotYetReplied)).EndInit();
               this.tabPageUserInfo.ResumeLayout(false);
               this.tabPageUserInfo.PerformLayout();
               this.tabPageGames.ResumeLayout(false);
               this.tabPageGames.PerformLayout();
               this.tabPageHoroscope.ResumeLayout(false);
               this.tabPageHoroscope.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private Button buttonLogin;
          private Button buttonLogout;
          private PictureBox pictureBoxProfilePic;
          private ListBox listBoxPosts;
          private ListBox listBoxAlbums;
          private TabControl tabControlMain;
          private TabPage tabPagePosts;
          private TabPage tabPageAlbums;
          private CheckedListBox checkedListBoxPermissions;
          private Label labelPermissions;
          private Label labelComments;
          private ListBox listBoxPostComments;
          private Button buttonPublish;
          private Label labelWritePosts;
          private Label labelPosts;
          private TextBox textBoxWritePost;
          private PictureBox pictureBoxAlbumCoverPhoto;
          private TabPage tabPageUserInfo;
          private Label labelEducationText;
          private Label labelHometownText;
          private TabPage tabPageLikedPages;
          private ListBox listBoxLikedPages;
          private PictureBox pictureBoxLikedPage;
          private TabPage tabPageEvents;
          private PictureBox pictureBoxEvent;
          private ListBox listBoxEvents;
          private TabPage tabPageGames;
          private Button buttonCheckersLaunch;
          private TabPage tabPageHoroscope;
          private Label labelHoroscopeResult;
          private TabPage tabPageFriends;
          private ListBox listBoxFriends;
          private CheckBox checkBoxSelectAllPermissions;
          private Label labelHometown;
          private Label labelEducation;
          private Label labelBirthdayText;
          private Label labelBirthday;
          private Label labelGenderText;
          private Label labelGender;
          private Label labelEmailText;
          private Label labelEmail;
          private Label labelInterestedInText;
          private Label labelInterestedIn;
          private TabPage tabPageNewsFeed;
          private Label labelNewsFeed;
          private Label labelCommentsNewsFeed;
          private ListBox listBoxNewsFeedComments;
          private ListBox listBoxNewsFeed;
          private TabControl tabControlEvents;
          private TabPage tabPageEventsEvents;
          private TabPage tabPageEventsCreated;
          private PictureBox pictureBoxEventsCreated;
          private ListBox listBoxEventsCreated;
          private TabPage tabPageEventsDeclined;
          private PictureBox pictureBoxEventsDeclined;
          private ListBox listBoxEventsDeclinde;
          private TabPage tabPageEventsMaybe;
          private PictureBox pictureBoxEventsMaybe;
          private ListBox listBoxEventsMaybe;
          private TabPage tabPageEventsNotYetReplied;
          private PictureBox pictureBoxEventsNotYetReplied;
          private ListBox listBoxEventsNotYetReplied;
          private Label labelNoLikedPages;
          private Label labelNoFriends;
          private Label labelNoItemsAlbums;
          private Button buttonGetHoroscope;
          private PictureBox pictureBoxFriends;
          private Label labelGamesTabText;
          private CheckBox checkBoxRememberUser;
          private ListBox listBoxHoroscopeDay;
          private Label labelFriendsHoroscope;
          private ListBox listBoxFriendsHoroscope;
     }
}

