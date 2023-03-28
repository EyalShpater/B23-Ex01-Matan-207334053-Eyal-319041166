using System;

namespace Ex01_03
{
    class Program
    {
        public static void Main()
        {
            int numOfDiamondLines = UserIO.GetNumOfDiamondLinesFromUser();

            Ex01_02.Diamond.Draw(numOfDiamondLines);
        }
    }
}
