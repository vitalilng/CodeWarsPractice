using System;
using System.Collections.Generic;
using System.Linq;

namespace LearningCodeWars.Solutions
{
    public class LongestPalindrom
    {
        public static int GetLongestPalindrom(string str)
        {            

            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }
            else if (str.Length == 1)
            {
                return 1;
            }
            else if (str.Length == 2)
            {
                //return str.Substring(0) == str.Substring(1) ? 2 : 1; // if 1st elem = 2nd element we have a palindrom
                return str.SequenceEqual(str.Reverse()) ? 2 : 1;
            }
            else if (str.Length >= 3 && str.SequenceEqual(str.Reverse()))
            {
                return str.Length;
            }
            else
            {
                char[] array = str.ToCharArray();
                var splitStr = new List<string>();
                int longestString = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] == array[j] && (j - i + 1) > longestString) // j-i + 1 > longest - if curent substring is > longest, 
                        {
                            if (IsPalindrom(str, i, j)) // if the substring is equal with reversed substring, we have a palindrom
                            {
                                splitStr.Add(str.Substring(i, j - i + 1));
                                longestString = splitStr.Max(s => s.Length); //find the longest added potentialy palindrom
                                i = j; // if we found the substring, inside it is no longer needed to search the palindrom
                                break;
                            }
                        }
                    }
                }
                return longestString;
            }
        }

        private static bool IsPalindrom(string str, int i, int j)
        {
            return str.Substring(i, j - i + 1).SequenceEqual(str.Substring(i, j - i + 1).Reverse());
        }
    }
}
