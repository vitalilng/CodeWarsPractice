namespace LearningCodeWars.Solutions
{
    public static class PangramKata
    {
        /// <summary>
        /// Check if the given string is a pangram
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsPangram(string str)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            str = str.ToUpper();

            //Example1 of checking if a string is a pangram
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetter(str[i]) && alphabet.Contains(str[i]))
                    alphabet = alphabet.Replace(str[i].ToString(), string.Empty); //if the char is a letter and is found in the alphabet string
            }                                                                    // remove from alphabet 

            if (!string.IsNullOrEmpty(alphabet)) //if the alphabet string is empty, then it means we have a pangram
            {
                return false;
            }
            return true;


            //Example2 of checking if a string is a pangram
            //for(int i = 0; i<alphabet.Length; i++)
            //{
            //    if (!str.Contains(alphabet[i]))    // if the char is not found
            //    {                                  // return false and finish the loop
            //        return false;
            //    }

            //}
            //return true;
        }
    }
}