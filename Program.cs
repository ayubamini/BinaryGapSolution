using System;

namespace BinaryGapSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a positive integer: ");

            var input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The result is: {0}", GetBinaryGap(Convert.ToString(input, 2).ToCharArray()));
        }

        private static int GetBinaryGap(char[] binaryString)
        {
            var checkSum = 0;
            var zeroCount = 0;

            for (var i = 0; i < binaryString.Length; i++)
            {
                if (binaryString[i] == '1')
                {
                    checkSum++;
                }
            }

            if (checkSum == 0 || checkSum == 1)
            {
                return 0;
            }

            return binaryString.Length;
        }
    }
}
