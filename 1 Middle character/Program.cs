/*1. Middle Characther
You are going to be given a word. Your job is to return the middle character of the word. If the word's length is odd, return the middle character. If the word's length is even, return the middle 2 characters.

#Examples:

"test" should return "es"

"testing" should return "t"

"middle" should return "dd"

"A" should return "A" #Input

A word (string) of length 0 < str < 1000. #Output

The middle character(s) of the word represented as a string.

PS: Should work for words of 999 characters

*/

using System;

namespace Strings_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is an 999 chars string: ");
            string my999CharsString = "1234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789x0123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678";
            int verificaLungime = my999CharsString.Length;
            Console.WriteLine(my999CharsString);
            Console.WriteLine($"String-ul my999CharsString are {verificaLungime} caractere.");

            Console.WriteLine(GetMiddle999(my999CharsString));

            Console.WriteLine("You can also test your own string here. Please enter it: ");
            string myString = Console.ReadLine();

            Console.WriteLine(GetMiddle(myString));

        }
        public static string GetMiddle999(string my999CharString)
        {
            string middle = "";
            if (my999CharString.Length % 2 != 0)
            {
                int middleIndex = (my999CharString.Length / 2);
                middle = my999CharString[middleIndex].ToString();
            }
            else
            {
                int middleIndex = (my999CharString.Length / 2);
                middle = my999CharString[(my999CharString.Length / 2) - 1].ToString() + my999CharString[(my999CharString.Length / 2)].ToString();
            }
            return middle;
        }


        public static string GetMiddle(string myString)
        {
            string middleString = "";
            if (myString.Length % 2 != 0)
            {
                int middleIndex = (myString.Length / 2);
                middleString = myString[middleIndex].ToString();
            }
            else
            {
                int middleIndex = (myString.Length / 2);
                middleString = myString[(myString.Length / 2) - 1].ToString() + myString[(myString.Length / 2)].ToString();
            }
            return middleString;
        }

    }
}
