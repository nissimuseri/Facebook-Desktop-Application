using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace AppLogic.FilterPosts
{
    internal interface IPostsFilter
    {
        List<Tuple<User, Status>> GetAllStatuses(string i_StringToSearch, List<User> i_Friends);
    }
}
