using System;
namespace Ex01_01
{
    class Program
    {
        public static void Main()
        {
            int[] numbers = new int[3];
            int totalZeros = 0, totalOnes = 0, divisibleBy4 = 0, descendingSeries = 0, totalPalindromes = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter number #{i + 1} in binary format (8 digits): ");
                string input = Console.ReadLine();

                if (!IsValidBinary(input))
                {
                    Console.WriteLine("Invalid input. Enter a valid binary number with 8 digits.");
                    i--;
                    continue;
                }

                numbers[i] = Convert.ToInt32(input, 2);

                totalZeros += CountZeros(input);
                totalOnes += CountOnes(input);
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
            }

            Array.Sort(numbers);
            Array.Reverse(numbers);
            Console.WriteLine($"The numbers in decimal format, in descending order, are: {numbers[0]}, {numbers[1]}, {numbers[2]}");
            
            int totalInputs = 3;
            double avgZeros = (double)totalZeros / (double)(totalInputs * 8);
            double avgOnes = (double)totalOnes / (double)(totalInputs * 8);
            
            Console.WriteLine($"Average number of zeros: {avgZeros:F2}");
            Console.WriteLine($"Average number of ones: {avgOnes:F2}");
            Console.WriteLine($"Number of inputs divisible by 4: {divisibleBy4}");
            Console.WriteLine($"Number of inputs with digits in descending series: {descendingSeries}");
            Console.WriteLine($"Number of inputs with palindrome digits: {totalPalindromes}");
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