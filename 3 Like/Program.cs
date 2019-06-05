/*You probably know the "like" system from Facebook and other pages. 
People can "like" blog posts, pictures or other items. We want to create the text that should be displayed next to such an item.
Implement a function likes :: [String] -> String, which must take in input array, containing the names of people who like an item. 
It must return the display text as shown in the examples:

likes [] // must be "no one likes this" 
likes ["Peter"] // must be "Peter likes this" 
likes ["Jacob", "Alex"] // must be "Jacob and Alex like this" 
likes ["Max", "John", "Mark"] // must be "Max, John and Mark like this" 
likes ["Alex", "Jacob", "Mark", "Max"] // must be "Alex, Jacob and 2 others like this"*/


using System;
using System.Collections.Generic;

namespace _3_Like
{
    class Program
    {
        static void Main(string[] args)
        {

            var myList = new List<string>();
            string name = "0";
            while (name != "")
            {
                Console.WriteLine("Please enter the names of the persons who liked this: ");
                name = Console.ReadLine();
                if (name != "")
                {
                    myList.Add(name);
                }
                else
                {
                    myList.Remove(name);
                }
            }

            Likes(myList.ToArray());
        }
        public static void Likes(string[] myList)
        {
            int counter = 0;
            foreach (object o in myList)
            {
                counter++;
            }


            if (counter == 0)
            {
                Console.WriteLine("no one likes this");
            }
            else if (counter == 1)
            {
                Console.WriteLine($"{myList[0]} likes this");
            }
            else if (counter == 2)
            {
                Console.WriteLine($"{myList[0]} and {myList[1]} like this");
            }
            else if (counter == 3)
            {
                Console.WriteLine($"{myList[0]}, {myList[1]} and {myList[2]} like this");
            }
            else
            {
                int num = myList.Length - 2;

                Console.WriteLine($"{myList[0]}, {myList[1]} and {num} others like this");
            }
        }
    }
}
