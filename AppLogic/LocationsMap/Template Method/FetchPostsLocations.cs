using FacebookWrapper.ObjectModel;

namespace AppLogic.LocationsMap
{
    internal class FetchPostsLocations : FetchLocationsData
    {
        protected override void count(GeoPostedItem i_Item)
        {
            LatestLocations.PlacesUserWasTaggedAt[i_Item.Place.Name].NumOfPosts++;
        }

        protected override void addNewLocation(GeoPostedItem i_Item)
        {
            LatestLocations.PlacesUserWasTaggedAt[i_Item.Place.Name] = new VisitedLocation(i_Item.Place.Name, 1, 1, 0, 0, (double)i_Item.Place.Location.Latitude, (double)i_Item.Place.Location.Longitude);
        }
    }
}
