using System.Collections.Generic;
using System.Linq;
using AppLogic.LocationsMap;

namespace AppLogic.Strategy
{
    public class PhotosSort : ISortMethod<string, VisitedLocation>
    {
        public List<KeyValuePair<string, VisitedLocation>> Sort(SortedDictionary<string, VisitedLocation> i_ListToSort)
        {
            List<KeyValuePair<string, VisitedLocation>> sorted = (from kv in i_ListToSort orderby kv.Value.NumOfTaggedPhotos descending select kv).ToList();
            return sorted;
        }
    }
}
