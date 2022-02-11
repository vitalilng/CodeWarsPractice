namespace LearningCodeWars
{
    public class DnaStrand
    {
        /// <summary>
        /// Dna strand replacer
        /// A->T
        /// T->A
        /// G->C
        /// C->G
        /// </summary>
        /// <param name="dna"></param>
        /// <returns></returns>

        public static string MakeComplement(string dna)
        {
            //Your code
            string expected = dna;

            for (int i = 0; i < expected.Length; i++)
            {
                switch (expected[i])
                {
                    case 'A':
                        expected = expected.Remove(i, 1).Insert(i, "T");
                        continue;
                    case 'T':
                        expected = expected.Remove(i, 1).Insert(i, "A");
                        continue;
                    case 'C':
                        expected = expected.Remove(i, 1).Insert(i, "G");
                        continue;
                    case 'G':
                        expected = expected.Remove(i, 1).Insert(i, "C");
                        continue;
                }
            }
            return expected;
        }
    }
}