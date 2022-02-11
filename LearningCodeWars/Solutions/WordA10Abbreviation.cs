using System.Linq;
using System.Text.RegularExpressions;

namespace LearningCodeWars.Solutions
{
    public class WordA10Abbreviation
    {
        public static string Abbreviate(string input)
        {
            var result = "";
            var delimiters = new[] { '.', ',', '-', '\'', '!', ':', ';', ' ' };
            if (input.Length < 4) return input;
            if (input.IndexOfAny(delimiters) == -1) // if no special symbol found in the string
            {
                return input.Replace(input.Substring(1, input.Length - 2), $"{input.Length - 2}");
            }

            var splitInput = Regex.Matches(input, @"\w+\W?\s?").Select(m => m.Value).ToArray();

            foreach (var word in splitInput)
            {
                if (Regex.IsMatch(word, @"^\w+\W\s$")) //ends With Special Char And Space
                {
                    result += word.Length < 6
                        ? word
                        : word.Replace(word.Substring(1, word.Length - 4), $"{word.Length - 4}");
                }
                else if (Regex.IsMatch(word, @"^\w+\W$")
                         || Regex.IsMatch(word, @"^\w+\s$")) // ends with special char Only OR ends with space Only
                {
                    result += word.Length < 5
                        ? word
                        : word.Replace(word.Substring(1, word.Length - 3), $"{word.Length - 3}");
                }
                else // ends with letter
                {
                    result += word.Length < 4
                        ? word
                        : word.Replace(word.Substring(1, word.Length - 2), $"{word.Length - 2}");
                }
            }
            return result;
        }
    }
}
