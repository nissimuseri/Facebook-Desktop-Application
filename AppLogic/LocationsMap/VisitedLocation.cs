namespace AppLogic.LocationsMap
{
    public class VisitedLocation
    {
        public string LocationName { get; set; }

        public int NumOfVisits { get; set; }

        public int NumOfPosts { get; set; }

        public int NumOfCheckins { get; set; }

        public int NumOfTaggedPhotos { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public VisitedLocation(string i_LocationName, int i_NumOfVisits, int i_NumOfPosts, int i_NumOfCheckins, int i_NumOfTaggedPhotos, double i_Latitude, double i_Longitude)
        {
            LocationName = i_LocationName;
            NumOfVisits = i_NumOfVisits;
            Latitude = i_Latitude;
            Longitude = i_Longitude;
            NumOfPosts = i_NumOfPosts;
            NumOfCheckins = i_NumOfCheckins;
            NumOfTaggedPhotos = i_NumOfTaggedPhotos;
        }
    }
}
