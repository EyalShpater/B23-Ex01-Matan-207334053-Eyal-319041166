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
            numOfDiamondLines = int.Parse(userInput);

            return numOfDiamondLines;
        }
    }
}
