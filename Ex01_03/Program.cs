using System;

namespace Ex01_03
{
    class Program
    {
        public static void Main()
        {
            int numOfDiamondLines = GetNumOfDiamondLinesFromUser();

            Ex01_02.Program.DrawDiamond(numOfDiamondLines);
            System.Console.WriteLine("Please press 'Enter' to exit...");
            System.Console.ReadLine();
        }

        public static int GetNumOfDiamondLinesFromUser()
        {
            int numOfDiamondLines;
            string userInput;

            Console.WriteLine("Enter number of Diamond lines: ");
            userInput = Console.ReadLine();      
            numOfDiamondLines = checkValidityOfInput(ref userInput);

            return numOfDiamondLines;
        }

        private static int checkValidityOfInput(ref string io_DiamondHeight)
        {
            int diamondHeight;
            bool isValid = int.TryParse(io_DiamondHeight, out diamondHeight);

            while (!isValid || diamondHeight < 0)
            {
                Console.WriteLine("Invalid Diamond height!");
                Console.WriteLine("Please enter positive value: ");
                io_DiamondHeight = Console.ReadLine();
                isValid = int.TryParse(io_DiamondHeight, out diamondHeight);
            }

            if (diamondHeight % 2 == 0)
            {
                diamondHeight++;
            }

            return diamondHeight;
        }
    }
}
