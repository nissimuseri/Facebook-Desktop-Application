using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace AppLogic.FilterPosts
{
    internal class PostsFilter : IPostsFilter
    {
        public List<Tuple<User, Status>> GetAllStatuses(string i_StringToSearch, List<User> i_Friends)
        {
            List<Tuple<User, Status>> statusesOfFriend = new List<Tuple<User, Status>>();
            foreach (User friend in i_Friends)
            {
                foreach (Status friendStatus in friend.Statuses)
                {
                    if (friendStatus.Message != null)
                    {
                        if (friendStatus.Message.ToLower().Contains(i_StringToSearch))
                        {
                            statusesOfFriend.Add(new Tuple<User, Status>(friend, friendStatus));
                        }
                    }
                }
            }

            return statusesOfFriend;
        }
    }
}
