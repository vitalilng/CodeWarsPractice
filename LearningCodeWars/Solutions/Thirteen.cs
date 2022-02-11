namespace LearningCodeWars.Solutions
{
    /// <summary>
    /// codewars.com/kata/564057bc348c7200bd0000ff/csharp
    /// Thirteen
    /// </summary>
    public class Thirteen
    {
        public static long Thirt(long n)
        {
            //// Example solved with recursion
            int[] patternNumbers = { 1, 10, 9, 12, 3, 4 };
            long sum = 0;

            for (int i = 0; n > 0; i++)
            {
                if (i == patternNumbers.Length) i = 0;
                sum += n % 10 * patternNumbers[i];
                n /= 10; 
            }

            if (sum > 99) return Thirt(sum); //>99, cause any number <99 again multiplied will return the same number, and there is no reason 
            return sum;


            

            //Example solved iterative

            // convert the numberToCheck to an array and reverse the order
            //    int[] convertedNumberArray = ConvertToArrayAndReverseOrder(n);

            //    //multiply reversed array number with pattern and sum values
            //    long sumOfMultiply = 0;
            //    do
            //    {
            //        holdTheSumForVerifying = sumOfMultiply;
            //        sumOfMultiply = MultiplyAndSum(patternNumbers, convertedNumberArray);
            //        convertedNumberArray = ConvertToArrayAndReverseOrder(sumOfMultiply);

            //    } while (holdTheSumForVerifying != sumOfMultiply);
            //    return holdTheSumForVerifying;
            //}

            //private static long MultiplyAndSum(int[] patternNumbers, int[] convertedNumber)
            //{
            //    long sumOfMultiply = 0;
            //    int j = 0;

            //    for (int i = 0; i < convertedNumber.Length; i++)
            //    {
            //        sumOfMultiply += convertedNumber[i] * patternNumbers[j];
            //        if (j == patternNumbers.Length - 1)
            //        {
            //            j = 0;
            //            continue;
            //        }
            //        j++;
            //    }
            //    return sumOfMultiply;
            //}
            //static int[] ConvertToArrayAndReverseOrder(long number)
            //{
            //    return number.ToString().Select(o => Convert.ToInt32(o) - 48).Reverse().ToArray();
            //}
        }
    }
}