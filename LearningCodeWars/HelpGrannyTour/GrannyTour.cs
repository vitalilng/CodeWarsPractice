using System;
using System.Collections;
using System.Linq;

namespace LearningCodeWars.HelpGrannyTour
{
    public static class GrannyTour
    {
        public static int Tour(string[] arrFriends, string[][] friendTowns, Hashtable distanceHashTable)
        {
            //take the collection that has the minimum number of elements
            int f = arrFriends.Length;
            int t = friendTowns.Length;
            int d = distanceHashTable.Count;

            int minValue = Math.Min(Math.Min(f, t), d);

            string[] friendsWithCities = new string[minValue];
            float[] distancesFriends = new float[minValue];

            //remove the friends that are not found in town array, and towns that are not found in the friends array
            for (int k = 0; k < friendTowns.Length ; k++)
            {
                for (int l = 0; l < arrFriends.Length; l++)
                {
                    if (friendTowns[k][0] == arrFriends[l])
                    {
                        friendsWithCities[l] = friendTowns[k][1]; //copy the city value
                        break;
                    }
                }
            }
            
            //compare each key from hash with city array, if exist, then copy only the value
            foreach (DictionaryEntry item in distanceHashTable)
            {
                for (int m = 0; m < friendsWithCities.Length; m++)
                {
                    if ((string)item.Key == friendsWithCities[m])
                    {
                        distancesFriends[m] = (float)(double)item.Value;
                        break;
                    }
                }
            }

            distancesFriends = distancesFriends.Where(c => c != 0).ToArray();//remove empty values
            float totalDistance = distancesFriends[0];
            int lastIndex = distancesFriends.Length - 1;

            for (int j = 0; j < distancesFriends.Length - 1; j++)
            {
                totalDistance += (float)Math.Round(Math.Sqrt(Math.Pow(distancesFriends[j + 1], 2) - Math.Pow(distancesFriends[j], 2)), 2, MidpointRounding.ToZero);
            }

            totalDistance += distancesFriends[lastIndex];
            return (int)totalDistance;
        }
    }
}
