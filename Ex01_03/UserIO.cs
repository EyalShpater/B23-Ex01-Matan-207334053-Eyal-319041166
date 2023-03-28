using System;

namespace Ex01_03
{
    class UserIO
    {
        public static int GetNumOfDiamondLinesFromUser()
        {
            Console.WriteLine("Enter number of Diamond lines: ");
            int numOfDiamondLines = int.Parse(Console.ReadLine());

            return numOfDiamondLines;
        }
    }
}
