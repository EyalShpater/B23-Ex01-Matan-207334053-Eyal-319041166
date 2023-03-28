namespace Ex01_02
{
    using System;
    class Diamond
    {
        public static void Draw(int i_DiamondHeight)
        {
            if(i_DiamondHeight%2==0)
            {
                i_DiamondHeight++;
            }

            drawRecursiveHelper(0, i_DiamondHeight);// 0 needs to be const
        }
        private static void drawRecursiveHelper(int i_NumOfIteration, int i_DiamondHeight)
        {
            if(i_NumOfIteration == i_DiamondHeight || i_DiamondHeight < 0)
            {
                return;
            }
            else
            {
                int numOfSpaces = (i_DiamondHeight - i_NumOfIteration) / 2;
                printLine(i_NumOfIteration, i_DiamondHeight);

            }
        }

        private static void printLine(int i_NumOfSpaces, int i_DiamondHeight)
        {

        }
    }
}

/*
 * 
 *       *
 *      ***
 *     *****
 *      ***
 *       *
 * 
 * 
 */