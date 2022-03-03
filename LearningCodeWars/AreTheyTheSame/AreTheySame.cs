using System;
using System.Collections.Generic;
using System.Linq;

namespace LearningCodeWars.AreTheyTheSame
{
    public static class AreTheySame
    {
        public static bool CompareUsingLists(int[] a, int[] b)
        {
            if (a == null || b == null)
            {
                return false;
            }

            List<int> firstList = a.OrderBy(i => i).ToList();
            List<int> secondList = b.OrderBy(i => i).ToList();

            for (int i = 0; i < firstList.Count; i++)
            {
                firstList[i] *= firstList[i];
            }

            return firstList.SequenceEqual(secondList);
        }

        public static bool CompareUsingArrays(int[] a, int[] b)
        {
            if (a == null || b == null)
            {
                return false;
            }

            Array.Sort(a);
            Array.Sort(b);

            int rIndex = 0;

            for (int i = 0; i < a.Length; i++)
            {
                a[i] *= a[i];

                if (a[i] != b[i])
                {
                    rIndex++;
                }
            }

            return rIndex == 0;
        }
    }
}