using System;
using AppLogic;

namespace AppUI
{
    internal class StartApp
    {
        public static FormMainPage MainPage { get; set; }

        private AppSettings m_AppSettings = new AppSettings();

        private FormLogin m_FormLogin = new FormLogin();

        private ConnectFB m_ConnectFB = ConnectFB.Instance;

        public void StartRun()
        {
            m_AppSettings.LoadFromFile();
            if (m_AppSettings.RememberMe == true)
            {
                try
                {
                    m_ConnectFB.OpenExistingConnection(m_AppSettings.LastAccessToken);
                }
                catch (Exception)
                {
                    m_FormLogin.ConnectFB = m_ConnectFB;
                    m_FormLogin.ShowDialog();
                }
            }
            else
            {
                m_FormLogin.ConnectFB = m_ConnectFB;
                m_FormLogin.ShowDialog();
            }

            if (m_ConnectFB.LoggedInUser != null)
            {
                MainPage = new FormMainPage(m_ConnectFB.LoggedInUser);
                MainPage.ShowDialog();
            }
        }
    }
}
