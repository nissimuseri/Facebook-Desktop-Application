namespace AppUI
{
    internal partial class FormMainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.Label nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainPage));
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.labelFirstname = new System.Windows.Forms.Label();
            this.labelLastname = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.labelPostStatus = new System.Windows.Forms.Label();
            this.listBoxRecentPosts = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.labelPages = new System.Windows.Forms.Label();
            this.labelFriends = new System.Windows.Forms.Label();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.pictureBoxFriends = new System.Windows.Forms.PictureBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.buttonPost = new System.Windows.Forms.Button();
            this.UploadNewPhotoDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ButtonUploadPhoto = new System.Windows.Forms.Button();
            this.labelFriendsCounter = new System.Windows.Forms.Label();
            this.bottonLogOut = new System.Windows.Forms.Button();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.labelRecentPics = new System.Windows.Forms.Label();
            this.buttonFilterPosts = new System.Windows.Forms.Button();
            this.buttonUserLocationsOnMap = new System.Windows.Forms.Button();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.labelLastPosts = new System.Windows.Forms.Label();
            this.labelAlbums = new System.Windows.Forms.Label();
            this.buttonLoadPosts = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(230, 457);
            nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(145, 17);
            nameLabel.TabIndex = 78;
            nameLabel.Text = "Change Album Name:";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(34, 54);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(115, 128);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            // 
            // labelFirstname
            // 
            this.labelFirstname.AutoSize = true;
            this.labelFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFirstname.Location = new System.Drawing.Point(338, 9);
            this.labelFirstname.Name = "labelFirstname";
            this.labelFirstname.Size = new System.Drawing.Size(70, 16);
            this.labelFirstname.TabIndex = 1;
            this.labelFirstname.Text = "Firstname:";
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLastname.Location = new System.Drawing.Point(338, 29);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(70, 16);
            this.labelLastname.TabIndex = 2;
            this.labelLastname.Text = "Lastname:";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelGender.Location = new System.Drawing.Point(338, 49);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(56, 16);
            this.labelGender.TabIndex = 3;
            this.labelGender.Text = "Gender:";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelBirthday.Location = new System.Drawing.Point(338, 69);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(60, 16);
            this.labelBirthday.TabIndex = 4;
            this.labelBirthday.Text = "Birthday:";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStatus.Location = new System.Drawing.Point(640, 15);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(271, 20);
            this.textBoxStatus.TabIndex = 1;
            // 
            // labelPostStatus
            // 
            this.labelPostStatus.AutoSize = true;
            this.labelPostStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPostStatus.Location = new System.Drawing.Point(556, 16);
            this.labelPostStatus.Name = "labelPostStatus";
            this.labelPostStatus.Size = new System.Drawing.Size(78, 16);
            this.labelPostStatus.TabIndex = 47;
            this.labelPostStatus.Text = "Post Status:";
            // 
            // listBoxRecentPosts
            // 
            this.listBoxRecentPosts.FormattingEnabled = true;
            this.listBoxRecentPosts.Location = new System.Drawing.Point(492, 270);
            this.listBoxRecentPosts.Name = "listBoxRecentPosts";
            this.listBoxRecentPosts.Size = new System.Drawing.Size(486, 225);
            this.listBoxRecentPosts.TabIndex = 52;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(128, 211);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(14, 316);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(92, 99);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 55;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(128, 316);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(92, 99);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 56;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(14, 421);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(92, 99);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 57;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(128, 421);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(92, 99);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 58;
            this.pictureBox6.TabStop = false;
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPages.Location = new System.Drawing.Point(556, 63);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(56, 16);
            this.labelPages.TabIndex = 59;
            this.labelPages.Text = "Friends:";
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriends.Location = new System.Drawing.Point(556, 206);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(124, 16);
            this.labelFriends.TabIndex = 61;
            this.labelFriends.Text = "Friends In The App:";
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(559, 82);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(292, 121);
            this.listBoxFriends.TabIndex = 60;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // pictureBoxFriends
            // 
            this.pictureBoxFriends.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFriends.BackgroundImage")));
            this.pictureBoxFriends.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFriends.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFriends.InitialImage")));
            this.pictureBoxFriends.Location = new System.Drawing.Point(857, 82);
            this.pictureBoxFriends.Name = "pictureBoxFriends";
            this.pictureBoxFriends.Size = new System.Drawing.Size(122, 121);
            this.pictureBoxFriends.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriends.TabIndex = 62;
            this.pictureBoxFriends.TabStop = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelEmail.Location = new System.Drawing.Point(338, 89);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(45, 16);
            this.labelEmail.TabIndex = 63;
            this.labelEmail.Text = "Email:";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCity.Location = new System.Drawing.Point(338, 108);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(33, 16);
            this.labelCity.TabIndex = 64;
            this.labelCity.Text = "City:";
            // 
            // buttonPost
            // 
            this.buttonPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPost.Location = new System.Drawing.Point(916, 13);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(75, 23);
            this.buttonPost.TabIndex = 10;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = true;
            this.buttonPost.Click += new System.EventHandler(this.buttonSetStatus_Click);
            // 
            // UploadNewPhotoDialog
            // 
            this.UploadNewPhotoDialog.RootFolder = System.Environment.SpecialFolder.MyPictures;
            // 
            // ButtonUploadPhoto
            // 
            this.ButtonUploadPhoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonUploadPhoto.Location = new System.Drawing.Point(873, 41);
            this.ButtonUploadPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonUploadPhoto.Name = "ButtonUploadPhoto";
            this.ButtonUploadPhoto.Size = new System.Drawing.Size(118, 26);
            this.ButtonUploadPhoto.TabIndex = 20;
            this.ButtonUploadPhoto.Text = "Upload New Photo";
            this.ButtonUploadPhoto.UseVisualStyleBackColor = true;
            this.ButtonUploadPhoto.Click += new System.EventHandler(this.uploadNewPhotoButton_Click);
            // 
            // labelFriendsCounter
            // 
            this.labelFriendsCounter.AutoSize = true;
            this.labelFriendsCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFriendsCounter.Location = new System.Drawing.Point(672, 206);
            this.labelFriendsCounter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFriendsCounter.Name = "labelFriendsCounter";
            this.labelFriendsCounter.Size = new System.Drawing.Size(0, 16);
            this.labelFriendsCounter.TabIndex = 66;
            // 
            // bottonLogOut
            // 
            this.bottonLogOut.BackColor = System.Drawing.Color.Red;
            this.bottonLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bottonLogOut.Font = new System.Drawing.Font("David", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottonLogOut.ForeColor = System.Drawing.Color.White;
            this.bottonLogOut.Location = new System.Drawing.Point(868, 500);
            this.bottonLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.bottonLogOut.Name = "bottonLogOut";
            this.bottonLogOut.Size = new System.Drawing.Size(120, 41);
            this.bottonLogOut.TabIndex = 50;
            this.bottonLogOut.Text = "Log Out";
            this.bottonLogOut.UseVisualStyleBackColor = false;
            this.bottonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxCover.BackgroundImage")));
            this.pictureBoxCover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxCover.Location = new System.Drawing.Point(12, 9);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(310, 135);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCover.TabIndex = 70;
            this.pictureBoxCover.TabStop = false;
            // 
            // labelRecentPics
            // 
            this.labelRecentPics.AutoSize = true;
            this.labelRecentPics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelRecentPics.Location = new System.Drawing.Point(10, 192);
            this.labelRecentPics.Name = "labelRecentPics";
            this.labelRecentPics.Size = new System.Drawing.Size(157, 16);
            this.labelRecentPics.TabIndex = 71;
            this.labelRecentPics.Text = "Recent Tagged Pictures:";
            // 
            // buttonFilterPosts
            // 
            this.buttonFilterPosts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFilterPosts.Location = new System.Drawing.Point(341, 150);
            this.buttonFilterPosts.Name = "buttonFilterPosts";
            this.buttonFilterPosts.Size = new System.Drawing.Size(201, 32);
            this.buttonFilterPosts.TabIndex = 30;
            this.buttonFilterPosts.Text = "Filter Friends Posts";
            this.buttonFilterPosts.UseVisualStyleBackColor = true;
            this.buttonFilterPosts.Click += new System.EventHandler(this.buttonFilterPosts_Click);
            // 
            // buttonUserLocationsOnMap
            // 
            this.buttonUserLocationsOnMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUserLocationsOnMap.Location = new System.Drawing.Point(341, 197);
            this.buttonUserLocationsOnMap.Name = "buttonUserLocationsOnMap";
            this.buttonUserLocationsOnMap.Size = new System.Drawing.Size(201, 32);
            this.buttonUserLocationsOnMap.TabIndex = 40;
            this.buttonUserLocationsOnMap.Text = "User Locations On Map";
            this.buttonUserLocationsOnMap.UseVisualStyleBackColor = true;
            this.buttonUserLocationsOnMap.Click += new System.EventHandler(this.buttonUserLocationsOnMap_Click);
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nameTextBox.Location = new System.Drawing.Point(233, 476);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(253, 20);
            this.nameTextBox.TabIndex = 79;
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.DataSource = this.albumBindingSource;
            this.listBoxAlbums.DisplayMember = "Name";
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.Location = new System.Drawing.Point(231, 270);
            this.listBoxAlbums.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxAlbums.Size = new System.Drawing.Size(255, 173);
            this.listBoxAlbums.TabIndex = 80;
            // 
            // labelLastPosts
            // 
            this.labelLastPosts.AutoSize = true;
            this.labelLastPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastPosts.Location = new System.Drawing.Point(490, 253);
            this.labelLastPosts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastPosts.Name = "labelLastPosts";
            this.labelLastPosts.Size = new System.Drawing.Size(96, 17);
            this.labelLastPosts.TabIndex = 81;
            this.labelLastPosts.Text = "Recent Posts:";
            // 
            // labelAlbums
            // 
            this.labelAlbums.AutoSize = true;
            this.labelAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlbums.Location = new System.Drawing.Point(230, 253);
            this.labelAlbums.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAlbums.Name = "labelAlbums";
            this.labelAlbums.Size = new System.Drawing.Size(58, 17);
            this.labelAlbums.TabIndex = 82;
            this.labelAlbums.Text = "Albums:";
            // 
            // buttonLoadPosts
            // 
            this.buttonLoadPosts.Location = new System.Drawing.Point(492, 500);
            this.buttonLoadPosts.Name = "buttonLoadPosts";
            this.buttonLoadPosts.Size = new System.Drawing.Size(120, 23);
            this.buttonLoadPosts.TabIndex = 83;
            this.buttonLoadPosts.Text = "Load More Posts";
            this.buttonLoadPosts.UseVisualStyleBackColor = true;
            this.buttonLoadPosts.Click += new System.EventHandler(this.buttonLoadPosts_Click);
            // 
            // FormMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1004, 557);
            this.Controls.Add(this.buttonLoadPosts);
            this.Controls.Add(this.labelAlbums);
            this.Controls.Add(this.labelLastPosts);
            this.Controls.Add(this.listBoxAlbums);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.buttonUserLocationsOnMap);
            this.Controls.Add(this.buttonFilterPosts);
            this.Controls.Add(this.labelRecentPics);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.pictureBoxCover);
            this.Controls.Add(this.bottonLogOut);
            this.Controls.Add(this.labelFriendsCounter);
            this.Controls.Add(this.ButtonUploadPhoto);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.pictureBoxFriends);
            this.Controls.Add(this.labelFriends);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.labelPages);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBoxRecentPosts);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.labelPostStatus);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.labelLastname);
            this.Controls.Add(this.labelFirstname);
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMainPage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labelFirstname;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label labelPostStatus;
        private System.Windows.Forms.ListBox listBoxRecentPosts;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label labelPages;
        private System.Windows.Forms.Label labelFriends;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.PictureBox pictureBoxFriends;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.FolderBrowserDialog UploadNewPhotoDialog;
        private System.Windows.Forms.Button ButtonUploadPhoto;
        private System.Windows.Forms.Label labelFriendsCounter;
        private System.Windows.Forms.Button bottonLogOut;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.Label labelRecentPics;
        private System.Windows.Forms.Button buttonFilterPosts;
        private System.Windows.Forms.Button buttonUserLocationsOnMap;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Label labelLastPosts;
        private System.Windows.Forms.Label labelAlbums;
        private System.Windows.Forms.Button buttonLoadPosts;
    }
}