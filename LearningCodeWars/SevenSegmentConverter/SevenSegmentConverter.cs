using System;

namespace LearningCodeWars.SevenSegmentConverter
{
    public static class SevenSegmentConverter
    {
        public static int SevenSegmentNumber(int number)
        {
            if (number is < 0 or > 9)
                throw new Exception();

            string binaryValue = "";

            switch (number)
            {
                case 0:
                    binaryValue = "1111101";
                    break;
                case 1:
                    binaryValue = "1010000";
                    break;
                case 2:
                    binaryValue = "0110111";
                    break;
                case 3:
                    binaryValue = "1010111";
                    break;
                case 4:
                    binaryValue = "1011010";
                    break;
                case 5:
                    binaryValue = "1001111";
                    break;
                case 6:
                    binaryValue = "1101111";
                    break;
                case 7:
                    binaryValue = "1010001";
                    break;
                case 8:
                    binaryValue = "1111111";
                    break;
                case 9:
                    binaryValue = "1011111";
                    break;
            }

            var result = 0.0;

            for (int i = binaryValue.Length - 1; i >= 0; i--)
                result += Convert.ToInt32(binaryValue[i].ToString()) * Math.Pow(2, binaryValue.Length - 1 - i);

            return (int)result;
        }
    }
}