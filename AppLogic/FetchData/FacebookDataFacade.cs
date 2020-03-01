using System;
using System.Collections.Generic;
using AppLogic.FilterPosts;
using AppLogic.LocationsMap;
using FacebookWrapper.ObjectModel;

namespace AppLogic
{
    public class FacebookDataFacade
    {
        private const int k_PostsToFetch = 10;
        private User m_ConnectedUser;
        private IPostsFilter m_IPostFilter;
        private PostsMemoryCacheProxy m_PostsMemory;
        private ILocationsMap m_ILocationsMap;
        private int m_PostsIndex = 0;

        public FacebookDataFacade(User i_User)
        {
            m_ConnectedUser = i_User;
            m_PostsMemory = new PostsMemoryCacheProxy();
            m_ILocationsMap = new LatestLocations();
        }

        public IEnumerable<Post> GetAllUserPosts()
        {
            int postsCount = m_ConnectedUser.Posts.Count;
            int postsCounter = 0;
            while (postsCounter < k_PostsToFetch && m_PostsIndex < postsCount - 1)
            {
                if (m_ConnectedUser.Posts[m_PostsIndex].Message != null)
                {
                    postsCounter++;
                    m_PostsIndex++;
                    yield return m_ConnectedUser.Posts[m_PostsIndex];
                }
                else
                {
                    m_PostsIndex++;
                }
            }

            if (m_PostsIndex == postsCount - 1)
            {
                throw new Exception("No more posts to fetch");
            }
        }

        public List<Tuple<User, Status>> SearchInFriendsStatuses(string i_TextToSearch)
        {
            if (m_IPostFilter == null)
            {
                m_IPostFilter = new PostsMemoryCacheProxy();
            }

            List<User> userFriends = m_PostsMemory.GetAllUserFriends(m_ConnectedUser);
            return m_PostsMemory.GetAllStatuses(i_TextToSearch.ToLower(), userFriends);
        }

        public List<KeyValuePair<string, VisitedLocation>> HardcodedLocation(ISortMethod<string, VisitedLocation> i_SortStartegy)
        {
            SortedDictionary<string, VisitedLocation> fakeLocations = new SortedDictionary<string, VisitedLocation>();
            fakeLocations["Rishon Lezion"] = new VisitedLocation("Rishon Lezion", 12, 5, 4, 3, 31.961020, 34.801620);
            fakeLocations["Ashdod"] = new VisitedLocation("Ashdod", 12, 0, 3, 9, 31.8024, 34.6405);
            fakeLocations["Ashkelon"] = new VisitedLocation("Ashkelon", 14, 9, 2, 3, 31.6677203, 34.5996736);
            fakeLocations["Tel Aviv"] = new VisitedLocation("Tel Aviv", 10, 2, 2, 6, 32.0750224, 34.7771282);
            List<KeyValuePair<string, VisitedLocation>> sortedLocations = i_SortStartegy.Sort(fakeLocations);
            return sortedLocations;
        }

        public List<KeyValuePair<string, VisitedLocation>> GetAllLocations(ISortMethod<string, VisitedLocation> i_SortStartegy)
        {
            SortedDictionary<string, VisitedLocation> allLocations = m_ILocationsMap.GetAllLocations(m_ConnectedUser);
            List<KeyValuePair<string, VisitedLocation>> sortedLocations = i_SortStartegy.Sort(allLocations);
            return sortedLocations;
        }
    }
}
