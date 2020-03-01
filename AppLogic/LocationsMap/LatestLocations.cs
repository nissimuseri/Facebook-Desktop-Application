using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using FacebookWrapper.ObjectModel;

namespace AppLogic.LocationsMap
{
    internal class LatestLocations : ILocationsMap
    {
        private User m_ConnectedUser;

        internal static SortedDictionary<string, VisitedLocation> PlacesUserWasTaggedAt { get; set; } = new SortedDictionary<string, VisitedLocation>();

        public SortedDictionary<string, VisitedLocation> GetAllLocations(User i_User)
        {
            m_ConnectedUser = i_User;
            PlacesUserWasTaggedAt.Clear();
            FetchLocationsData[] locationData = new FetchLocationsData[] { new FetchPostsLocations(), new FetchCheckinsLocations(), new FetchPhotosLocations() };
            locationData[0].CountLocations(createCollection("Posts"));
            locationData[1].CountLocations(createCollection("Checkins"));
            locationData[2].CountLocations(createCollection("PhotosTaggedIn"));
            return PlacesUserWasTaggedAt;
        }

        private FacebookObjectCollection<GeoPostedItem> createCollection(string i_PropertyName)
        {
            PropertyInfo propertyInfo = m_ConnectedUser.GetType().GetProperty(i_PropertyName);
            FacebookObjectCollection<GeoPostedItem> items = new FacebookObjectCollection<GeoPostedItem>();
            if (propertyInfo is IEnumerable)
            {
                foreach (object o in propertyInfo as IEnumerable)
                {
                    items.Add(o as GeoPostedItem);
                }
            }

            return items;
        }
    }
}
