using System;
using System.Collections.Generic;
using System.Linq;



/// <summary>
/// Given two integers a and b, which can be positive or negative, find the sum of all the integers between and including them and return it. 
/// If the two numbers are equal return a or b.
/// Note: a and b are not ordered!
/// </summary>


namespace LearningCodeWars.Solutions
{
    public class SumOfNumbers
    {
        public static int GetSum(int a, int b)
        {
            if (a == b) return a;
            if (a > b)
            {
                int swap = a;
                a = b;
                b = swap;
            }

            List<int> result = new();

            for (int i = a; i <= b; i++)
            {
                result.Add(i);
            }

            return result.Sum();

            //return (a + b) * (Math.Abs(a - b) + 1) / 2;


         }
    }
}
