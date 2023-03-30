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
            Console.WriteLine("Enter number of Diamond lines: ");
            int numOfDiamondLines = int.Parse(Console.ReadLine());

            return numOfDiamondLines;
        }
    }
}
