using System;
using System.Text;

namespace Ex01_04
{
    class Program
    {
        public static void Main()
        {
            RunApp();
            System.Console.WriteLine("Please press 'Enter' to exit...");
            System.Console.ReadLine();
        }

        public static void RunApp()
        {
            StringBuilder userInput = GetInputFromUser();
            int userNumber;

            if(IsValidInput(userInput))
            {
                Console.WriteLine(IsPalindrom(userInput) ? "Palindrom!" : "Not palindrom!");
                if(int.TryParse(userInput.ToString(), out userNumber))
                {
                    Console.WriteLine($"This number is{(!IsDividedByThree(userNumber) ? " not" : "")} divided by 3!"); 
                }
                else
                {
                    int numOfUpperCase = CountNumOfUpperCaseLetters(userInput);
                    Console.WriteLine("Your input includes {0} upper case letters", numOfUpperCase);
                }
            }
            else
            {
                Console.WriteLine("This input is not valid!");
            }
        }      

        public static StringBuilder GetInputFromUser()
        {
            string stringFromUser;
            StringBuilder returnValue = new StringBuilder();

            Console.WriteLine("Please enter a string");
            stringFromUser = Console.ReadLine();
            returnValue.Append(stringFromUser);
            
            return returnValue;
        }

        public static bool IsPalindrom(StringBuilder i_Text)
        {
            if(i_Text.Length <= 1)
            {
                return true;
            }
            else
            {
                const int k_FirstLetterIndex = 0;
                int lastLetterIndex = i_Text.Length - 1;
                char firstLetter, lastLetter;
                StringBuilder copyOfText = new StringBuilder();

                firstLetter = i_Text[k_FirstLetterIndex];
                lastLetter = i_Text[lastLetterIndex];
                copyOfText.Append(i_Text);
                copyOfText.Remove(k_FirstLetterIndex, 1);
                copyOfText.Remove(lastLetterIndex - 1, 1);

                return (firstLetter == lastLetter) && IsPalindrom(copyOfText);
            }
        }

        public static bool IsDividedByThree(int i_Number)
        {
            return i_Number % 3 == 0;
        }

        public static int CountNumOfUpperCaseLetters(StringBuilder i_Text)
        {
            int upperCaseCounter = 0;
            int length = i_Text.Length;

            for(int i = 0; i < length; i++)
            {
                char c = i_Text[i];

                if(char.IsUpper(c))
                {
                    upperCaseCounter++;
                }
            }
            
            return upperCaseCounter;
        }

        public static bool IsValidInput(StringBuilder i_Input)
        {
            int inputLength = i_Input.Length;
            bool isLengthValid = (inputLength == 6);
            bool includeLetter = false;
            bool includeDigit = false;
            bool includeUndfinedChar = false;

            if(inputLength != 6)
            {
                Console.WriteLine("Input must be 6 characters!");
            }
            else
            {
                for(int i = 0; i < inputLength; i++)
                {
                    char c = i_Input[i];

                    if(char.IsLetter(c))
                    {
                        includeLetter = true;
                    }
                    else if(char.IsDigit(c))
                    {
                        includeDigit = true;
                    }
                    else
                    {
                        includeUndfinedChar = true;
                    }
                }
            }

            return (includeLetter != includeDigit) && !includeUndfinedChar && isLengthValid;
        }
    }
}
