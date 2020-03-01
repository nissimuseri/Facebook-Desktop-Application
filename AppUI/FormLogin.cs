using System;
using System.Windows.Forms;
using AppLogic;

namespace AppUI
{
    internal partial class FormLogin : Form
    {
        public ConnectFB ConnectFB { get; set; }

        private AppSettings m_AppSettings = new AppSettings();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            performLogin();
        }

        private void performLogin()
        {
            bool reLogin = false;
            if (ConnectFB == null)
            {
                ConnectFB = ConnectFB.Instance;
                reLogin = true;
            }

            ConnectFB.OpenNewConnection();
            if (checkBoxRememberMe.Checked == true)
            {
                saveSettings();
            }

            this.DialogResult = DialogResult.OK;
            this.Dispose();
            if (reLogin == true)
            {
                FormMainPage mainPage = new FormMainPage(ConnectFB.LoggedInUser);
                StartApp.MainPage = mainPage;
                mainPage.ShowDialog();
            }
        }

        private void saveSettings()
        {
            try
            {
                m_AppSettings.RememberMe = checkBoxRememberMe.Checked;
                m_AppSettings.LastAccessToken = ConnectFB.ResultLogin.AccessToken;
                m_AppSettings.SaveToFile();
            }
            catch
            {
                MessageBox.Show("An error occured while saving settings to file");
            }
        }
    }
}
