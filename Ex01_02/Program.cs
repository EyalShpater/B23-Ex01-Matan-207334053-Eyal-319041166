using System;

namespace Ex01_02
{
    public class Program
    {
        public static void Main()
        {
            const int k_NumOfRowsToPrint = 9;

            DrawDiamond(k_NumOfRowsToPrint);
            System.Console.WriteLine("Please press 'Enter' to exit...");
            System.Console.ReadLine();
        }

        public static void DrawDiamond(int i_DiamondHeight)
        {
            const int k_NumOfStartingStars = 1;
            int numOfStartingSpaces = i_DiamondHeight / 2;
    
            drawDiamondRecursiveHelper(numOfStartingSpaces, k_NumOfStartingStars, i_DiamondHeight);
        }

        private static void drawDiamondRecursiveHelper(int i_NumOfSpaces, int i_NumOfStars, int i_DiamondHeight)
        {
            if (i_NumOfStars == i_DiamondHeight)
            {
                printLineOfStars(i_NumOfSpaces, i_NumOfStars);
            }
            else
            {
                printLineOfStars(i_NumOfSpaces, i_NumOfStars);
                drawDiamondRecursiveHelper(i_NumOfSpaces - 1, i_NumOfStars + 2, i_DiamondHeight);
                printLineOfStars(i_NumOfSpaces, i_NumOfStars);
            }
        }

        private static void printLineOfStars(int i_NumOfSpaces, int i_NumOfStars)
        {
            for (int i = 0; i < i_NumOfSpaces; i++)
            {
                Console.Write(" ");
            }

            for (int i = 0; i < i_NumOfStars; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}
