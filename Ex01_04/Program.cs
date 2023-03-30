using System;
using System.Text;

namespace Ex01_04
{
    class Program
    {
        public static void Main()
        {
            
        }

        public static StringBuilder GetStringFromUser()
        {
            return new StringBuilder("s");
        }

        public static bool IsPalindrom(StringBuilder i_Text)
        {
            if (i_Text.Length <= 1)
            {
                return true;
            }
            else
            {
                const int k_FirstLetterIndex = 0;
                int lastLetterIndex = i_Text.Length - 1;
                char firstLetter, lastLetter;

                firstLetter = i_Text[k_FirstLetterIndex];
                lastLetter = i_Text[lastLetterIndex];
                i_Text.Remove(k_FirstLetterIndex, 1);
                i_Text.Remove(lastLetterIndex - 1, 1);

                return (firstLetter == lastLetter) && IsPalindrom(i_Text);
            }
        }

    }
}
