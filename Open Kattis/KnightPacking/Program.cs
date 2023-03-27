/*

Developer Name Alli Koester
Last Upate 31323

Program Description Program will calculate if first of second player will win a game of placing a knight on the board after user input of size of board. 

Requirements
    (1) The input will come from user via console, and the output will be to the user
    (2) Input will be an integer between 1 and 1000 inclusively


Algorithm 
I. Do 
    A. Prompt user for size of board
    B. Get number from the user 
    C. If the number is invalid (1  N  1000)
        i. Provide error message
    While input is invalid 
II. If 
    A. Input is odd
        i. Assign to first player
III. Else
    B. Input is even and assign to second player 
*/


using System;
namespace KnightPacking
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfBoard;

            do
            {
                Console.Write("Please enter number for size of board: ");
                sizeOfBoard = Convert.ToInt32(Console.ReadLine());
                if ((sizeOfBoard < 1) || (sizeOfBoard > 1000))
                {
                    Console.WriteLine("Please enter number between 1 and 1000, inclusively ");
                }
            }

            while ((sizeOfBoard < 1) || (sizeOfBoard > 1000));
            if (sizeOfBoard % 2 != 0)
            {
                Console.Write("First");
            }
            else
            {
                Console.Write("Second");
            }
        }
    }
}

