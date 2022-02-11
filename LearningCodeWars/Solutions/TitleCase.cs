using System;
using System.Globalization;
using System.Linq;

namespace LearningCodeWars
{
    public class TitleCase
    {
        public static string TitleCaseKata(string title, string minorWords = "")
        {
            ///resolved using example from Codewars - TitleCase
            string result = "";
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

            if (string.IsNullOrEmpty(title))
            {
                return "";
            }
            else if (string.IsNullOrEmpty(minorWords))
            {
                result = textInfo.ToTitleCase(title.ToLower());
                return result;
            }

            var mainTitleString = title.ToLower().Split(" ").ToList();
            var minorWordsString = minorWords.ToLower().Split(" ").ToList();

            mainTitleString[0] = textInfo.ToTitleCase(mainTitleString[0]);
            return string.Join(" ", mainTitleString.Select(s => minorWordsString.Contains(s) ? s : textInfo.ToTitleCase(s)));

            ///Resolved with for's
            //for (int i = 0; i < mainTitleString.Count; i++)
            //{
            //    int count = 0;
            //    if (i == 0) //first string always goes TitleCase
            //    {
            //        result = textInfo.ToTitleCase(mainTitleString[i]);
            //        continue;
            //    }

            //    for (int j = 0; j < minorWordsString.Count; j++)
            //    {
            //        if (i > 0
            //            && mainTitleString[i] == minorWordsString[j])
            //        {
            //            count += 1; //count if any of the main words contain a minor word
            //        }
            //    }

            //    if (count == 0 && i > 0)  // 0 means no matches, then the word goes TitleCase
            //    {
            //        result += $" {textInfo.ToTitleCase(mainTitleString[i])}";
            //    }
            //    else if (count > 0) // higher than zero is a match, word remains lowercase
            //    {
            //        result += $" {mainTitleString[i]}";
            //    }
            //}
            //return result;
        }
    }
}