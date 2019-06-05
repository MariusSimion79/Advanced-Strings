/* The goal of this kata is to write a function that takes two inputs: a string and a character. 
 * The function will count the number of times that character appears in the string. 
 * The count is case insensitive.*/


using System;

namespace _2_Char_occurence_counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a string: ");
            string myString = Console.ReadLine();
            Console.Write("Please enter an character to count it in your string: ");
            string charToCount = Console.ReadLine();

            Console.WriteLine($"Your character appear {Counter(myString, charToCount)} times in your string.");
        }

        public static int Counter(string myString, string charToCount)
        {
            int counter = 0;
            int i = 0;

            while (i < myString.Length)
            {
                string letterToCheck = myString[i].ToString();
                if (letterToCheck.ToLower() == charToCount.ToLower())
                {
                    counter++;
                }
                i++;
            }
            return counter;
        }
    }
}
