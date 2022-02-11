using System;

namespace LearningCodeWars.Solutions
{
    public class StockList
    {
        public static string StockSummary(string[] lstOfArt, string[] lstOf1stLetter)
        {
            //Scenario using foreach

            if (lstOfArt.Length == 0)
            {
                return "";
            }
            string result = "";
            foreach (string m in lstOf1stLetter)
            {
                int tot = 0;
                int countNonLetterMatches = 0;

                foreach (string l in lstOfArt)
                {
                    if (m[0] == l[0]
                        && char.IsLetter(m[0])
                        && char.IsLetter(l[0]))
                    {
                        tot += int.Parse(l.Split(' ')[1]);
                    }
                    else if (m == l)
                    {
                        countNonLetterMatches += 1;
                        if (result.Contains('.'))
                        {
                            break;
                        }
                        else
                        {
                            result += m;
                            break;
                        }
                    }
                }

                bool resultStringIsNotNullAndStartsWithLetter = !string.IsNullOrEmpty(result) && char.IsLetter(result[1]);
                bool resultStringIsNotNullAndStartsWithDot = !string.IsNullOrEmpty(result) && result.StartsWith('.');

                if (resultStringIsNotNullAndStartsWithDot)
                {
                    if (countNonLetterMatches == 1)
                    {
                        continue;
                    }
                    else
                    {
                        result += " - (" + m + " : " + tot + ")";
                    }
                }
                else if (resultStringIsNotNullAndStartsWithLetter)
                {
                    result += " - ";
                    result += "(" + m + " : " + tot + ")";
                }
                else if (string.IsNullOrEmpty(result))
                {
                    result += "(" + m + " : " + tot + ")";
                }
            }
            return result;
        }
    }
}