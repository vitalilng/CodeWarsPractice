using System.Linq;
namespace LearningCodeWars.Solutions
{
    public class SumOfArray
    {
        public static int SumOfArrayElements(int[] array)
        {
            return array.Length == 0 ? 0 : array.Sum();
        }
    }
}
