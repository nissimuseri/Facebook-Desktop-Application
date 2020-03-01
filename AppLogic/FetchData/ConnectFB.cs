using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace AppLogic
{
    public sealed class ConnectFB
    {
        private const string k_AppID = "1333578800181905";
        private const int k_CollectionLimit = 40;
        private static ConnectFB s_Instance = null;
        private static object s_LockObj = new object();

        public static ConnectFB Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (s_LockObj)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new ConnectFB();
                        }
                    }
                }

                return s_Instance;
            }
        }

        public User LoggedInUser { get; set; }

        public LoginResult ResultLogin { get; set; }

        private ConnectFB()
        {
        }

        public void OpenNewConnection()
        {
            FacebookService.s_CollectionLimit = k_CollectionLimit;
            ResultLogin = FacebookService.Login(
                k_AppID,
                "public_profile",
                "email",
                "user_birthday",
                "user_age_range",
                "user_gender",
                "user_link",
                "user_tagged_places",
                "user_friends",
                "user_events",
                "user_likes",
                "user_location",
                "user_photos",
                "user_posts",
                "user_hometown");

            if (!string.IsNullOrEmpty(ResultLogin.AccessToken))
            {
                LoggedInUser = ResultLogin.LoggedInUser;
            }
        }

        public void OpenExistingConnection(string i_AccessToken)
        {
            LoggedInUser = FacebookService.Connect(i_AccessToken).LoggedInUser;
        }
    }
}