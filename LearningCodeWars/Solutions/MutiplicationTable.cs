namespace LearningCodeWars.Solutions
{
    /// <summary>
    /// Your task, is to create NxN multiplication table, of size provided in parameter.
    /// for example, when given size is 3:
    /// the return value should be: [[1,2,3],[2,4,6],[3,6,9]]
    /// </summary>
    public class MultiplicationTable
    {
        public static int[,] CreateMultiplicationTable(int size)
        {
            var multiplicationTable = new int[size, size];

            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    multiplicationTable[0, 0] = 1;
                    multiplicationTable[i, j] = j switch
                    {
                        0 => multiplicationTable[0, 0] + i, // when j = 0 then add first value plus index of i
                        1 => multiplicationTable[i, 0] + multiplicationTable[i, 0], // when j = 1, sum up, first value from the row with itself
                        _ => multiplicationTable[i, j - 1] + multiplicationTable[i, 0] // for the rest of the cases, sum up previous element with 1st element from the row
                    };
                }
            }
            return multiplicationTable; //your table
        }
    }
}
