namespace LearningCodeWars
{
    public class Kata
    {
        /// <summary>
        /// Sort only the odd numbers in <paramref name="array"/>
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] SortArray(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) // if first number is even, move to the next number
                    continue;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] % 2 != 0) // if 2nd number is odd, do the comparison
                    {
                        if (array[i] > array[j]) //if the left value is more than the right, swap them
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
            }
            return array;
        }
    }
}