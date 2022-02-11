using System;
using System.Linq;

namespace LearningCodeWars.Solutions
{
    /// <summary>
    /// Rot13
    /// replaces a letter with the 13th letter after it in the alphabet
    /// https://www.codewars.com/kata/530e15517bc88ac656000716/train/csharp
    /// </summary>
    public class Rot13Cipher
    {
        public static string Rot13(string message)
        {
            // example 1
            string result = "";

            foreach (var s in message)
            {
                if ((s is >= 'a' and <= 'm') || (s is >= 'A' and <= 'M'))
                {
                    result += Convert.ToChar(s + 13).ToString();
                }
                else if ((s is >= 'n' and <= 'z') || (s is >= 'N' and <= 'Z'))
                {
                    result += Convert.ToChar(s - 13).ToString();
                }
                else result += s;
            }
            return result;
            ///example 2 
            //char[] array = message.ToCharArray();

            //for (int i = 0; i < array.Length; i++)
            //{
            //    int n = array[i]; //equals with ASCII letter code

            //    switch (n)
            //    {
            //        case >= 'a' and <= 'm':
            //        case >= 'A' and <= 'M':
            //            n += 13;
            //            break;
            //        case >= 'n' and <= 'z':
            //        case >= 'N' and <= 'Z':
            //            n -= 13;
            //            break;
            //    }
            //    array[i] = (char)n;
            //}
            //return new string(array);
        }
    }
}
