using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWarsTasks
{
    internal class Program
    {

        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems) => listOfItems.OfType<int>();

        public static void Main(string[] args)
        {
            List<object> listOfItems = new List<object>(){1,"a",5,7,5.6,4.5,'a'};
            foreach (var item in GetIntegersFromList(listOfItems))
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}