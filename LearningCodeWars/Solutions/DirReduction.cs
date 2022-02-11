using System.Linq;

namespace LearningCodeWars.Solutions
{
    public class DirReduction
    {
        public static string[] DirectionReduction(string[] arr)
        {
            var listOfDirections = arr.ToList();

            for (var i = 0; i < listOfDirections.Count - 1;)
            {
                if (listOfDirections[i] == "NORTH" && listOfDirections[i + 1] == "SOUTH"
                    || listOfDirections[i] == "SOUTH" && listOfDirections[i + 1] == "NORTH"
                    || listOfDirections[i] == "EAST" && listOfDirections[i + 1] == "WEST"
                    || listOfDirections[i] == "WEST" && listOfDirections[i + 1] == "EAST")
                {
                    listOfDirections.RemoveRange(i, 2);
                    i = 0;
                }
                else i++;
            }
            return listOfDirections.ToArray();
        }
    }
}
