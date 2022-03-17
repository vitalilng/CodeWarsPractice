using System;
using System.Numerics;
using System.Text;

/// <summary>
/// Solved thanks to https://makolyte.com/algorithm-explained-sum-two-big-integers-the-hard-way/
/// </summary>
namespace LearningCodeWars.SumStringsAsNumbers
{
    public static class SumStrings
    {
        public static string SumString(string a, string b)
        {
            //pad a and b with 0's so they are the same length
            if (a.Length != b.Length)
            {
                var maxLength = Math.Max(a.Length, b.Length);
                a = a.PadLeft(maxLength, '0');
                b = b.PadLeft(maxLength, '0');
            }

            var sum = new StringBuilder();
            int carry = 0;

            for (int i = a.Length - 1; i >= 0; i--)
            {
                var digitSum = (a[i] - '0') + (b[i] - '0') + carry;
                if (digitSum > 9)
                {
                    carry = 1;
                    digitSum -= 10;
                }
                else
                {
                    carry = 0;
                }

                sum.Insert(0, digitSum);
            }

            if (carry == 1)
            {
                sum.Insert(0, carry);
            }

            return sum.ToString();
        }

        public static string SumStringUsingBigInteger(string a, string b)
        {
            BigInteger.TryParse(a, out BigInteger bigStringA);
            BigInteger.TryParse(b, out BigInteger bigStringB);

            return (bigStringA + bigStringB).ToString();
        }
    }
}