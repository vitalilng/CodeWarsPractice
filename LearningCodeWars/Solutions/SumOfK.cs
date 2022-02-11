using System.Collections.Generic;
using System.Linq;

namespace LearningCodeWars.Solutions
{
    public static class SumOfK
    {
        public static int? ChooseBestSum(int maxSumOfDistances, int towns, List<int> listOfDistances)
        {
            var sumOfDistances = FindCombinations(listOfDistances, towns, maxSumOfDistances);
            return sumOfDistances;
        }

        public static int? FindCombinations(List<int> lsOfDistances, int towns, int maxSumOfDistances)
        {
            int? sumOfDistances = 0;
            var subArrays = new List<int>();

            if (maxSumOfDistances == 0)
            {
                return null;
            }

            FindCombinations(lsOfDistances, 0, towns, subArrays, new List<int>());
            subArrays.Sort();
            
            if (subArrays.Count == 0 || subArrays.Contains(0) || subArrays.First() > maxSumOfDistances) 
            {
                return null;
            }

            foreach (var sumOfArrays in subArrays.Where(sumOfArrays => sumOfArrays <= maxSumOfDistances))
            {
                if (sumOfArrays == maxSumOfDistances)
                {
                    sumOfDistances = sumOfArrays;
                }
                else if (sumOfArrays > sumOfDistances && sumOfArrays < maxSumOfDistances)

                {
                    sumOfDistances = sumOfArrays;
                }
            }
            return sumOfDistances; 
        }

        private static void FindCombinations(List<int> lsOfDistances, int i, int towns, List<int> subArrays, List<int> listOfElements)
        {
            if (lsOfDistances.Count == 0)
            {
                return;
            }

            if (towns == 0)
            {
                subArrays.Add(listOfElements.Sum());
                return;
            }
            if (i == lsOfDistances.Count)
            {
                return;
            }

            listOfElements.Add(lsOfDistances[i]);
            FindCombinations(lsOfDistances, i + 1, towns - 1, subArrays, listOfElements);

            listOfElements.RemoveAt(listOfElements.Count - 1);
            FindCombinations(lsOfDistances, i + 1, towns, subArrays, listOfElements);

        }
    }
}
