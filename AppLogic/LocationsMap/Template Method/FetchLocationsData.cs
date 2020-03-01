using System;
using FacebookWrapper.ObjectModel;

namespace AppLogic.LocationsMap
{
    internal abstract class FetchLocationsData
    {
        internal void CountLocations(FacebookObjectCollection<GeoPostedItem> i_Items)
        {
            {
                foreach (GeoPostedItem item in i_Items)
                {
                    if (item.Place != null)
                    {
                        if (needToCount(item.Place.Name))
                        {
                            LatestLocations.PlacesUserWasTaggedAt[item.Place.Name].NumOfVisits++;
                            count(item);
                        }
                        else
                        {
                            if (item.Place.Location != null)
                            {
                                addNewLocation(item);
                            }
                        }
                    }
                }
            }
        }

        private bool needToCount(string i_LocationName)
        {
            return LatestLocations.PlacesUserWasTaggedAt.ContainsKey(i_LocationName);
        }

        protected abstract void count(GeoPostedItem i_Item);

        protected abstract void addNewLocation(GeoPostedItem i_Item);
    }
}
