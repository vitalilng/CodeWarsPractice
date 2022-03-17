using System.Collections.Generic;

/// <summary>
/// Create a function that transforms any positive number to a string
/// representing the number in words.
/// The function should work for all numbers between 0 and 999999.
/// </summary>
namespace LearningCodeWars.WriteOutNumbers
{
    public static class NumberToWordTranslation
    {
        private static string numberToString = "";
        private static readonly List<string> ones = new() { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        private static readonly List<string> teens = new() { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        private static readonly List<string> tens = new() { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        private const string hundred = " hundred";
        private const string thousand = " thousand";

        public static string NumberToWords(int n)
        {
            if (n >= 0 && n < 10)
            {
                GetTheOnes(n);
            }
            else if (n > 9 && n < 20)
            {
                GetTheTeens(n);
            }
            else if (n > 19 && n < 100)
            {
                GetTheTens(n);
            }
            else if (n > 99 && n < 1000)
            {
                GetTheHundreds(n);
            }
            else if (n > 999 && n < 1000000)
            {
                GetTheThousands(n);
            }

            return numberToString;
        }

        public static string GetTheOnes(int n)
        {
            numberToString = ones[n];
            return numberToString;
        }

        public static string GetTheTeens(int n)
        {
            numberToString = teens[n - 10];
            return numberToString;
        }

        public static string GetTheTens(int n)
        {
            numberToString = tens[n / 10] + ((n % 10 != 0) ? "-" + GetTheOnes(n % 10) : "");
            return numberToString;
        }

        public static string GetTheHundreds(int n)
        {
            if (n % 100 != 0 && n % 100 < 10)
            {
                numberToString = GetTheOnes(n / 100) + hundred + " " + GetTheOnes(n % 100);
            }
            else if (n % 100 != 0 && n % 100 > 10 && n % 100 < 20)
            {
                numberToString = GetTheOnes(n / 100) + hundred + " " + GetTheTeens(n % 100);
            }
            else
            {
                numberToString = GetTheOnes(n / 100) + hundred + ((n % 100 != 0) ? " " + NumberToWords(n % 100) : "");
            }

            return numberToString;
        }

        public static string GetTheThousands(int n)
        {
            numberToString = NumberToWords(n / 1000) + thousand + ((n % 1000 != 0) ? " " + NumberToWords(n % 1000) : "");
            return numberToString;
        }
    }
}