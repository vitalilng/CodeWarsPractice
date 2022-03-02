using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Given a list lst and a number N, create a new list that contains each number of lst at most N
/// times without reordering. For example if N = 2, and the input is [1,2,3,1,2,1,2,3], you take
/// [1,2,3,1,2], drop the next [1,2] since this would lead to 1 and 2 being in the result 3 times,
/// and then take 3, which leads to [1,2,3,1,2,3].
/// </summary>
namespace LearningCodeWars.DeleteNth
{
    public static class DeleteNthElement
    {
        ///// <summary>
        /////Solve using List<>
        ///// </summary>
        public static int[] DeleteNthUsingList(int[] arr, int x)
        {
            List<int> listArray = arr.ToList();

            for (int i = 0; i < listArray.Count - 1; i++)
            {
                int nrOfRepetitions = 1;

                for (int j = i + 1; j < listArray.Count; j++)
                {
                    if (listArray[i].Equals(listArray[j]))
                    {
                        nrOfRepetitions++;
                    }

                    if (nrOfRepetitions > x)
                    {
                        listArray.RemoveAt(j);
                        j--;
                        nrOfRepetitions--;
                    }
                }
            }
            return listArray.ToArray();
        }

        ///// <summary>
        /////Solve using Array
        ///// </summary>
        public static int[] DeleteNthUsingArray(int[] arr, int x)
        {
            int nrOfOcurrences = x;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int nrOfRepetitions = 1;

                for (int j = i + 1; j <= arr.Length - 1; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        nrOfRepetitions++;
                    }

                    if (nrOfRepetitions > nrOfOcurrences)
                    {
                        arr = RemoveIndices(arr, j);
                        j--;
                        nrOfRepetitions--;
                    }
                }
            }
            return arr;
        }

        public static int[] RemoveIndices(int[] arrayToRemoveFrom,
                                          int removeIndex)
        {
            int[] newArrayToRemoveFrom = new int[arrayToRemoveFrom.Length - 1];
            int i = 0;
            int j = 0;
            while (i < arrayToRemoveFrom.Length)
            {
                if (i != removeIndex)
                {
                    newArrayToRemoveFrom[j] = arrayToRemoveFrom[i];
                    j++;
                }
                i++;
            }
            return newArrayToRemoveFrom;
        }
    }
}