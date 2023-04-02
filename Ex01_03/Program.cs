using System;

namespace Ex01_03
{
    class Program
    {
        public static void Main()
        {
            int numberOfDiamondLines = GetNumOfDiamondLinesFromUser();

            Ex01_02.Program.DrawDiamond(numberOfDiamondLines);
            Console.WriteLine("Please press 'Enter' to exit...");
            Console.ReadLine();
        }

        public static int GetNumOfDiamondLinesFromUser()
        {
            int numberOfDiamondLines;
            string userInput;

            Console.WriteLine("Enter number of Diamond lines: ");
            userInput = Console.ReadLine();      
            numberOfDiamondLines = checkValidityOfInput(userInput);

            return numberOfDiamondLines;
        }

        private static int checkValidityOfInput(string i_StringDiamondHeight)
        {
            int diamondHeight;
            bool isValid = int.TryParse(i_StringDiamondHeight, out diamondHeight);

            while (!isValid || diamondHeight < 0)
            {
                Console.WriteLine("Invalid Diamond height!");
                Console.WriteLine("Please enter a positive integer value: ");
                i_StringDiamondHeight = Console.ReadLine();
                isValid = int.TryParse(i_StringDiamondHeight, out diamondHeight);
            }

            if (diamondHeight % 2 == 0)
            {
                diamondHeight++;
            }

            return diamondHeight;
        }
    }
}
