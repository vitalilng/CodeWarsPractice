using System.Linq;
using System;

/// <summary>
/// Given a list lst and a number N, create a new list that contains each number of lst at most N times without reordering. 
/// For example if N = 2, and the input is [1,2,3,1,2,1,2,3], you take [1,2,3,1,2], 
/// drop the next [1,2] since this would lead to 1 and 2 being in the result 3 times, 
/// and then take 3, which leads to [1,2,3,1,2,3].
/// </summary>
namespace LearningCodeWars.DeleteNth
{
    public class DeleteNthElement
    {
        public static int[] DeleteNth(int[] arr, int x)
        {

            int nrOfOcurrences = x;
            

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int nrOfRepetitions = 1;

                for (int j = i + 1; j <= arr.Length - 1; j++)
                {

                    if (arr[i] == arr[j])
                    {
                        nrOfRepetitions += 1;
                    }

                    if (nrOfRepetitions > nrOfOcurrences && j == arr.Length - 1)
                    {
                       Array.Resize(ref arr, arr.Length - 1);
                    }
                    else if (nrOfRepetitions > nrOfOcurrences && j != arr.Length - 1)
                    {
                        arr[j] = arr[j + 1];
                        Array.Resize(ref arr, arr.Length - 1);
                        
                    }                    
                }               

            }
            return arr;
        }



        public T[] RemovetAt<T>(this T[] source, int index)
        {
            T[] dest = new T[source.Length - 1];
            if (index > 0)
            {
                Array.Copy(source, 0, dest, 0, index);
            }

            if (index < source.Length - 1)
            {
                Array.Copy(source, index + 1, dest, index, source.Length - index - 1);
            }

            return dest;

        }



    }
}
