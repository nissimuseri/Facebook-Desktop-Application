using System.Collections.Generic;
using AppLogic.LocationsMap;

namespace AppLogic
{
    public interface ISortMethod<T, S>
    {
        List<KeyValuePair<string, VisitedLocation>> Sort(SortedDictionary<T, S> i_ListToSort);
    }
}
