namespace AppUI
{
    internal partial class FormFilterPosts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFilterPosts));
            this.textBoxString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFilterPosts = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.listBoxStatuses = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxAbout = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxString
            // 
            this.textBoxString.Location = new System.Drawing.Point(16, 38);
            this.textBoxString.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxString.Name = "textBoxString";
            this.textBoxString.Size = new System.Drawing.Size(565, 22);
            this.textBoxString.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please enter the string you wish to search:";
            // 
            // buttonFilterPosts
            // 
            this.buttonFilterPosts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFilterPosts.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonFilterPosts.Location = new System.Drawing.Point(591, 31);
            this.buttonFilterPosts.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFilterPosts.Name = "buttonFilterPosts";
            this.buttonFilterPosts.Size = new System.Drawing.Size(123, 38);
            this.buttonFilterPosts.TabIndex = 10;
            this.buttonFilterPosts.Text = "Filter";
            this.buttonFilterPosts.UseVisualStyleBackColor = true;
            this.buttonFilterPosts.Click += new System.EventHandler(this.buttonFilterPosts_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonBack.ForeColor = System.Drawing.Color.RoyalBlue;
            this.buttonBack.Location = new System.Drawing.Point(591, 638);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(123, 38);
            this.buttonBack.TabIndex = 20;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // listBoxStatuses
            // 
            this.listBoxStatuses.FormattingEnabled = true;
            this.listBoxStatuses.ItemHeight = 16;
            this.listBoxStatuses.Location = new System.Drawing.Point(16, 70);
            this.listBoxStatuses.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxStatuses.Name = "listBoxStatuses";
            this.listBoxStatuses.Size = new System.Drawing.Size(696, 548);
            this.listBoxStatuses.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(392, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "*Search is not case sensitive";
            // 
            // pictureBoxAbout
            // 
            this.pictureBoxAbout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxAbout.BackgroundImage")));
            this.pictureBoxAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAbout.Location = new System.Drawing.Point(16, 625);
            this.pictureBoxAbout.Name = "pictureBoxAbout";
            this.pictureBoxAbout.Size = new System.Drawing.Size(73, 58);
            this.pictureBoxAbout.TabIndex = 33;
            this.pictureBoxAbout.TabStop = false;
            this.pictureBoxAbout.Click += new System.EventHandler(this.PictureBoxAbout_Click);
            // 
            // FormFilterPosts
            // 
            this.AcceptButton = this.buttonFilterPosts;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.CancelButton = this.buttonBack;
            this.ClientSize = new System.Drawing.Size(729, 690);
            this.Controls.Add(this.pictureBoxAbout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxStatuses);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonFilterPosts);
            this.Controls.Add(this.textBoxString);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormFilterPosts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search friends posts";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFilterPosts;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ListBox listBoxStatuses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxAbout;
    }
}