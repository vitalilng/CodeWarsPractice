using System;
using System.Linq;

namespace LearningCodeWars.Solutions
{
    public static class VowelCount
    {
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;

            // Solved using LINQ
            //vowelCount = str.Count(c => "aeiou".Contains(Char.ToLower(c)));
                        
            for (int i = 0; i < str.Length; i++)
            {
                
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    vowelCount += 1;
                }
            }
            return vowelCount;
        }
    }
}
