namespace Ex01_02
{
    using System;

    public class Diamond
    {
        public static void Draw(int i_DiamondHeight)
        {
            const int k_NumOfStartingStars = 1;
            int numOfStartingSpaces = i_DiamondHeight / 2;

            if (i_DiamondHeight < 0)
            {
                Console.WriteLine("Invalid Diamond height!");
                return;
            }

            if (i_DiamondHeight % 2 == 0)
            {
                i_DiamondHeight++;
            }
            
            drawRecursiveHelper(numOfStartingSpaces, k_NumOfStartingStars, i_DiamondHeight);
        }
        private static void drawRecursiveHelper(int i_NumOfSpaces, int i_NumOfStars, int i_DiamondHeight)
        {
            if (i_NumOfStars == i_DiamondHeight)
            {
                printLine(i_NumOfSpaces, i_NumOfStars);
            }
            else
            {
                printLine(i_NumOfSpaces, i_NumOfStars);
                drawRecursiveHelper(i_NumOfSpaces - 1, i_NumOfStars + 2, i_DiamondHeight);
                printLine(i_NumOfSpaces, i_NumOfStars);
            }
        }

        private static void printLine(int i_NumOfSpaces, int i_NumOfStars)
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