using System;
using System.Linq;

namespace LearningCodeWars.Solutions
{
    /// <summary>
    /// Find the middle element
    /// returns the index of the numerical element that lies between the other two elements.
    /// gimme([2, 3, 1]) => 0
    /// gimme([5, 10, 14]) => 1
    /// </summary>
    public class Gimme
    {
        public static int GimmeKata(double[] inputArray)
        {
            //Resolved using solutions from codewars

            var sortedArray = inputArray.OrderBy(x => x).ToArray();
            var result = Array.IndexOf(inputArray, sortedArray[1]);
            return result;


            //double[] tripletArray = inputArray;
            //int index = 0;
            //for (int i = 0; i < tripletArray.Length;)
            //{
            //    if ((tripletArray[i] < tripletArray[i + 1]
            //        && tripletArray[i + 1] < tripletArray[i + 2])
            //        || tripletArray[i] > tripletArray[i + 1]
            //        && tripletArray[i + 1] > tripletArray[i + 2]) // 1 , 2 , 3 || 3, 2, 1
            //    {
            //        index = i + 1;
            //        break;
            //    }
            //    else if (tripletArray[i] < tripletArray[i + 1]
            //            && tripletArray[i] < tripletArray[i + 2]
            //            && tripletArray[i + 1] > tripletArray[i + 2]) //  1, 3, 2
            //    {
            //        index = i + 2;
            //        break;
            //    }
            //    else if (tripletArray[i] > tripletArray[i + 1]
            //            && tripletArray[i] < tripletArray[i + 2]) //  2 , 1 , 3
            //    {
            //        index = i;
            //        break;
            //    }
            //    else if (tripletArray[i] < tripletArray[i + 1]
            //            && tripletArray[i] > tripletArray[i + 2]) // 2, 3, 1
            //    {
            //        index = i;
            //        break;
            //    }
            //    else if (tripletArray[i + 1] < tripletArray[i + 2]
            //            && tripletArray[i + 2] < tripletArray[i]) // 3, 1, 2
            //    {
            //        index = i + 2;
            //        break;
            //    }
            //}

            //return index;
        }
    }
}
