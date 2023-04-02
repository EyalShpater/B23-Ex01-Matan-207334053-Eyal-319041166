using System;

namespace Ex01_05
{
    class Program
    {
        public static void Main()
        {
            RunApp();
            System.Console.WriteLine("Please press 'Enter' to exit...");
            System.Console.ReadLine();
        }

        public static void RunApp()
        {
            const int k_NumOfDigitsExpected = 6;
            int number;
            bool isValidInput = GetUserInput(out number, k_NumOfDigitsExpected);

            while(!isValidInput)
            {
                Console.WriteLine("Invalid input!");
                isValidInput = GetUserInput(out number, k_NumOfDigitsExpected);
            }

            int numOfDigitsInNumber = numOfDigits(number);
            int numOfDigitsGraterThanLeastSignifiateDigit = CountNumberOfDigitsGraterThanLeastSignificateDigit(number);
            int minimumDigit = MinDigitInNumber(number);
            int numOfDigitsDividedByThree = NumOfDigitsDividedByThree(number);
            float avgOfDigits = AverageOfDigits(number);

            if(numOfDigitsInNumber != k_NumOfDigitsExpected)
            {
                int numOfZero = k_NumOfDigitsExpected - numOfDigitsInNumber;

                minimumDigit = 0;
                numOfDigitsDividedByThree += numOfZero;
            }

            PrintStatisticsOfString(numOfDigitsGraterThanLeastSignifiateDigit, minimumDigit,
                numOfDigitsDividedByThree, avgOfDigits);
        }

        public static bool GetUserInput(out int o_UserInput, int i_ValidNumberLength)
        {
            Console.WriteLine("Plesae enter a number");
            string userInput = Console.ReadLine();

            return int.TryParse(userInput, out o_UserInput) && (userInput.Length == i_ValidNumberLength);
        }

        public static void PrintStatisticsOfString(int i_NumOfDigitsGrater,
            int i_MinDig, int i_NumOfDigitsDividedByThree, float i_AvgOfDigits)
        {
            Console.WriteLine($"There are {i_NumOfDigitsGrater} digits grater the than least significate digit.");
            Console.WriteLine($"The minimum digit is {i_MinDig}.");
            Console.WriteLine($"There are {i_NumOfDigitsDividedByThree} digits divided by 3.");
            Console.WriteLine($"The average of the digits is: {i_AvgOfDigits}.");
        }

        public static int CountNumberOfDigitsGraterThanLeastSignificateDigit(int i_Number)
        {
            int count = 0;
            int leastSignificantDigit = i_Number % 10;

            i_Number = Math.Abs(i_Number);
            while(i_Number > 0)
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
            while(i_Number >= 10)
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

            i_Number = Math.Abs(i_Number);
            while(i_Number > 0)
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
            while(i_Number > 0)
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
            while(i_Number > 0)
            {
                count++;
                i_Number /= 10;
            }

            return count;
        }
    }
}
