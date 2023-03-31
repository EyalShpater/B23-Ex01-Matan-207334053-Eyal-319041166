using System;

namespace Ex01_05
{
    class Program
    {
        public static void Main()
        {
            const int k_NumOfDigitsExpected = 6;
            int number;
            bool isValidInput = GetUserInput(out number, k_NumOfDigitsExpected);

            while (isValidInput)
            {
                Console.WriteLine("Invalid input!");
                isValidInput = GetUserInput(out number, k_NumOfDigitsExpected);
            }

            int numOfDigitsInNumber = numOfDigits(number);
            int numOfDigitsGrater = CountNumberOfDigitsGraterThanLeastSignificateDigit(number);
            int minDig = MinDigitInNumber(number);
            int numOfDigitsDividedByThree = NumOfDigitsDividedByThree(number);
            float avgOfDigits = AverageOfDigits(number);

            if(numOfDigitsInNumber != k_NumOfDigitsExpected)
            {
                minDig = 0;
                numOfDigitsDividedByThree++;
            }

            string msg = string.Format(
                    @"There are {0} digits grater the the least significate digit.
The minimum digit is {1}.
There are {2} digits divided by 3.
The average of the digits is: {3}."
                    , numOfDigitsGrater, minDig, numOfDigitsDividedByThree, avgOfDigits);
            Console.WriteLine(msg);
        }

        public static bool GetUserInput(out int o_UserInput, int i_ValidNumberLength)
        {
            Console.WriteLine("Plesae enter a number");
            string userInput = Console.ReadLine();

            return int.TryParse(userInput, out o_UserInput) && (userInput.Length == i_ValidNumberLength);
        }

        public static int CountNumberOfDigitsGraterThanLeastSignificateDigit(int i_Number)
        {
            int count = 0;
            int leastSignificantDigit = i_Number % 10;

            i_Number = Math.Abs(i_Number);
            while (i_Number > 0)
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

            i_Number = Math.Abs(i_Number);
            while (i_Number >= 10)
            {
                i_Number /= 10;
                if (i_Number % 10 < minDigit)
                {
                    minDigit = i_Number % 10;
                }
            }

            return minDigit;
        }

        public static int NumOfDigitsDividedByThree(int i_Number)
        {
            int count = 0;

            i_Number = Math.Abs(i_Number);
            while (i_Number > 0)
            {
                if((i_Number % 10) % 3 == 0)
                {
                    count++;
                }

                i_Number /= 10;
            }

            return count;
        }

        public static float AverageOfDigits(int i_Number)
        {
            const int k_NumberLength = 6;
            float avg = 0;

            i_Number = Math.Abs(i_Number);
            while (i_Number > 0)
            {
                avg += i_Number % 10;
                i_Number /= 10;
            }

            return avg / k_NumberLength;
        }

        private static int numOfDigits(int i_Number)
        {
            int count = 0;

            i_Number = Math.Abs(i_Number);
            while (i_Number > 0)
            {
                count++;
                i_Number /= 10;
            }

            return count;
        }
    }
}

