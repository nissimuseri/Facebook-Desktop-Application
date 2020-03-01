using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace AppLogic.LocationsMap
{
    internal interface ILocationsMap
    {
        SortedDictionary<string, VisitedLocation> GetAllLocations(User i_User);
    }
}
