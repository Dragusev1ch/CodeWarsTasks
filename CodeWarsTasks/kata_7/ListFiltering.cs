using System.Collections.Generic;
using System.Linq;

namespace CodeWarsTasks.kata_7
{
    public class ListFiltering
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems) => listOfItems.OfType<int>();
    }
}