using System.Collections.Generic;
using System.Linq;

namespace LearningCodeWars.Solutions
{
    public class ListFiltering
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<int> listOfNumbers = new();

            foreach (var item in listOfItems)
            {
                if (item.GetType() == typeof(int))
                {
                    listOfNumbers.Add((int)item);
                }
            }
            return listOfNumbers;


            ///another solution from codewars
            //return listOfItems.OfType<int>();
        }
    }
}