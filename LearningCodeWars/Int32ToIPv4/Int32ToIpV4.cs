using System.Net;

namespace LearningCodeWars.Int23ToIPv4
{
    public static class Int32ToIpV4
    {
        public static string UInt32ToIP(uint ip)
        {
            uint firstOctet = ip / 16777216;
            uint secondOctet = (ip - (firstOctet * 16777216)) / 65536;
            uint thirdOctet = (ip - (firstOctet * 16777216) - (secondOctet * 65536)) / 256;
            uint fourthOctet = ip - (firstOctet * 16777216) - (secondOctet * 65536) - (thirdOctet * 256);

            return $"{firstOctet}.{secondOctet}.{thirdOctet}.{fourthOctet}";
        }

        public static string UInt32ToIPUsingBuiltInMethods(uint ip)
        {
            return IPAddress.Parse(ip.ToString()).ToString();
        }

        /// <summary>
        /// Solution using shift right operator
        /// </summary>
        public static string UInt32ToIPUsingShiftRightOperator(uint ip)
        {
            return string.Format("{0}.{1}.{2}.{3}", ip >> 24, (ip >> 16) % 256, (ip >> 8) % 256, ip % 256);
        }

    }
}