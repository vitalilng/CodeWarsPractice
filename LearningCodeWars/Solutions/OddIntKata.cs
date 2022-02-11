using System.Collections.Generic;
using System.Linq;

namespace LearningCodeWars.Solutions
{
    /// <summary>
    /// Return the number that repets an odd time in an array
    /// </summary>
    class OddIntKata
    {
        public static int Find_it(int[] seq)
        {
            for (int i = 0; i < seq.Length;)
            {
                int repetitions = 1; //nr of repetitions
                //seq = seq.Where(e => e != seq[i]).ToArray(); //remove the element

                for (int j = i + 1; j < seq.Length; j++)
                {
                    if (seq[i] == seq[j])
                    {
                        repetitions++;
                    }
                }
                //if the nr of repetitions is odd, return the number and finish the loop
                if (repetitions % 2 != 0)
                {
                    return seq[i];
                }
                else
                {
                    seq = seq.Where(e => e != seq[i]).ToArray(); //if nr of repetitions is not odd remove the element
                }
            }

            //Example 2 of how to count the nr of repetitions for each number in array 
            // and return the number with odd count of repetitions
            var dict = new Dictionary<int, int>();

            foreach(var value in seq)
            {
                dict.TryGetValue(value, out int count);
                dict[value] = count + 1;
            }

            foreach (var value in dict)
            {
                if(value.Value % 2 != 0)
                {
                    return value.Key;
                }
            }
            return -1;
        }
    }
}

