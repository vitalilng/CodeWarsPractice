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