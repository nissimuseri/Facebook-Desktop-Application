using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace AppLogic.FilterPosts
{
    internal class PostsMemoryCacheProxy : IPostsFilter
    {
        private const int k_SizeOfMemory = 5;
        private PostsFilter m_StatusSearch;
        private string[] m_LastUsedTexts;
        private List<Tuple<User, Status>>[] m_LastUsedStatuses;
        private List<Tuple<User, Status>> m_ReleventStatuses;
        private int m_TextIndexNeedToChange;

        public PostsMemoryCacheProxy()
        {
            m_LastUsedTexts = new string[k_SizeOfMemory];
            m_LastUsedStatuses = new List<Tuple<User, Status>>[k_SizeOfMemory];
            m_TextIndexNeedToChange = 0;
        }

        public List<Tuple<User, Status>> GetAllStatuses(string i_StringToSearch, List<User> i_Friends)
        {
            if (m_StatusSearch == null)
            {
                m_StatusSearch = new PostsFilter();
            }

            bool isNewTextWasRecentlyUsed = false;

            isNewTextWasRecentlyUsed = checkAndUpdateRecentlyUsed(i_StringToSearch);

            if (!isNewTextWasRecentlyUsed)
            {
                m_ReleventStatuses = m_StatusSearch.GetAllStatuses(i_StringToSearch, i_Friends);
                if (m_ReleventStatuses.Count > 0)
                {
                    updateLastUsedTextsStatuses(i_StringToSearch);
                }
            }

            return m_ReleventStatuses;
        }

        public List<User> GetAllUserFriends(User i_User)
        {
            List<User> userFriendsList = new List<User>();
            foreach (User friend in i_User.Friends)
            {
                userFriendsList.Add(friend);
            }

            return userFriendsList;
        }

        private void updateLastUsedTextsStatuses(string i_StringToSearch)
        {
            if (m_TextIndexNeedToChange == k_SizeOfMemory)
            {
                m_TextIndexNeedToChange = 0;
            }

            m_LastUsedTexts[m_TextIndexNeedToChange] = i_StringToSearch;
            m_LastUsedStatuses[m_TextIndexNeedToChange] = m_ReleventStatuses;
            m_TextIndexNeedToChange++;
        }

        private bool checkAndUpdateRecentlyUsed(string i_StringToSearch)
        {
            bool checkIfTextWasRecentlyUsed = false;
            for (int i = 0; i < m_LastUsedTexts.Length; i++)
            {
                if (i_StringToSearch.Equals(m_LastUsedTexts[i]) == true && !checkIfTextWasRecentlyUsed)
                {
                    checkIfTextWasRecentlyUsed = true;
                    m_ReleventStatuses = m_LastUsedStatuses[i];
                }
            }

            return checkIfTextWasRecentlyUsed;
        }
    }
}
