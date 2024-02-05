using System.Collections;
using CSharp.Models;

// main

class Program
{
    static void Main()
    {
        // creates new instance of Solution Class
        Solution solution = new Solution();

        // starts a loop to check strings with the Solution
        while (true)
        {

            Console.WriteLine("Type a string to return the index of its first non-repeating character");
            
            // stores the string in the s variable
            string s = Console.ReadLine();

            // stores the solution for the s string in the result variable
            int result = solution.FirstUniqChar(s);

            //shows the result on the console
            Console.WriteLine(result == -1 ? "Result -1. No non-repeating character found." : $"Index of the first non-repeating character: {result}");

        
            Console.WriteLine("Try another string? (y/n)");
            
            // stores condition for breaking the loop in the repeat variable
            string repeat = Console.ReadLine().ToLower();

            // ends program if repeat == no
            if (repeat == "n" || repeat == "no")
            {
                Console.WriteLine("Exiting program.");
                break; // Exit the loop instead of using Environment.Exit(0)
            }
        }
    }
}