namespace AppUI
{
    internal partial class FormLocationsMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLocationsMap));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.webBrowserMap = new System.Windows.Forms.WebBrowser();
            this.buttonLoadMap = new System.Windows.Forms.Button();
            this.listBoxLocations = new System.Windows.Forms.ListBox();
            this.labelWelcome1 = new System.Windows.Forms.Label();
            this.labelWelcom2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPosts = new System.Windows.Forms.Label();
            this.labelCheckins = new System.Windows.Forms.Label();
            this.labelPhotos = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBoxAbout = new System.Windows.Forms.PictureBox();
            this.labelSortBy = new System.Windows.Forms.Label();
            this.radioButtonName = new System.Windows.Forms.RadioButton();
            this.radioButtonPosts = new System.Windows.Forms.RadioButton();
            this.radioButtonCheckIns = new System.Windows.Forms.RadioButton();
            this.radioButtonPhotos = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(281, 620);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // webBrowserMap
            // 
            this.webBrowserMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowserMap.Location = new System.Drawing.Point(287, 0);
            this.webBrowserMap.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserMap.Name = "webBrowserMap";
            this.webBrowserMap.Size = new System.Drawing.Size(859, 620);
            this.webBrowserMap.TabIndex = 1;
            // 
            // buttonLoadMap
            // 
            this.buttonLoadMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLoadMap.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonLoadMap.Location = new System.Drawing.Point(49, 351);
            this.buttonLoadMap.Name = "buttonLoadMap";
            this.buttonLoadMap.Size = new System.Drawing.Size(164, 47);
            this.buttonLoadMap.TabIndex = 20;
            this.buttonLoadMap.Text = "Load Map";
            this.buttonLoadMap.UseVisualStyleBackColor = true;
            this.buttonLoadMap.Click += new System.EventHandler(this.buttonLoadMap_Click);
            // 
            // listBoxLocations
            // 
            this.listBoxLocations.FormattingEnabled = true;
            this.listBoxLocations.Location = new System.Drawing.Point(7, 94);
            this.listBoxLocations.Name = "listBoxLocations";
            this.listBoxLocations.Size = new System.Drawing.Size(269, 251);
            this.listBoxLocations.TabIndex = 3;
            this.listBoxLocations.SelectedIndexChanged += new System.EventHandler(this.listBoxLocations_SelectedIndexChanged);
            // 
            // labelWelcome1
            // 
            this.labelWelcome1.AutoSize = true;
            this.labelWelcome1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelWelcome1.Location = new System.Drawing.Point(4, 9);
            this.labelWelcome1.Name = "labelWelcome1";
            this.labelWelcome1.Size = new System.Drawing.Size(224, 13);
            this.labelWelcome1.TabIndex = 4;
            this.labelWelcome1.Text = "Please choose location and click \"Load Map\"";
            // 
            // labelWelcom2
            // 
            this.labelWelcom2.AutoSize = true;
            this.labelWelcom2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelWelcom2.Location = new System.Drawing.Point(4, 22);
            this.labelWelcom2.Name = "labelWelcom2";
            this.labelWelcom2.Size = new System.Drawing.Size(93, 13);
            this.labelWelcom2.TabIndex = 5;
            this.labelWelcom2.Text = "to update the map";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(12, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Statistics about this location:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelName.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelName.Location = new System.Drawing.Point(12, 432);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(48, 16);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name:";
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPosts.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelPosts.Location = new System.Drawing.Point(12, 448);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(147, 16);
            this.labelPosts.TabIndex = 8;
            this.labelPosts.Text = "Posts from this location:";
            // 
            // labelCheckins
            // 
            this.labelCheckins.AutoSize = true;
            this.labelCheckins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCheckins.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelCheckins.Location = new System.Drawing.Point(12, 464);
            this.labelCheckins.Name = "labelCheckins";
            this.labelCheckins.Size = new System.Drawing.Size(168, 16);
            this.labelCheckins.TabIndex = 9;
            this.labelCheckins.Text = "Checkins from this location:";
            // 
            // labelPhotos
            // 
            this.labelPhotos.AutoSize = true;
            this.labelPhotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPhotos.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelPhotos.Location = new System.Drawing.Point(12, 480);
            this.labelPhotos.Name = "labelPhotos";
            this.labelPhotos.Size = new System.Drawing.Size(155, 16);
            this.labelPhotos.TabIndex = 10;
            this.labelPhotos.Text = "Photos from this location:";
            // 
            // buttonBack
            // 
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonBack.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonBack.Location = new System.Drawing.Point(100, 562);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(164, 47);
            this.buttonBack.TabIndex = 30;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // pictureBoxAbout
            // 
            this.pictureBoxAbout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxAbout.BackgroundImage")));
            this.pictureBoxAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAbout.Location = new System.Drawing.Point(15, 562);
            this.pictureBoxAbout.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxAbout.Name = "pictureBoxAbout";
            this.pictureBoxAbout.Size = new System.Drawing.Size(55, 47);
            this.pictureBoxAbout.TabIndex = 32;
            this.pictureBoxAbout.TabStop = false;
            this.pictureBoxAbout.Click += new System.EventHandler(this.PictureBoxAbout_Click);
            // 
            // labelSortBy
            // 
            this.labelSortBy.AutoSize = true;
            this.labelSortBy.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelSortBy.Location = new System.Drawing.Point(4, 50);
            this.labelSortBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSortBy.Name = "labelSortBy";
            this.labelSortBy.Size = new System.Drawing.Size(44, 13);
            this.labelSortBy.TabIndex = 34;
            this.labelSortBy.Text = "Sort By:";
            // 
            // radioButtonName
            // 
            this.radioButtonName.AutoSize = true;
            this.radioButtonName.Checked = true;
            this.radioButtonName.Location = new System.Drawing.Point(7, 71);
            this.radioButtonName.Name = "radioButtonName";
            this.radioButtonName.Size = new System.Drawing.Size(53, 17);
            this.radioButtonName.TabIndex = 35;
            this.radioButtonName.TabStop = true;
            this.radioButtonName.Tag = "1";
            this.radioButtonName.Text = "Name";
            this.radioButtonName.UseVisualStyleBackColor = true;
            //this.radioButtonName.CheckedChanged += new System.EventHandler(this.radioButtonName_CheckedChanged);
            // 
            // radioButtonPosts
            // 
            this.radioButtonPosts.AutoSize = true;
            this.radioButtonPosts.Location = new System.Drawing.Point(66, 71);
            this.radioButtonPosts.Name = "radioButtonPosts";
            this.radioButtonPosts.Size = new System.Drawing.Size(51, 17);
            this.radioButtonPosts.TabIndex = 36;
            this.radioButtonPosts.Tag = "2";
            this.radioButtonPosts.Text = "Posts";
            this.radioButtonPosts.UseVisualStyleBackColor = true;
            //this.radioButtonPosts.CheckedChanged += new System.EventHandler(this.radioButtonPosts_CheckedChanged);
            // 
            // radioButtonCheckIns
            // 
            this.radioButtonCheckIns.AutoSize = true;
            this.radioButtonCheckIns.Location = new System.Drawing.Point(123, 71);
            this.radioButtonCheckIns.Name = "radioButtonCheckIns";
            this.radioButtonCheckIns.Size = new System.Drawing.Size(69, 17);
            this.radioButtonCheckIns.TabIndex = 37;
            this.radioButtonCheckIns.Tag = "3";
            this.radioButtonCheckIns.Text = "Checkins";
            this.radioButtonCheckIns.UseVisualStyleBackColor = true;
            //this.radioButtonCheckIns.CheckedChanged += new System.EventHandler(this.radioButtonCheckIns_CheckedChanged);
            // 
            // radioButtonPhotos
            // 
            this.radioButtonPhotos.AutoSize = true;
            this.radioButtonPhotos.Location = new System.Drawing.Point(199, 71);
            this.radioButtonPhotos.Name = "radioButtonPhotos";
            this.radioButtonPhotos.Size = new System.Drawing.Size(58, 17);
            this.radioButtonPhotos.TabIndex = 38;
            this.radioButtonPhotos.Tag = "4";
            this.radioButtonPhotos.Text = "Photos";
            this.radioButtonPhotos.UseVisualStyleBackColor = true;
            //this.radioButtonPhotos.CheckedChanged += new System.EventHandler(this.radioButtonPhotos_CheckedChanged);
            // 
            // FormLocationsMap
            // 
            this.AcceptButton = this.buttonLoadMap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton = this.buttonBack;
            this.ClientSize = new System.Drawing.Size(1146, 620);
            this.Controls.Add(this.radioButtonPhotos);
            this.Controls.Add(this.radioButtonCheckIns);
            this.Controls.Add(this.radioButtonPosts);
            this.Controls.Add(this.radioButtonName);
            this.Controls.Add(this.labelSortBy);
            this.Controls.Add(this.pictureBoxAbout);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelPhotos);
            this.Controls.Add(this.labelCheckins);
            this.Controls.Add(this.labelPosts);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelWelcom2);
            this.Controls.Add(this.labelWelcome1);
            this.Controls.Add(this.listBoxLocations);
            this.Controls.Add(this.buttonLoadMap);
            this.Controls.Add(this.webBrowserMap);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLocationsMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locations On Map";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.WebBrowser webBrowserMap;
        private System.Windows.Forms.Button buttonLoadMap;
        private System.Windows.Forms.ListBox listBoxLocations;
        private System.Windows.Forms.Label labelWelcome1;
        private System.Windows.Forms.Label labelWelcom2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPosts;
        private System.Windows.Forms.Label labelCheckins;
        private System.Windows.Forms.Label labelPhotos;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBoxAbout;
        private System.Windows.Forms.Label labelSortBy;
        private System.Windows.Forms.RadioButton radioButtonName;
        private System.Windows.Forms.RadioButton radioButtonPosts;
        private System.Windows.Forms.RadioButton radioButtonCheckIns;
        private System.Windows.Forms.RadioButton radioButtonPhotos;
    }
}