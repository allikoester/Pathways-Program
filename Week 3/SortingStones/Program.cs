/*

Developer Name Alli Koester
Last Update: 3/20/23

Program Description: Program will ask user for number of stones, then calculate if first player (Alice) or second player (Bob) will win a 
    game of collecting two stones at a time. First player wins if there is a stone left. Second player wins if all stones collected. 

Requirements
    (1) The input will come from user via console, and the output will be to the user
    (2) Input will be an integer between 1 and 10,000,000 inclusively


Algorithm 
I. Do 
    A. Prompt user for number of stones
    B. Get number from the user 
    C. If the number is invalid (1 <= N <= 10000000)
        i. Provide error message
    While input is invalid 
II. If 
    A. Input is odd
        i. Assign to Alice
III. Else
    B. Input is even and assign to Bob
*/


using System;
namespace SortingStones
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStones;

            do
            {
                numberOfStones = Convert.ToInt32(Console.ReadLine());
                if ((numberOfStones < 1) || (numberOfStones > 10000000))
                {
                    Console.WriteLine("Please enter number between 1 and 10,000,000, inclusively ");
                }
            }

            while ((numberOfStones < 1) || (numberOfStones > 10000000));
            if (numberOfStones % 2 != 0)
            {
                Console.Write("Alice");
            }
            else
            {
                Console.Write("Bob");
            }
        }
    }
}

