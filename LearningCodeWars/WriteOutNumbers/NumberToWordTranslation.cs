using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Create a function that transforms any positive number to a string
/// representing the number in words.
/// The function should work for all numbers between 0 and 999999.
/// </summary>
namespace LearningCodeWars.WriteOutNumbers
{
    public static class NumberToWordTranslation
    {
        public static string NumberToWords(int n)
        {
            string numberToString = "";
            string[] tens = { "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] tenTeen = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "ten" };
            const string hundred = "hundred";
            const string thousand = "thousand";
            
            
            
            



            return numberToString;

        }
    }
}
