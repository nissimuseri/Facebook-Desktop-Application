using System;
using System.Collections.Generic;
using System.Windows.Forms;
using AppLogic;
using FacebookWrapper.ObjectModel;

namespace AppUI
{
    internal partial class FormFilterPosts : Form
    {
        private FacebookDataFacade m_UserData;

        public FormFilterPosts(User i_User)
        {
            InitializeComponent();
            m_UserData = new FacebookDataFacade(i_User);
        }

        protected override void OnShown(EventArgs e)
        {
            textBoxString.Clear();
            listBoxStatuses.Items.Clear();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            StartApp.MainPage.Visible = true;
        }

        private void buttonFilterPosts_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxString.Text) == true)
            {
                MessageBox.Show("Can't search empty string!");
            }
            else
            {
                this.Cursor = Cursors.WaitCursor;
                List<Tuple<User, Status>> allRelevantStatuses = m_UserData.SearchInFriendsStatuses(textBoxString.Text);
                fillRelevantStatuses(allRelevantStatuses);
                this.Cursor = Cursors.Default;
            }
        }

        private void fillRelevantStatuses(List<Tuple<User, Status>> i_RelevantStatuses)
        {
            listBoxStatuses.Items.Clear();
            if (i_RelevantStatuses.Count > 0)
            {
                foreach (Tuple<User, Status> userAndStatus in i_RelevantStatuses)
                {
                    listBoxStatuses.Items.Add(string.Format(
                        "{0} | {1} | {2}",
                        userAndStatus.Item2.CreatedTime.ToString(),
                        userAndStatus.Item1.Name,
                        userAndStatus.Item2.Message));
                }
            }
            else
            {
                listBoxStatuses.Items.Add("Nothing matched your search string.");
            }
        }

        private void PictureBoxAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Welcome to Filter Posts!
With this awesome tool you can search
any string you want in all of your friends walls
and view the results in list ordered by date.");
        }
    }
}
