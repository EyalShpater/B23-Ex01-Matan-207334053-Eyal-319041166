using System;

namespace Ex01_05
{
    class Program
    {
        public static void Main()
        {

        }

        public static bool GetUserInput(out int o_UserInput)
        {
            Console.WriteLine("Plesae enter a number");
            string userInput = Console.ReadLine();

            return int.TryParse(userInput, out o_UserInput);
        }

        public static int CountNumberOfDigitsGraterThanLeastSignificateDigit(int i_Number)
        {
            int count = 0;
            int leastSignificantDigit = i_Number % 10;

            while(Math.Abs(i_Number) > 0)
            {
                i_Number /= 10;
                if(i_Number % 10 > leastSignificantDigit)
                {
                    count++;
                }
            }

            return count;
        }

        public static int MinDigitInNumber(int i_Number)
        {
            int minDigit = i_Number % 10;

            while(Math.Abs(i_Number) > 0)
            {
                i_Number /= 10;
                if(i_Number % 10 < minDigit)
                {
                    minDigit = i_Number % 10;
                }
            }

            return minDigit;
        }

        public static int NumOfDigitsDividedByThree(int i_Number)
        {
            int count = 0;

            while (Math.Abs(i_Number) > 0)
            {
                if((i_Number % 10) % 3 == 0)
                {
                    count++;
                }

                i_Number /= 10;
            }

            return count;
        }
    }
}

