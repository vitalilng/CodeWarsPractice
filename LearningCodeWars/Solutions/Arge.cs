namespace LearningCodeWars.Solutions
{
    public class Arge
    {
        public static int NbYear(int p0, double percent, int aug, int p)
        {
            // your code
            int p1 = 0;
            int n = 0;
            while (p1 < p)
            {
                n++; //nr of years
                int percentP = (int)(p0 * (percent / 100));
                p1 = p0 + percentP + aug;
                p0 = p1;
            }
            return n;
        }
    }
}