using System;

namespace Ex01_01
{
    class Program
    {
        public static void Main()
        {
            RunApp();
            Console.WriteLine("Please press 'Enter' to exit...");
            Console.ReadLine();
        }

        public static void RunApp()
        {
            int firstNumber, secondNumber, thirdNumber;
            int totalZeros = 0, totalOnes = 0, divisibleBy4 = 0, descendingSeries = 0, totalPalindromes = 0;

            GetBinaryNumbersFromUser(out firstNumber, out secondNumber, out thirdNumber, 
                ref totalZeros, ref totalOnes, ref divisibleBy4, ref descendingSeries, ref totalPalindromes);
            PrintStatistics(firstNumber, secondNumber, thirdNumber, totalZeros, totalOnes, 
                divisibleBy4, descendingSeries, totalPalindromes);
        }

        public static void PrintStatistics(int i_FirstNum, int i_SecondNum, int i_ThirdNum, int i_TotalZeros, 
            int i_TotalOnes, int i_DivisibleBy4, int i_DescendingSeries, int i_TotalPalindromes)
        {
            const int k_TotalInputs = 3;
            float avgZeros = (float)i_TotalZeros / (float)k_TotalInputs;
            float avgOnes = (float)i_TotalOnes / (float)k_TotalInputs;

            Console.WriteLine($"The numbers in decimal format are: {i_ThirdNum}, {i_SecondNum}, {i_FirstNum}");
            Console.WriteLine($"Average number of zeros: {avgZeros}");
            Console.WriteLine($"Average number of ones: {avgOnes}");
            Console.WriteLine($"Number of inputs divisible by 4: {i_DivisibleBy4}");
            Console.WriteLine($"Number of inputs with digits in descending series: {i_DescendingSeries}");
            Console.WriteLine($"Number of inputs with palindrome digits: {i_TotalPalindromes}");
        }

        public static void GetBinaryNumbersFromUser(out int o_FirstNum, out int o_SecondNum, out int o_ThirdNum, 
            ref int o_TotalZeros, ref int o_TotalOnes, ref int o_DivisibleBy4, ref int o_DescendingSeries, ref int o_TotalPalindromes)
        {
            getUserInputBinaryNumber(out o_FirstNum, ref o_TotalZeros, ref o_TotalOnes, 
                ref o_DivisibleBy4, ref o_DescendingSeries, ref o_TotalPalindromes);
            getUserInputBinaryNumber(out o_SecondNum, ref o_TotalZeros, ref o_TotalOnes, 
                ref o_DivisibleBy4, ref o_DescendingSeries, ref o_TotalPalindromes);
            getUserInputBinaryNumber(out o_ThirdNum, ref o_TotalZeros, ref o_TotalOnes, 
                ref o_DivisibleBy4, ref o_DescendingSeries, ref o_TotalPalindromes);
        }

        private static void getUserInputBinaryNumber(out int o_DecimalNum, ref int o_TotalZeros, ref int o_TotalOnes, 
            ref int o_DivisibleBy4, ref int o_DescendingSeries, ref int o_TotalPalindromes)
        {
            string input;

            Console.Write("Enter number in binary format (8 digits): ");
            input = Console.ReadLine();
            while (!IsValidBinary(input))
            {
                Console.WriteLine("Invalid input. Enter a valid binary number with 8 digits.");
                input = Console.ReadLine();
            }

            o_DecimalNum = ConvertBinaryStringToInt(input);
            o_TotalZeros += CountZeros(input);
            o_TotalOnes += countOnes(input);
            if (o_DecimalNum % 4 == 0)
            {
                o_DivisibleBy4++;
            }

            if (isDescendingSeries(o_DecimalNum))
            {
                o_DescendingSeries++;
            }
            
            if (isPalindrome(o_DecimalNum))
            {
                o_TotalPalindromes++;
            }
        }

        public static int ConvertBinaryStringToInt(string i_BinaryString)
        {
            int result = 0;
            int power = 0;

            for (int i = i_BinaryString.Length - 1; i >= 0; i--)
            {
                int digit = i_BinaryString[i] - '0';

                result += digit * (int)Math.Pow(2, power);
                power++;
            }

            return result;
        }

        public static bool IsValidBinary(string i_Input)
        {
            const int k_NumOfBits = 8;
            bool isValid = (i_Input != null && i_Input.Length == k_NumOfBits);

            for (int i = 0; isValid && i < i_Input.Length; i++)
            {
                if (i_Input[i] != '0' && i_Input[i] != '1')
                {
                    isValid = false;
                }
            }

            return isValid;
        }

        public static int CountZeros(string i_Input)
        {
            int count = 0;

            for(int i = 0; i < i_Input.Length; i++)
            {
                if(i_Input[i] == '0')
                {
                    count++;
                }

                i++;
            }

            return count;
        }

        private static int countOnes(string i_Input)
        {
            int count = 0;

            for (int i = 0; i < i_Input.Length; i++)
            {
                if (i_Input[i] == '1')
                {
                    count++;
                }

                i++;
            }

            return count;
        }

        private static bool isDescendingSeries(int i_Series)
        {
            bool isValid = true;
            string numStr = i_Series.ToString();

            for (int i = 0; i < numStr.Length - 1; i++)
            {
                if (numStr[i] <= numStr[i + 1])
                {
                    isValid = false;
                }
            }

            return isValid;
        }

        private static bool isPalindrome(int i_InputNum)
        {
            bool isPalindrom = true;
            string inputString = i_InputNum.ToString();

            for(int i = 0; i < inputString.Length / 2; i++)
            {
                if(inputString[i] != inputString[inputString.Length - 1 - i])
                {
                    isPalindrom = false;
                    break;
                }
            }

            return isPalindrom;
        }
    }
}