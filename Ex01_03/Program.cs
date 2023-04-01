using System;

namespace Ex01_03
{
    class Program
    {
        public static void Main()
        {
            int numOfDiamondLines = GetNumOfDiamondLinesFromUser();

            Ex01_02.Program.DrawDiamond(numOfDiamondLines);    
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
