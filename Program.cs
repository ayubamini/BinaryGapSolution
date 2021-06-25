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
            var maxGap = 0;
            var gapCounter = 0;
            var zeroCounter = 0;

            for (var i = 0; i < binaryString.Length; i++)
            {
                if (binaryString[i] == '1')
                {
                    gapCounter++;
                }

                if (binaryString[i] == '0')
                {
                    zeroCounter++;
                }
            }

            if (zeroCounter == 0)
            {
                return 0;
            }

            if (gapCounter == 1 || gapCounter == 0)
            {
                return 0;
            }

            for (var i = 0; i < binaryString.Length; i++)
            {
                var lastValueIsOne = false;

                if (binaryString[i] == '1')
                {
                    gapCounter = 0;
                    for (var j = i + 1; j < binaryString.Length ; j++)
                    {
                        if (binaryString[j] == '1')
                        {
                            i = j;
                            i--;
                            lastValueIsOne = true;
                            break;
                        }

                        gapCounter++;
                    }

                    if (gapCounter > maxGap && lastValueIsOne)
                    {
                        maxGap = gapCounter;
                    }
                }
            }

            return maxGap;
        }
    }
}
