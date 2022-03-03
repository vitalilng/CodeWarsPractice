using System;
using System.Collections.Generic;
using System.Linq;

namespace LearningCodeWars.AreTheyTheSame
{
    public static class AreTheySame
    {
        public static bool Comp(int[] a, int[] b)
        {
            if (a == null || b == null)
            {
                return false;
            }

            List<int> firstList = a.ToList();
            List<int> secondList = b.ToList();

            //Console.WriteLine(string.Join(",", firstArray));
            //Console.WriteLine(string.Join(",", secondArray));


            //foreach (var item in firstArray)
            //{
            //    Console.WriteLine(item);
            //}
            



            for (int i = 0; i < firstList.Count; i++)
            {
                firstList[i] *= firstList[i];
            }

            int rIndex = 0;
            for (int i = 0; i < firstList.Count; i++)
            {
                for (int j = 0; j < secondList.Count; j++)
                {
                    if (firstList[i] == secondList[j])
                    {
                        rIndex++;
                        firstList.RemoveAt(i);
                        secondList.RemoveAt(j);
                    }
                }
            }

            if (rIndex == firstList.Count)
            {
                return true;
            }
            else
            {
                return false;
            }



        }
    }
}