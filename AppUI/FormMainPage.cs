using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using AppLogic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace AppUI
{
    internal partial class FormMainPage : Form
    {
        private User m_ConnectedUser;

        private FacebookDataFacade m_UserData;

        private FormFilterPosts m_FilterPosts;

        private FormLocationsMap m_LocationsMap;

        private AppSettings m_AppSettings;

        public FormMainPage(User i_ConnectedUser)
        {
            InitializeComponent();
            m_ConnectedUser = i_ConnectedUser;
            m_UserData = new FacebookDataFacade(m_ConnectedUser);
            m_FilterPosts = new FormFilterPosts(m_ConnectedUser);
            m_LocationsMap = new FormLocationsMap(m_ConnectedUser);
            m_AppSettings = new AppSettings();
        }

        protected override void OnShown(EventArgs e)
        {
            this.Text = "Loggedin as: " + m_ConnectedUser.FirstName + m_ConnectedUser.LastName;
            new Thread(loadBasicInfo).Start();
            new Thread(loadCoverPhoto).Start();
            new Thread(loadRecentPosts).Start();
            new Thread(loadFriends).Start();
            new Thread(loadPictures).Start();
            new Thread(loadAlbums).Start();
            this.Cursor = Cursors.Default;
        }

        private void loadBasicInfo()
        {
            try
            {
                pictureBoxProfile.Invoke(new Action(() => pictureBoxProfile.LoadAsync(m_ConnectedUser.PictureLargeURL)));
                labelFirstname.Invoke(new Action(() => labelFirstname.Text = "Firstname: " + m_ConnectedUser.FirstName));
                labelLastname.Invoke(new Action(() => labelLastname.Text = "Lastname: " + m_ConnectedUser.LastName));
                labelGender.Invoke(new Action(() => labelGender.Text = "Gender: " + m_ConnectedUser.Gender));
                labelBirthday.Invoke(new Action(() =>
                        labelBirthday.Text = "Birthday: " + DateTime.ParseExact(
                        m_ConnectedUser.Birthday,
                        "MM/dd/yyyy",
                        CultureInfo.InvariantCulture)
                        .ToString("dd'/'MM'/'yyyy")));
                labelEmail.Invoke(new Action(() => labelEmail.Text = "Email: " + m_ConnectedUser.Email));
                labelCity.Invoke(new Action(() => labelCity.Text = "City: " + m_ConnectedUser.Location.Name));
                labelFriendsCounter.Invoke(new Action(() => labelFriendsCounter.Text = m_ConnectedUser.Friends.Count + " Friends are logged to the App."));
            }
            catch
            {
                MessageBox.Show("An error occured while fetching user's basic information.");
            }
        }

        private void loadFriends()
        {
            try
            {
                listBoxFriends.Invoke(new Action(() =>
                {
                    listBoxFriends.Items.Clear();
                    listBoxFriends.DisplayMember = "Name";
                }));
                
                FacebookObjectCollection<User> friendsList = m_ConnectedUser.Friends;
                foreach (User friend in friendsList)
                {
                    listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add(friend)));
                }

                if (friendsList.Count == 0)
                {
                    MessageBox.Show("No Friends to retrieve :(");
                }
            }
            catch
            {
                MessageBox.Show("An error occured while fetching user's friends.");
            }
        }
        
        private void loadAlbums()
        {
            listBoxAlbums.Invoke(new Action(() => albumBindingSource.DataSource = m_ConnectedUser.Albums));
        }

        private void loadRecentPosts()
        {
            try
            {
                foreach (Post post in m_UserData.GetAllUserPosts())
                {
                    listBoxRecentPosts.Invoke(new Action(() => 
                        listBoxRecentPosts.Items.Add(string.Format(
                        "{0} | {1} | {2}",
                        post.UpdateTime.ToString(),
                        post.Type,
                        post.Message))));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                buttonLoadPosts.Enabled = false;
            }
        }

        private void loadPictures()
        {
            try
            {
                pictureBox1.Invoke(new Action(() => pictureBox1.LoadAsync(m_ConnectedUser.PhotosTaggedIn[0].PictureNormalURL)));
                pictureBox2.Invoke(new Action(() => pictureBox2.LoadAsync(m_ConnectedUser.PhotosTaggedIn[1].PictureNormalURL)));
                pictureBox3.Invoke(new Action(() => pictureBox3.LoadAsync(m_ConnectedUser.PhotosTaggedIn[2].PictureNormalURL)));
                pictureBox4.Invoke(new Action(() => pictureBox4.LoadAsync(m_ConnectedUser.PhotosTaggedIn[3].PictureNormalURL)));
                pictureBox5.Invoke(new Action(() => pictureBox5.LoadAsync(m_ConnectedUser.PhotosTaggedIn[4].PictureNormalURL)));
                pictureBox6.Invoke(new Action(() => pictureBox6.LoadAsync(m_ConnectedUser.PhotosTaggedIn[5].PictureNormalURL)));
            }
            catch
            {
                MessageBox.Show("An error occured while fetching user's photos.");
            }
        }

        private void buttonSetStatus_Click(object sender, EventArgs e)
        {
            try
            {
                Status postedStatus = m_ConnectedUser.PostStatus(textBoxStatus.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch
            {
                MessageBox.Show("Posting status isn't available due to Facebook conditions.");
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFriends.SelectedItems.Count == 1)
            {
                User selectedUser = listBoxFriends.SelectedItem as User;
                pictureBoxFriends.LoadAsync(selectedUser.PictureLargeURL);
            }
        }

        private void uploadNewPhotoButton_Click(object sender, EventArgs e)
        {
            try
            {
                Post newPhotoToUpload = m_ConnectedUser.PostPhoto(UploadNewPhotoDialog.SelectedPath);
                MessageBox.Show("Photo Posted!");
            }
            catch
            {
                MessageBox.Show("Uploading photo isn't available due to Facebook conditions.");
            }
        }

        private void buttonFilterPosts_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            m_FilterPosts.ShowDialog();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            try
            {
                FacebookService.Logout(null);
            }
            catch
            {
                MessageBox.Show("Error, unable to logout.");
                Environment.Exit(0);
            }
            finally
            {
                this.Hide();
                m_AppSettings.RestoreDefault();
                m_AppSettings.SaveToFile();
                FormLogin loginScreen = new FormLogin();
                loginScreen.ShowDialog();
            }
        }

        private void buttonUserLocationsOnMap_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            m_LocationsMap.ShowDialog();
        }

        private void loadCoverPhoto()
        {
            string coverPhotoURL = string.Empty;

            try
            {
                foreach (Album album in m_ConnectedUser.Albums)
                {
                    string name = album.Name.ToLower();
                    if (name == "cover photos")
                    {
                        coverPhotoURL = album.Photos[0].PictureNormalURL;
                    }
                }
            }
            catch (Exception)
            {
                coverPhotoURL = string.Empty;
            }

            if (coverPhotoURL != string.Empty)
            {
                pictureBoxCover.Invoke(new Action(() => pictureBoxCover.LoadAsync(coverPhotoURL)));
            }
        }

        private void buttonLoadPosts_Click(object sender, EventArgs e)
        {
            loadRecentPosts();
        }
    }
}
