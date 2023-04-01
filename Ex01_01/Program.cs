using System;
namespace Ex01_01
{
    class Program
    {
        public static void Main()
        {
            int firstNum, secondNum, thirdNum;

            int totalZeros = 0, totalOnes = 0, divisibleBy4 = 0, descendingSeries = 0, totalPalindromes = 0;

            GetBinaryNumbersFromUser(out firstNum, out secondNum, out thirdNum,  ref totalZeros, ref totalOnes);
            CalculateStatistics(firstNum,  secondNum,  thirdNum);

            Console.WriteLine($"The numbers in decimal format, in descending order, are: {firstNum}, {secondNum}, {thirdNum}");
            
            int totalInputs = 3;
            double avgZeros = (double)totalZeros / (double)(totalInputs * 8);
            double avgOnes = (double)totalOnes / (double)(totalInputs * 8);
            
            Console.WriteLine($"Average number of zeros: {avgZeros:F2}");
            Console.WriteLine($"Average number of ones: {avgOnes:F2}");
            Console.WriteLine($"Number of inputs divisible by 4: {divisibleBy4}");
            Console.WriteLine($"Number of inputs with digits in descending series: {descendingSeries}");
            Console.WriteLine($"Number of inputs with palindrome digits: {totalPalindromes}");
        }

        public static void GetBinaryNumbersFromUser(out int o_FirstNum, out int o_SecondNum, out int o_ThirdNum,  ref int o_TotalZeros, ref int o_TotalOnes)
        {
            getUserInputBinaryNumer(out o_FirstNum, ref o_TotalZeros, ref o_TotalOnes);
            getUserInputBinaryNumer(out o_SecondNum, ref o_TotalZeros, ref o_TotalOnes);
            getUserInputBinaryNumer(out o_ThirdNum, ref o_TotalZeros, ref o_TotalOnes);
                
            if (numbers[i] % 4 == 0)
            {
                  divisibleBy4++;
            }

            if (IsDescendingSeries(numbers[i]))
            {
                descendingSeries++;
                        }
                    if (IsPalindrome(numbers[i].ToString()))
                    {
                        totalPalindromes++;
                    }

            Array.Sort(numbers);
            Array.Reverse(numbers);
        }

        public static void getUserInputBinaryNumer(out int o_BinaryNum, ref int o_TotalZeros, ref int o_TotalOnes)
        {
            Console.Write($"Enter number in binary format (8 digits): ");
            string input = Console.ReadLine();
            while(!IsValidBinary(input))
            {
                Console.WriteLine("Invalid input. Enter a valid binary number with 8 digits.");
                input = Console.ReadLine();
            }
            o_BinaryNum = ConvertBinaryStringToInt(input);
            o_TotalZeros+= CountZeros(input);
            o_TotalOnes += CountOnes(input);
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
            if (input.Length != 8) return false;
            foreach (char c in input)
            {
                if (c != '0' && c != '1') return false;
            }
            return true;
        }

        public static int CountZeros(string input)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (c == '0') count++;
            }
            return count;
        }

        private static int CountOnes(string input)
        {
            int count = 0;
            foreach (char c in input)
            {
                if (c == '1') count++;
            }
            return count;
        }

        private static bool IsDescendingSeries(int num)
        {
            string numStr = num.ToString();
            for (int i = 0; i < numStr.Length - 1; i++)
            {
                if (numStr[i] <= numStr[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        private static bool IsPalindrome(string input)
        {
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - 1 - i]) return false;
            }
            return true;
        }

    }
}