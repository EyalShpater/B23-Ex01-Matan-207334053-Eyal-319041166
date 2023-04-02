using System;
namespace Ex01_01
{
    class Program
    {
        static void Main()
        {
            RunApp();
            System.Console.WriteLine("Please press 'Enter' to exit...");
            System.Console.ReadLine();
        }
        public static void RunApp()
        {
            int firstNum, secondNum, thirdNum;
            int totalZeros = 0, totalOnes = 0, divisibleBy4 = 0, descendingSeries = 0, totalPalindromes = 0;

            GetBinaryNumbersFromUser(out firstNum, out secondNum, out thirdNum, ref totalZeros, 
                ref totalOnes, ref divisibleBy4, ref descendingSeries, ref totalPalindromes);
            PrintStatistics(firstNum, secondNum, thirdNum, totalZeros, totalOnes, 
                divisibleBy4, descendingSeries, totalPalindromes);
        }

        public static void PrintStatistics(int i_FirstNum, int i_SecondNum, int i_ThirdNum, int i_TotalZeros, 
            int i_TotalOnes, int i_DivisibleBy4, int i_DescendingSeries, int i_TotalPalindromes)
        {
            const int k_TotalInputs = 3;
            float avgZeros = (float)i_TotalZeros / (float)(k_TotalInputs);
            float avgOnes = (float)i_TotalOnes / (float)(k_TotalInputs);

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
            Console.Write("Enter number in binary format (8 digits): ");
            string input = Console.ReadLine();
            while (!IsValidBinary(input))
            {
                Console.WriteLine("Invalid input. Enter a valid binary number with 8 digits.");
                input = Console.ReadLine();
            }
            o_DecimalNum = ConvertBinaryStringToInt(input);
            o_TotalZeros += CountZeros(input);
            o_TotalOnes += CountOnes(input);

            if (o_DecimalNum % 4 == 0)
            {
                o_DivisibleBy4++; //io?
            }

            if (IsDescendingSeries(o_DecimalNum))
            {
                o_DescendingSeries++;
            }
            
            if (IsPalindrome(o_DecimalNum))
            {
                o_TotalPalindromes++;
            }
        }

        public static int ConvertBinaryStringToInt(string binaryString)
        {
            int result = 0;
            int power = 0;

            for (int i = binaryString.Length - 1; i >= 0; i--)
            {
                int digit = binaryString[i] - '0';

                result += digit * (int)Math.Pow(2, power);
                power++;
            }

            return result;
        }

        public static bool IsValidBinary(string input)
        {
            bool isValid = true;
            if (input == null || input.Length != 8)
            {
                isValid = false;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != '0' && input[i] != '1')
                {
                    isValid = false;
                }
            }

            return isValid;
        }

        public static int CountZeros(string input)
        {
            int count = 0;
            int i = 0;
            while (i < input.Length)
            {
                if (input[i] == '0')
                {
                    count++;
                }
                i++;
            }
            return count;
        }

        private static int CountOnes(string input)
        {
            int count = 0;
            int i = 0;
            while (i < input.Length)
            {
                if (input[i] == '1')
                {
                    count++;
                }
                i++;
            }
            return count;
        }

        private static bool IsDescendingSeries(int num)
        {
            bool isValid = true;
            string numStr = num.ToString();
            for (int i = 0; i < numStr.Length - 1; i++)
            {
                if (numStr[i] <= numStr[i + 1])
                {
                    isValid = false;
                }
            }
            return isValid;
        }

        private static bool IsPalindrome(int i_inputNum)
        {
            bool isPalindrom = true;
            string inputString = i_inputNum.ToString();
            for (int i = 0; i < inputString.Length / 2; i++)
            {
                if (inputString[i] != inputString[inputString.Length - 1 - i])
                {
                    isPalindrom = false;
                    break;
                }
            }
            return isPalindrom;
        }

    }
}