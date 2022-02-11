using System.Collections.Generic;
using System.Linq;

/// <summary>
/// In this little assignment you are given a string of space separated numbers, and have to return the highest and lowest number.
/// </summary>

namespace LearningCodeWars.Solutions
{
    public static class HighestAndLowestNumber
    {
        public static string HighAndLow(string stringOfNumbers)
        {
            List<string> listOfStringNumbers = stringOfNumbers.Split(" ").ToList();

            List<int> listOfNumbers = new();

            foreach (string stringNumber in listOfStringNumbers)
            {
                listOfNumbers.Add(int.Parse(stringNumber));
            }

            return $"{listOfNumbers.Max()} {listOfNumbers.Min()}";
        }
    }
}