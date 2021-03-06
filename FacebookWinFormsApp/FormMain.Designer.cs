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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label endTimeLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label imageNormalLabel;
            System.Windows.Forms.Label linkToFacebookLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label startTimeLabel;
            System.Windows.Forms.Label descriptionLabel1;
            System.Windows.Forms.Label likesCountLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label talkingAboutCountLabel;
            System.Windows.Forms.Label websiteLabel;
            System.Windows.Forms.Label religionLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label aboutLabel;
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label descriptionLabel2;
            System.Windows.Forms.Label locationLabel1;
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.pictureBoxProfilePic = new System.Windows.Forms.PictureBox();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageNewsFeed = new System.Windows.Forms.TabPage();
            this.postBindingSourceNewsFeed = new System.Windows.Forms.BindingSource(this.components);
            this.labelNewsFeed = new System.Windows.Forms.Label();
            this.labelCommentsNewsFeed = new System.Windows.Forms.Label();
            this.listBoxNewsFeedComments = new System.Windows.Forms.ListBox();
            this.listBoxNewsFeedOld = new System.Windows.Forms.ListBox();
            this.tabPagePosts = new System.Windows.Forms.TabPage();
            this.buttonPublish = new System.Windows.Forms.Button();
            this.labelWritePosts = new System.Windows.Forms.Label();
            this.labelPosts = new System.Windows.Forms.Label();
            this.textBoxWritePost = new System.Windows.Forms.TextBox();
            this.labelComments = new System.Windows.Forms.Label();
            this.listBoxPostComments = new System.Windows.Forms.ListBox();
            this.tabPageFriends = new System.Windows.Forms.TabPage();
            this.panelUsersDetails = new System.Windows.Forms.Panel();
            this.aboutLabel1 = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birthdayLabel1 = new System.Windows.Forms.Label();
            this.emailLabel1 = new System.Windows.Forms.Label();
            this.imageLargePictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.religionLabel1 = new System.Windows.Forms.Label();
            this.labelNoFriends = new System.Windows.Forms.Label();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.tabPageAlbums = new System.Windows.Forms.TabPage();
            this.panelAlbumDetails = new System.Windows.Forms.Panel();
            this.createdTimeLabel1 = new System.Windows.Forms.Label();
            this.descriptionTextBox2 = new System.Windows.Forms.TextBox();
            this.imageAlbumPictureBox = new System.Windows.Forms.PictureBox();
            this.locationTextBox1 = new System.Windows.Forms.TextBox();
            this.labelNoItemsAlbums = new System.Windows.Forms.Label();
            this.tabPageLikedPages = new System.Windows.Forms.TabPage();
            this.panelLikedPagesDetails = new System.Windows.Forms.Panel();
            this.descriptionTextBox1 = new System.Windows.Forms.TextBox();
            this.pageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageNormalPictureBox1 = new System.Windows.Forms.PictureBox();
            this.likesCountTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.talkingAboutCountTextBox = new System.Windows.Forms.TextBox();
            this.websiteTextBox = new System.Windows.Forms.TextBox();
            this.labelNoLikedPages = new System.Windows.Forms.Label();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.tabPageEvents = new System.Windows.Forms.TabPage();
            this.panelEventDetails = new System.Windows.Forms.Panel();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.endTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.linkToFacebookLabel1 = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.startTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tabControlEvents = new System.Windows.Forms.TabControl();
            this.tabPageEventsEvents = new System.Windows.Forms.TabPage();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.tabPageEventsCreated = new System.Windows.Forms.TabPage();
            this.listBoxEventsCreated = new System.Windows.Forms.ListBox();
            this.tabPageEventsDeclined = new System.Windows.Forms.TabPage();
            this.listBoxEventsDeclinde = new System.Windows.Forms.ListBox();
            this.tabPageEventsMaybe = new System.Windows.Forms.TabPage();
            this.listBoxEventsMaybe = new System.Windows.Forms.ListBox();
            this.tabPageEventsNotYetReplied = new System.Windows.Forms.TabPage();
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
            this.photosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkedListBoxPermissions = new System.Windows.Forms.CheckedListBox();
            this.labelPermissions = new System.Windows.Forms.Label();
            this.checkBoxSelectAllPermissions = new System.Windows.Forms.CheckBox();
            this.checkBoxRememberUser = new System.Windows.Forms.CheckBox();
            this.commentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            descriptionLabel = new System.Windows.Forms.Label();
            endTimeLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            imageNormalLabel = new System.Windows.Forms.Label();
            linkToFacebookLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            startTimeLabel = new System.Windows.Forms.Label();
            descriptionLabel1 = new System.Windows.Forms.Label();
            likesCountLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            talkingAboutCountLabel = new System.Windows.Forms.Label();
            websiteLabel = new System.Windows.Forms.Label();
            religionLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            aboutLabel = new System.Windows.Forms.Label();
            createdTimeLabel = new System.Windows.Forms.Label();
            descriptionLabel2 = new System.Windows.Forms.Label();
            locationLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPageNewsFeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSourceNewsFeed)).BeginInit();
            this.tabPagePosts.SuspendLayout();
            this.tabPageFriends.SuspendLayout();
            this.panelUsersDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).BeginInit();
            this.tabPageAlbums.SuspendLayout();
            this.panelAlbumDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).BeginInit();
            this.tabPageLikedPages.SuspendLayout();
            this.panelLikedPagesDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox1)).BeginInit();
            this.tabPageEvents.SuspendLayout();
            this.panelEventDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.tabControlEvents.SuspendLayout();
            this.tabPageEventsEvents.SuspendLayout();
            this.tabPageEventsCreated.SuspendLayout();
            this.tabPageEventsDeclined.SuspendLayout();
            this.tabPageEventsMaybe.SuspendLayout();
            this.tabPageEventsNotYetReplied.SuspendLayout();
            this.tabPageUserInfo.SuspendLayout();
            this.tabPageGames.SuspendLayout();
            this.tabPageHoroscope.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(7, 18);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Description:";
            // 
            // endTimeLabel
            // 
            endTimeLabel.AutoSize = true;
            endTimeLabel.Location = new System.Drawing.Point(7, 45);
            endTimeLabel.Name = "endTimeLabel";
            endTimeLabel.Size = new System.Drawing.Size(55, 13);
            endTimeLabel.TabIndex = 2;
            endTimeLabel.Text = "End Time:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(7, 70);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 4;
            idLabel.Text = "Id:";
            // 
            // imageNormalLabel
            // 
            imageNormalLabel.AutoSize = true;
            imageNormalLabel.Location = new System.Drawing.Point(7, 93);
            imageNormalLabel.Name = "imageNormalLabel";
            imageNormalLabel.Size = new System.Drawing.Size(75, 13);
            imageNormalLabel.TabIndex = 6;
            imageNormalLabel.Text = "Image Normal:";
            // 
            // linkToFacebookLabel
            // 
            linkToFacebookLabel.AutoSize = true;
            linkToFacebookLabel.Location = new System.Drawing.Point(7, 146);
            linkToFacebookLabel.Name = "linkToFacebookLabel";
            linkToFacebookLabel.Size = new System.Drawing.Size(97, 13);
            linkToFacebookLabel.TabIndex = 8;
            linkToFacebookLabel.Text = "Link To Facebook:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(7, 175);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(51, 13);
            locationLabel.TabIndex = 10;
            locationLabel.Text = "Location:";
            // 
            // startTimeLabel
            // 
            startTimeLabel.AutoSize = true;
            startTimeLabel.Location = new System.Drawing.Point(7, 202);
            startTimeLabel.Name = "startTimeLabel";
            startTimeLabel.Size = new System.Drawing.Size(58, 13);
            startTimeLabel.TabIndex = 12;
            startTimeLabel.Text = "Start Time:";
            // 
            // descriptionLabel1
            // 
            descriptionLabel1.AutoSize = true;
            descriptionLabel1.Location = new System.Drawing.Point(19, 281);
            descriptionLabel1.Name = "descriptionLabel1";
            descriptionLabel1.Size = new System.Drawing.Size(63, 13);
            descriptionLabel1.TabIndex = 0;
            descriptionLabel1.Text = "Description:";
            // 
            // likesCountLabel
            // 
            likesCountLabel.AutoSize = true;
            likesCountLabel.Location = new System.Drawing.Point(19, 307);
            likesCountLabel.Name = "likesCountLabel";
            likesCountLabel.Size = new System.Drawing.Size(66, 13);
            likesCountLabel.TabIndex = 4;
            likesCountLabel.Text = "Likes Count:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(19, 333);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 6;
            phoneLabel.Text = "Phone:";
            // 
            // talkingAboutCountLabel
            // 
            talkingAboutCountLabel.AutoSize = true;
            talkingAboutCountLabel.Location = new System.Drawing.Point(19, 359);
            talkingAboutCountLabel.Name = "talkingAboutCountLabel";
            talkingAboutCountLabel.Size = new System.Drawing.Size(107, 13);
            talkingAboutCountLabel.TabIndex = 8;
            talkingAboutCountLabel.Text = "Talking About Count:";
            // 
            // websiteLabel
            // 
            websiteLabel.AutoSize = true;
            websiteLabel.Location = new System.Drawing.Point(19, 385);
            websiteLabel.Name = "websiteLabel";
            websiteLabel.Size = new System.Drawing.Size(49, 13);
            websiteLabel.TabIndex = 10;
            websiteLabel.Text = "Website:";
            // 
            // religionLabel
            // 
            religionLabel.AutoSize = true;
            religionLabel.Location = new System.Drawing.Point(237, 100);
            religionLabel.Name = "religionLabel";
            religionLabel.Size = new System.Drawing.Size(48, 13);
            religionLabel.TabIndex = 10;
            religionLabel.Text = "Religion:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(237, 8);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 8;
            nameLabel.Text = "Name:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(237, 77);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(237, 54);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(48, 13);
            birthdayLabel.TabIndex = 2;
            birthdayLabel.Text = "Birthday:";
            // 
            // aboutLabel
            // 
            aboutLabel.AutoSize = true;
            aboutLabel.Location = new System.Drawing.Point(237, 31);
            aboutLabel.Name = "aboutLabel";
            aboutLabel.Size = new System.Drawing.Size(38, 13);
            aboutLabel.TabIndex = 0;
            aboutLabel.Text = "About:";
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Location = new System.Drawing.Point(20, 273);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(73, 13);
            createdTimeLabel.TabIndex = 0;
            createdTimeLabel.Text = "Created Time:";
            // 
            // descriptionLabel2
            // 
            descriptionLabel2.AutoSize = true;
            descriptionLabel2.Location = new System.Drawing.Point(20, 214);
            descriptionLabel2.Name = "descriptionLabel2";
            descriptionLabel2.Size = new System.Drawing.Size(63, 13);
            descriptionLabel2.TabIndex = 2;
            descriptionLabel2.Text = "Description:";
            // 
            // locationLabel1
            // 
            locationLabel1.AutoSize = true;
            locationLabel1.Location = new System.Drawing.Point(20, 240);
            locationLabel1.Name = "locationLabel1";
            locationLabel1.Size = new System.Drawing.Size(51, 13);
            locationLabel1.TabIndex = 6;
            locationLabel1.Text = "Location:";
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
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLogout.Location = new System.Drawing.Point(9, 655);
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
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(380, 277);
            this.listBoxPosts.TabIndex = 55;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxAlbums.DataSource = this.albumBindingSource;
            this.listBoxAlbums.DisplayMember = "Name";
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.Location = new System.Drawing.Point(13, 3);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(221, 628);
            this.listBoxAlbums.TabIndex = 56;
            this.listBoxAlbums.Visible = false;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
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
            this.tabControlMain.Location = new System.Drawing.Point(125, 9);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(714, 673);
            this.tabControlMain.TabIndex = 57;
            // 
            // tabPageNewsFeed
            // 
            this.tabPageNewsFeed.AutoScroll = true;
            this.tabPageNewsFeed.Controls.Add(this.labelNewsFeed);
            this.tabPageNewsFeed.Controls.Add(this.labelCommentsNewsFeed);
            this.tabPageNewsFeed.Controls.Add(this.listBoxNewsFeedComments);
            this.tabPageNewsFeed.Controls.Add(this.listBoxNewsFeedOld);
            this.tabPageNewsFeed.Location = new System.Drawing.Point(4, 22);
            this.tabPageNewsFeed.Name = "tabPageNewsFeed";
            this.tabPageNewsFeed.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNewsFeed.Size = new System.Drawing.Size(706, 647);
            this.tabPageNewsFeed.TabIndex = 9;
            this.tabPageNewsFeed.Text = "Feed";
            this.tabPageNewsFeed.UseVisualStyleBackColor = true;
            // 
            // postBindingSourceNewsFeed
            // 
            this.postBindingSourceNewsFeed.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // labelNewsFeed
            // 
            this.labelNewsFeed.AutoSize = true;
            this.labelNewsFeed.Location = new System.Drawing.Point(16, 9);
            this.labelNewsFeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNewsFeed.Name = "labelNewsFeed";
            this.labelNewsFeed.Size = new System.Drawing.Size(61, 13);
            this.labelNewsFeed.TabIndex = 63;
            this.labelNewsFeed.Text = "News Feed";
            // 
            // labelCommentsNewsFeed
            // 
            this.labelCommentsNewsFeed.AutoSize = true;
            this.labelCommentsNewsFeed.Location = new System.Drawing.Point(341, 9);
            this.labelCommentsNewsFeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCommentsNewsFeed.Name = "labelCommentsNewsFeed";
            this.labelCommentsNewsFeed.Size = new System.Drawing.Size(56, 13);
            this.labelCommentsNewsFeed.TabIndex = 62;
            this.labelCommentsNewsFeed.Text = "Comments";
            // 
            // listBoxNewsFeedComments
            // 
            this.listBoxNewsFeedComments.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBoxNewsFeedComments.FormattingEnabled = true;
            this.listBoxNewsFeedComments.HorizontalScrollbar = true;
            this.listBoxNewsFeedComments.Location = new System.Drawing.Point(344, 25);
            this.listBoxNewsFeedComments.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBoxNewsFeedComments.Name = "listBoxNewsFeedComments";
            this.listBoxNewsFeedComments.Size = new System.Drawing.Size(319, 368);
            this.listBoxNewsFeedComments.TabIndex = 61;
            // 
            // listBoxNewsFeedOld
            // 
            this.listBoxNewsFeedOld.AccessibleName = "";
            this.listBoxNewsFeedOld.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listBoxNewsFeedOld.FormattingEnabled = true;
            this.listBoxNewsFeedOld.Location = new System.Drawing.Point(19, 25);
            this.listBoxNewsFeedOld.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBoxNewsFeedOld.Name = "listBoxNewsFeedOld";
            this.listBoxNewsFeedOld.Size = new System.Drawing.Size(305, 368);
            this.listBoxNewsFeedOld.TabIndex = 60;
            this.listBoxNewsFeedOld.SelectedIndexChanged += new System.EventHandler(this.listBoxNewsFeed_SelectedIndexChanged);
            // 
            // tabPagePosts
            // 
            this.tabPagePosts.AutoScroll = true;
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
            this.tabPagePosts.Size = new System.Drawing.Size(706, 647);
            this.tabPagePosts.TabIndex = 1;
            this.tabPagePosts.Text = "Posts";
            this.tabPagePosts.UseVisualStyleBackColor = true;
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
            this.listBoxPostComments.Name = "listBoxPostComments";
            this.listBoxPostComments.Size = new System.Drawing.Size(187, 277);
            this.listBoxPostComments.TabIndex = 56;
            // 
            // tabPageFriends
            // 
            this.tabPageFriends.AutoScroll = true;
            this.tabPageFriends.Controls.Add(this.panelUsersDetails);
            this.tabPageFriends.Controls.Add(this.labelNoFriends);
            this.tabPageFriends.Controls.Add(this.listBoxFriends);
            this.tabPageFriends.Location = new System.Drawing.Point(4, 22);
            this.tabPageFriends.Name = "tabPageFriends";
            this.tabPageFriends.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFriends.Size = new System.Drawing.Size(706, 647);
            this.tabPageFriends.TabIndex = 8;
            this.tabPageFriends.Text = "Friends";
            this.tabPageFriends.UseVisualStyleBackColor = true;
            // 
            // panelUsersDetails
            // 
            this.panelUsersDetails.Controls.Add(aboutLabel);
            this.panelUsersDetails.Controls.Add(this.aboutLabel1);
            this.panelUsersDetails.Controls.Add(birthdayLabel);
            this.panelUsersDetails.Controls.Add(this.birthdayLabel1);
            this.panelUsersDetails.Controls.Add(emailLabel);
            this.panelUsersDetails.Controls.Add(this.emailLabel1);
            this.panelUsersDetails.Controls.Add(this.imageLargePictureBox);
            this.panelUsersDetails.Controls.Add(nameLabel);
            this.panelUsersDetails.Controls.Add(this.nameLabel1);
            this.panelUsersDetails.Controls.Add(religionLabel);
            this.panelUsersDetails.Controls.Add(this.religionLabel1);
            this.panelUsersDetails.Location = new System.Drawing.Point(149, 6);
            this.panelUsersDetails.Name = "panelUsersDetails";
            this.panelUsersDetails.Size = new System.Drawing.Size(551, 304);
            this.panelUsersDetails.TabIndex = 3;
            // 
            // aboutLabel1
            // 
            this.aboutLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "About", true));
            this.aboutLabel1.Location = new System.Drawing.Point(312, 31);
            this.aboutLabel1.Name = "aboutLabel1";
            this.aboutLabel1.Size = new System.Drawing.Size(100, 23);
            this.aboutLabel1.TabIndex = 1;
            this.aboutLabel1.Text = "label1";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // birthdayLabel1
            // 
            this.birthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Birthday", true));
            this.birthdayLabel1.Location = new System.Drawing.Point(312, 54);
            this.birthdayLabel1.Name = "birthdayLabel1";
            this.birthdayLabel1.Size = new System.Drawing.Size(100, 23);
            this.birthdayLabel1.TabIndex = 3;
            this.birthdayLabel1.Text = "label1";
            // 
            // emailLabel1
            // 
            this.emailLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Email", true));
            this.emailLabel1.Location = new System.Drawing.Point(312, 77);
            this.emailLabel1.Name = "emailLabel1";
            this.emailLabel1.Size = new System.Drawing.Size(100, 23);
            this.emailLabel1.TabIndex = 5;
            this.emailLabel1.Text = "label1";
            // 
            // imageLargePictureBox
            // 
            this.imageLargePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageLarge", true));
            this.imageLargePictureBox.Location = new System.Drawing.Point(15, 5);
            this.imageLargePictureBox.Name = "imageLargePictureBox";
            this.imageLargePictureBox.Size = new System.Drawing.Size(200, 200);
            this.imageLargePictureBox.TabIndex = 7;
            this.imageLargePictureBox.TabStop = false;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.nameLabel1.Location = new System.Drawing.Point(312, 8);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.nameLabel1.TabIndex = 9;
            this.nameLabel1.Text = "label1";
            // 
            // religionLabel1
            // 
            this.religionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Religion", true));
            this.religionLabel1.Location = new System.Drawing.Point(312, 100);
            this.religionLabel1.Name = "religionLabel1";
            this.religionLabel1.Size = new System.Drawing.Size(100, 23);
            this.religionLabel1.TabIndex = 11;
            this.religionLabel1.Text = "label1";
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
            this.listBoxFriends.DataSource = this.userBindingSource;
            this.listBoxFriends.DisplayMember = "Name";
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(6, 6);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(137, 212);
            this.listBoxFriends.TabIndex = 1;
            this.listBoxFriends.Visible = false;
            // 
            // tabPageAlbums
            // 
            this.tabPageAlbums.AutoScroll = true;
            this.tabPageAlbums.Controls.Add(this.panelAlbumDetails);
            this.tabPageAlbums.Controls.Add(this.labelNoItemsAlbums);
            this.tabPageAlbums.Controls.Add(this.listBoxAlbums);
            this.tabPageAlbums.Location = new System.Drawing.Point(4, 22);
            this.tabPageAlbums.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPageAlbums.Name = "tabPageAlbums";
            this.tabPageAlbums.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPageAlbums.Size = new System.Drawing.Size(706, 647);
            this.tabPageAlbums.TabIndex = 2;
            this.tabPageAlbums.Text = "Albums";
            this.tabPageAlbums.UseVisualStyleBackColor = true;
            // 
            // panelAlbumDetails
            // 
            this.panelAlbumDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAlbumDetails.Controls.Add(createdTimeLabel);
            this.panelAlbumDetails.Controls.Add(this.createdTimeLabel1);
            this.panelAlbumDetails.Controls.Add(descriptionLabel2);
            this.panelAlbumDetails.Controls.Add(this.descriptionTextBox2);
            this.panelAlbumDetails.Controls.Add(this.imageAlbumPictureBox);
            this.panelAlbumDetails.Controls.Add(locationLabel1);
            this.panelAlbumDetails.Controls.Add(this.locationTextBox1);
            this.panelAlbumDetails.Location = new System.Drawing.Point(316, 9);
            this.panelAlbumDetails.Name = "panelAlbumDetails";
            this.panelAlbumDetails.Size = new System.Drawing.Size(380, 437);
            this.panelAlbumDetails.TabIndex = 59;
            // 
            // createdTimeLabel1
            // 
            this.createdTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "CreatedTime", true));
            this.createdTimeLabel1.Location = new System.Drawing.Point(99, 273);
            this.createdTimeLabel1.Name = "createdTimeLabel1";
            this.createdTimeLabel1.Size = new System.Drawing.Size(100, 23);
            this.createdTimeLabel1.TabIndex = 1;
            this.createdTimeLabel1.Text = "label1";
            // 
            // descriptionTextBox2
            // 
            this.descriptionTextBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Description", true));
            this.descriptionTextBox2.Location = new System.Drawing.Point(99, 211);
            this.descriptionTextBox2.Name = "descriptionTextBox2";
            this.descriptionTextBox2.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextBox2.TabIndex = 3;
            // 
            // imageAlbumPictureBox
            // 
            this.imageAlbumPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumBindingSource, "ImageAlbum", true));
            this.imageAlbumPictureBox.Location = new System.Drawing.Point(15, 5);
            this.imageAlbumPictureBox.Name = "imageAlbumPictureBox";
            this.imageAlbumPictureBox.Size = new System.Drawing.Size(200, 200);
            this.imageAlbumPictureBox.TabIndex = 5;
            this.imageAlbumPictureBox.TabStop = false;
            // 
            // locationTextBox1
            // 
            this.locationTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Location", true));
            this.locationTextBox1.Location = new System.Drawing.Point(99, 237);
            this.locationTextBox1.Name = "locationTextBox1";
            this.locationTextBox1.Size = new System.Drawing.Size(100, 20);
            this.locationTextBox1.TabIndex = 7;
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
            // tabPageLikedPages
            // 
            this.tabPageLikedPages.Controls.Add(this.panelLikedPagesDetails);
            this.tabPageLikedPages.Controls.Add(this.labelNoLikedPages);
            this.tabPageLikedPages.Controls.Add(this.listBoxLikedPages);
            this.tabPageLikedPages.Location = new System.Drawing.Point(4, 22);
            this.tabPageLikedPages.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPageLikedPages.Name = "tabPageLikedPages";
            this.tabPageLikedPages.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPageLikedPages.Size = new System.Drawing.Size(706, 647);
            this.tabPageLikedPages.TabIndex = 4;
            this.tabPageLikedPages.Text = "Liked Pages";
            this.tabPageLikedPages.UseVisualStyleBackColor = true;
            // 
            // panelLikedPagesDetails
            // 
            this.panelLikedPagesDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLikedPagesDetails.Controls.Add(descriptionLabel1);
            this.panelLikedPagesDetails.Controls.Add(this.descriptionTextBox1);
            this.panelLikedPagesDetails.Controls.Add(this.imageNormalPictureBox1);
            this.panelLikedPagesDetails.Controls.Add(likesCountLabel);
            this.panelLikedPagesDetails.Controls.Add(this.likesCountTextBox);
            this.panelLikedPagesDetails.Controls.Add(phoneLabel);
            this.panelLikedPagesDetails.Controls.Add(this.phoneTextBox);
            this.panelLikedPagesDetails.Controls.Add(talkingAboutCountLabel);
            this.panelLikedPagesDetails.Controls.Add(this.talkingAboutCountTextBox);
            this.panelLikedPagesDetails.Controls.Add(websiteLabel);
            this.panelLikedPagesDetails.Controls.Add(this.websiteTextBox);
            this.panelLikedPagesDetails.Location = new System.Drawing.Point(208, 3);
            this.panelLikedPagesDetails.Name = "panelLikedPagesDetails";
            this.panelLikedPagesDetails.Size = new System.Drawing.Size(443, 444);
            this.panelLikedPagesDetails.TabIndex = 3;
            // 
            // descriptionTextBox1
            // 
            this.descriptionTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Description", true));
            this.descriptionTextBox1.Location = new System.Drawing.Point(132, 278);
            this.descriptionTextBox1.Name = "descriptionTextBox1";
            this.descriptionTextBox1.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextBox1.TabIndex = 1;
            // 
            // pageBindingSource
            // 
            this.pageBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Page);
            // 
            // imageNormalPictureBox1
            // 
            this.imageNormalPictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.pageBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox1.Location = new System.Drawing.Point(21, 6);
            this.imageNormalPictureBox1.Name = "imageNormalPictureBox1";
            this.imageNormalPictureBox1.Size = new System.Drawing.Size(325, 266);
            this.imageNormalPictureBox1.TabIndex = 3;
            this.imageNormalPictureBox1.TabStop = false;
            // 
            // likesCountTextBox
            // 
            this.likesCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "LikesCount", true));
            this.likesCountTextBox.Location = new System.Drawing.Point(132, 304);
            this.likesCountTextBox.Name = "likesCountTextBox";
            this.likesCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.likesCountTextBox.TabIndex = 5;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(132, 330);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 7;
            // 
            // talkingAboutCountTextBox
            // 
            this.talkingAboutCountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "TalkingAboutCount", true));
            this.talkingAboutCountTextBox.Location = new System.Drawing.Point(132, 356);
            this.talkingAboutCountTextBox.Name = "talkingAboutCountTextBox";
            this.talkingAboutCountTextBox.Size = new System.Drawing.Size(100, 20);
            this.talkingAboutCountTextBox.TabIndex = 9;
            // 
            // websiteTextBox
            // 
            this.websiteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pageBindingSource, "Website", true));
            this.websiteTextBox.Location = new System.Drawing.Point(132, 382);
            this.websiteTextBox.Name = "websiteTextBox";
            this.websiteTextBox.Size = new System.Drawing.Size(100, 20);
            this.websiteTextBox.TabIndex = 11;
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
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxLikedPages.DataSource = this.pageBindingSource;
            this.listBoxLikedPages.DisplayMember = "Name";
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.Location = new System.Drawing.Point(6, 3);
            this.listBoxLikedPages.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(197, 446);
            this.listBoxLikedPages.TabIndex = 0;
            this.listBoxLikedPages.Visible = false;
            // 
            // tabPageEvents
            // 
            this.tabPageEvents.AutoScroll = true;
            this.tabPageEvents.Controls.Add(this.panelEventDetails);
            this.tabPageEvents.Controls.Add(this.tabControlEvents);
            this.tabPageEvents.Location = new System.Drawing.Point(4, 22);
            this.tabPageEvents.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPageEvents.Name = "tabPageEvents";
            this.tabPageEvents.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPageEvents.Size = new System.Drawing.Size(706, 647);
            this.tabPageEvents.TabIndex = 5;
            this.tabPageEvents.Text = "Events";
            this.tabPageEvents.UseVisualStyleBackColor = true;
            this.tabPageEvents.Click += new System.EventHandler(this.tabPageEvents_Click);
            // 
            // panelEventDetails
            // 
            this.panelEventDetails.Controls.Add(descriptionLabel);
            this.panelEventDetails.Controls.Add(this.descriptionTextBox);
            this.panelEventDetails.Controls.Add(endTimeLabel);
            this.panelEventDetails.Controls.Add(this.endTimeDateTimePicker);
            this.panelEventDetails.Controls.Add(idLabel);
            this.panelEventDetails.Controls.Add(this.idTextBox);
            this.panelEventDetails.Controls.Add(imageNormalLabel);
            this.panelEventDetails.Controls.Add(this.imageNormalPictureBox);
            this.panelEventDetails.Controls.Add(linkToFacebookLabel);
            this.panelEventDetails.Controls.Add(this.linkToFacebookLabel1);
            this.panelEventDetails.Controls.Add(locationLabel);
            this.panelEventDetails.Controls.Add(this.locationTextBox);
            this.panelEventDetails.Controls.Add(startTimeLabel);
            this.panelEventDetails.Controls.Add(this.startTimeDateTimePicker);
            this.panelEventDetails.Location = new System.Drawing.Point(297, 14);
            this.panelEventDetails.Name = "panelEventDetails";
            this.panelEventDetails.Size = new System.Drawing.Size(344, 415);
            this.panelEventDetails.TabIndex = 5;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(110, 15);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 20);
            this.descriptionTextBox.TabIndex = 1;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Event);
            // 
            // endTimeDateTimePicker
            // 
            this.endTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "EndTime", true));
            this.endTimeDateTimePicker.Location = new System.Drawing.Point(110, 41);
            this.endTimeDateTimePicker.Name = "endTimeDateTimePicker";
            this.endTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endTimeDateTimePicker.TabIndex = 3;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(110, 67);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 5;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.eventBindingSource, "ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(110, 93);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(200, 50);
            this.imageNormalPictureBox.TabIndex = 7;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // linkToFacebookLabel1
            // 
            this.linkToFacebookLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "LinkToFacebook", true));
            this.linkToFacebookLabel1.Location = new System.Drawing.Point(110, 146);
            this.linkToFacebookLabel1.Name = "linkToFacebookLabel1";
            this.linkToFacebookLabel1.Size = new System.Drawing.Size(200, 23);
            this.linkToFacebookLabel1.TabIndex = 9;
            this.linkToFacebookLabel1.Text = "label1";
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "Location", true));
            this.locationTextBox.Location = new System.Drawing.Point(110, 172);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(200, 20);
            this.locationTextBox.TabIndex = 11;
            // 
            // startTimeDateTimePicker
            // 
            this.startTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "StartTime", true));
            this.startTimeDateTimePicker.Location = new System.Drawing.Point(110, 198);
            this.startTimeDateTimePicker.Name = "startTimeDateTimePicker";
            this.startTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startTimeDateTimePicker.TabIndex = 13;
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
            this.tabControlEvents.Size = new System.Drawing.Size(286, 420);
            this.tabControlEvents.TabIndex = 4;
            // 
            // tabPageEventsEvents
            // 
            this.tabPageEventsEvents.Controls.Add(this.listBoxEvents);
            this.tabPageEventsEvents.Location = new System.Drawing.Point(4, 22);
            this.tabPageEventsEvents.Name = "tabPageEventsEvents";
            this.tabPageEventsEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEventsEvents.Size = new System.Drawing.Size(278, 394);
            this.tabPageEventsEvents.TabIndex = 0;
            this.tabPageEventsEvents.Text = "Events";
            this.tabPageEventsEvents.UseVisualStyleBackColor = true;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxEvents.DataSource = this.eventBindingSource;
            this.listBoxEvents.DisplayMember = "Name";
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(5, 6);
            this.listBoxEvents.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(268, 381);
            this.listBoxEvents.TabIndex = 2;
            // 
            // tabPageEventsCreated
            // 
            this.tabPageEventsCreated.Controls.Add(this.listBoxEventsCreated);
            this.tabPageEventsCreated.Location = new System.Drawing.Point(4, 22);
            this.tabPageEventsCreated.Name = "tabPageEventsCreated";
            this.tabPageEventsCreated.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEventsCreated.Size = new System.Drawing.Size(278, 394);
            this.tabPageEventsCreated.TabIndex = 1;
            this.tabPageEventsCreated.Text = "Created";
            this.tabPageEventsCreated.UseVisualStyleBackColor = true;
            this.tabPageEventsCreated.Click += new System.EventHandler(this.tabPageEventsCreated_Click);
            // 
            // listBoxEventsCreated
            // 
            this.listBoxEventsCreated.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxEventsCreated.DataSource = this.eventBindingSource;
            this.listBoxEventsCreated.DisplayMember = "Name";
            this.listBoxEventsCreated.FormattingEnabled = true;
            this.listBoxEventsCreated.Location = new System.Drawing.Point(3, 3);
            this.listBoxEventsCreated.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBoxEventsCreated.Name = "listBoxEventsCreated";
            this.listBoxEventsCreated.Size = new System.Drawing.Size(270, 381);
            this.listBoxEventsCreated.TabIndex = 4;
            // 
            // tabPageEventsDeclined
            // 
            this.tabPageEventsDeclined.Controls.Add(this.listBoxEventsDeclinde);
            this.tabPageEventsDeclined.Location = new System.Drawing.Point(4, 22);
            this.tabPageEventsDeclined.Name = "tabPageEventsDeclined";
            this.tabPageEventsDeclined.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEventsDeclined.Size = new System.Drawing.Size(278, 394);
            this.tabPageEventsDeclined.TabIndex = 2;
            this.tabPageEventsDeclined.Text = "Declined";
            this.tabPageEventsDeclined.UseVisualStyleBackColor = true;
            this.tabPageEventsDeclined.Click += new System.EventHandler(this.tabPageEventsDeclined_Click);
            // 
            // listBoxEventsDeclinde
            // 
            this.listBoxEventsDeclinde.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxEventsDeclinde.DataSource = this.eventBindingSource;
            this.listBoxEventsDeclinde.DisplayMember = "Name";
            this.listBoxEventsDeclinde.FormattingEnabled = true;
            this.listBoxEventsDeclinde.Location = new System.Drawing.Point(3, 3);
            this.listBoxEventsDeclinde.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBoxEventsDeclinde.Name = "listBoxEventsDeclinde";
            this.listBoxEventsDeclinde.Size = new System.Drawing.Size(270, 381);
            this.listBoxEventsDeclinde.TabIndex = 6;
            // 
            // tabPageEventsMaybe
            // 
            this.tabPageEventsMaybe.Controls.Add(this.listBoxEventsMaybe);
            this.tabPageEventsMaybe.Location = new System.Drawing.Point(4, 22);
            this.tabPageEventsMaybe.Name = "tabPageEventsMaybe";
            this.tabPageEventsMaybe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEventsMaybe.Size = new System.Drawing.Size(278, 394);
            this.tabPageEventsMaybe.TabIndex = 3;
            this.tabPageEventsMaybe.Text = "Maybe";
            this.tabPageEventsMaybe.UseVisualStyleBackColor = true;
            this.tabPageEventsMaybe.Click += new System.EventHandler(this.tabPageEventsMaybe_Click);
            // 
            // listBoxEventsMaybe
            // 
            this.listBoxEventsMaybe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxEventsMaybe.DataSource = this.eventBindingSource;
            this.listBoxEventsMaybe.DisplayMember = "Name";
            this.listBoxEventsMaybe.FormattingEnabled = true;
            this.listBoxEventsMaybe.Location = new System.Drawing.Point(3, 3);
            this.listBoxEventsMaybe.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBoxEventsMaybe.Name = "listBoxEventsMaybe";
            this.listBoxEventsMaybe.Size = new System.Drawing.Size(270, 381);
            this.listBoxEventsMaybe.TabIndex = 6;
            // 
            // tabPageEventsNotYetReplied
            // 
            this.tabPageEventsNotYetReplied.Controls.Add(this.listBoxEventsNotYetReplied);
            this.tabPageEventsNotYetReplied.Location = new System.Drawing.Point(4, 22);
            this.tabPageEventsNotYetReplied.Name = "tabPageEventsNotYetReplied";
            this.tabPageEventsNotYetReplied.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEventsNotYetReplied.Size = new System.Drawing.Size(278, 394);
            this.tabPageEventsNotYetReplied.TabIndex = 4;
            this.tabPageEventsNotYetReplied.Text = "Not Yet Replied";
            this.tabPageEventsNotYetReplied.UseVisualStyleBackColor = true;
            this.tabPageEventsNotYetReplied.Click += new System.EventHandler(this.tabPageEventsNotYetReplied_Click);
            // 
            // listBoxEventsNotYetReplied
            // 
            this.listBoxEventsNotYetReplied.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxEventsNotYetReplied.DataSource = this.eventBindingSource;
            this.listBoxEventsNotYetReplied.DisplayMember = "Name";
            this.listBoxEventsNotYetReplied.FormattingEnabled = true;
            this.listBoxEventsNotYetReplied.Location = new System.Drawing.Point(3, 3);
            this.listBoxEventsNotYetReplied.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBoxEventsNotYetReplied.Name = "listBoxEventsNotYetReplied";
            this.listBoxEventsNotYetReplied.Size = new System.Drawing.Size(270, 381);
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
            this.tabPageUserInfo.Size = new System.Drawing.Size(706, 647);
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
            this.tabPageGames.Size = new System.Drawing.Size(706, 647);
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
            this.tabPageHoroscope.Size = new System.Drawing.Size(706, 647);
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
            // photosBindingSource
            // 
            this.photosBindingSource.DataMember = "Photos";
            this.photosBindingSource.DataSource = this.albumBindingSource;
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
            "user_hometown",
            "user_location"});
            this.checkedListBoxPermissions.Location = new System.Drawing.Point(8, 68);
            this.checkedListBoxPermissions.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkedListBoxPermissions.Name = "checkedListBoxPermissions";
            this.checkedListBoxPermissions.Size = new System.Drawing.Size(156, 139);
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
            this.checkBoxSelectAllPermissions.Location = new System.Drawing.Point(8, 223);
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
            // commentBindingSource
            // 
            this.commentBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Comment);
            // 
            // FormMain
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(844, 694);
            this.Controls.Add(this.checkBoxRememberUser);
            this.Controls.Add(this.checkBoxSelectAllPermissions);
            this.Controls.Add(this.labelPermissions);
            this.Controls.Add(this.pictureBoxProfilePic);
            this.Controls.Add(this.checkedListBoxPermissions);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.tabControlMain);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(805, 540);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook (Sort of)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageNewsFeed.ResumeLayout(false);
            this.tabPageNewsFeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSourceNewsFeed)).EndInit();
            this.tabPagePosts.ResumeLayout(false);
            this.tabPagePosts.PerformLayout();
            this.tabPageFriends.ResumeLayout(false);
            this.tabPageFriends.PerformLayout();
            this.panelUsersDetails.ResumeLayout(false);
            this.panelUsersDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLargePictureBox)).EndInit();
            this.tabPageAlbums.ResumeLayout(false);
            this.tabPageAlbums.PerformLayout();
            this.panelAlbumDetails.ResumeLayout(false);
            this.panelAlbumDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).EndInit();
            this.tabPageLikedPages.ResumeLayout(false);
            this.tabPageLikedPages.PerformLayout();
            this.panelLikedPagesDetails.ResumeLayout(false);
            this.panelLikedPagesDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox1)).EndInit();
            this.tabPageEvents.ResumeLayout(false);
            this.panelEventDetails.ResumeLayout(false);
            this.panelEventDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.tabControlEvents.ResumeLayout(false);
            this.tabPageEventsEvents.ResumeLayout(false);
            this.tabPageEventsCreated.ResumeLayout(false);
            this.tabPageEventsDeclined.ResumeLayout(false);
            this.tabPageEventsMaybe.ResumeLayout(false);
            this.tabPageEventsNotYetReplied.ResumeLayout(false);
            this.tabPageUserInfo.ResumeLayout(false);
            this.tabPageUserInfo.PerformLayout();
            this.tabPageGames.ResumeLayout(false);
            this.tabPageGames.PerformLayout();
            this.tabPageHoroscope.ResumeLayout(false);
            this.tabPageHoroscope.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentBindingSource)).EndInit();
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
          private TabPage tabPageUserInfo;
          private Label labelEducationText;
          private Label labelHometownText;
          private TabPage tabPageLikedPages;
          private ListBox listBoxLikedPages;
          private TabPage tabPageEvents;
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
          private ListBox listBoxNewsFeedOld;
          private TabControl tabControlEvents;
          private TabPage tabPageEventsEvents;
          private TabPage tabPageEventsCreated;
          private ListBox listBoxEventsCreated;
          private TabPage tabPageEventsDeclined;
          private ListBox listBoxEventsDeclinde;
          private TabPage tabPageEventsMaybe;
          private ListBox listBoxEventsMaybe;
          private TabPage tabPageEventsNotYetReplied;
          private ListBox listBoxEventsNotYetReplied;
          private Label labelNoLikedPages;
          private Label labelNoFriends;
          private Label labelNoItemsAlbums;
          private Button buttonGetHoroscope;
          private Label labelGamesTabText;
          private CheckBox checkBoxRememberUser;
          private ListBox listBoxHoroscopeDay;
          private Label labelFriendsHoroscope;
          private ListBox listBoxFriendsHoroscope;
        private BindingSource eventBindingSource;
        private Panel panelEventDetails;
        private TextBox descriptionTextBox;
        private DateTimePicker endTimeDateTimePicker;
        private TextBox idTextBox;
        private PictureBox imageNormalPictureBox;
        private Label linkToFacebookLabel1;
        private TextBox locationTextBox;
        private DateTimePicker startTimeDateTimePicker;
        private Panel panelLikedPagesDetails;
        private TextBox descriptionTextBox1;
        private BindingSource pageBindingSource;
        private PictureBox imageNormalPictureBox1;
        private TextBox likesCountTextBox;
        private TextBox phoneTextBox;
        private TextBox talkingAboutCountTextBox;
        private TextBox websiteTextBox;
        private Panel panelAlbumDetails;
        private BindingSource albumBindingSource;
        private BindingSource userBindingSource;
        private BindingSource photosBindingSource;
        private Panel panelUsersDetails;
        private Label aboutLabel1;
        private Label birthdayLabel1;
        private Label emailLabel1;
        private PictureBox imageLargePictureBox;
        private Label nameLabel1;
        private Label religionLabel1;
        private Label createdTimeLabel1;
        private TextBox descriptionTextBox2;
        private PictureBox imageAlbumPictureBox;
        private TextBox locationTextBox1;
        private BindingSource commentBindingSource;
        private BindingSource postBindingSourceNewsFeed;
    }
}

