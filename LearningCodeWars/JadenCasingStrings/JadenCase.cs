namespace LearningCodeWars.JadenCasingStrings
{
    public static class JadenCase
    {
        public static string ToJadenCase(this string phrase)
        {
            ///Simple solution
            //TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            //return textInfo.ToTitleCase(phrase);            

            ///Solution 2 using loops 
            string phraseCopy = phrase;

            for (int i = 0; i < phrase.Length - 1; i++)
            {
                phrase = $"{char.ToUpper(phraseCopy[0])}{phraseCopy.Substring(1, phraseCopy.Length - 1)}";

                if (char.IsWhiteSpace(phrase[i]))
                {
                    phraseCopy = ReplaceFirst(i, phrase, $"{phrase[i + 1]}", $"{char.ToUpper(phrase[i + 1])}");
                    phrase = phraseCopy;
                    i++;
                }
            }
            return phrase;
        }


        public static string ReplaceFirst(int index, string text, string search, string replace)
        {
            int pos = text.IndexOf(search, index);
            if (pos < 0)
            {
                return text;
            }
            return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
        }
    }
}
