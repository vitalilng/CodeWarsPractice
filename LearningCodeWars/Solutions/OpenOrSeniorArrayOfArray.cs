using System.Collections.Generic;
using System.Linq;

namespace LearningCodeWars
{
    /// <summary>
    /// Catalogue the number member, depending on years and handicap
    /// </summary>
    public class OpenOrSeniorArrayOfArray
    {
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            //your code here
            foreach (int[] row in data)
            {
                if (row[0] >= 55 && row[1] > 7)
                {
                    yield return "Senior";//we don't need a list with using yield
                }
                else
                {
                    yield return "Open";
                }
            }

            ///resolved using Linq
            //return data.Select(member => member[0] >= 55 && member[1] > 7 ? "Senior" : "Open").ToList();
        }
    }
}