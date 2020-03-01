using FacebookWrapper.ObjectModel;

namespace AppLogic.LocationsMap
{
    internal class FetchPhotosLocations : FetchLocationsData
    {
        protected override void count(GeoPostedItem i_Item)
        {
            LatestLocations.PlacesUserWasTaggedAt[i_Item.Place.Name].NumOfTaggedPhotos++;
        }

        protected override void addNewLocation(GeoPostedItem i_Item)
        {
            LatestLocations.PlacesUserWasTaggedAt[i_Item.Place.Name] = new VisitedLocation(i_Item.Place.Name, 1, 0, 0, 1, (double)i_Item.Place.Location.Latitude, (double)i_Item.Place.Location.Longitude);
        }
    }
}
