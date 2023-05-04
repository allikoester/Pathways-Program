/*

Developer name: Alli Koester
Last update: 3/6/23

Program description: This program will obtain a value that is the number of fee from the user and convert to inches, and provide the user the number of inches

Requirements: 
    (1) The input will come from user via console, and the output will be to the user
    (2)The number of feet will be an integer between 1 and 1000 inclusively 
    (3) The number of inches will be calculated by taking the input number of feet * 12

Algorithm: 
    I.  Do
            a.  Prompt the user for the number of feet
            b.  Get the number of feet from the user
            c.  If the number of feet is invalid (<0 or >1000)
                i.  Provide error message
        While number of feet is invalid 
    II. Convert the number of feet to the number of inches 
    III.Provide the number of inches back to the user 

 */

using System;
namespace FeetToInches
{
  class Program
  {
    static void Main(string[] args)
    {

            int numberOfFeet = 0; //declare number of feet used in loop 

        // I.   Do loop for data validation 

            do
            {

                // a.      Prompt the user for the number of feet

                    Console.Write("Please enter the number of feet between 1 and 1000 ");

                // b.     Get the number of feet from the user

                    try
                    {
                        numberOfFeet = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Please enter an integer.");
                
                    }
                    

                // c.      If the number of feet is invalid, give error message 

                    if ((numberOfFeet <=0 ) ||(numberOfFeet >=1000 ))
                         { 
                            Console.WriteLine("Please enter a value between 1 and 1000, inclusively");
                         } 

            } while ((numberOfFeet <=0 ) ||(numberOfFeet >1000 )); // end of do

        // II.    Convert the number of feet to the number of inches 

            int numberOfInches = numberOfFeet *12;

        // III.     Provide the number of inches back to the user 

            Console.WriteLine("The number of inches is " + numberOfInches );


    } // end Main
  } // end Program 
} // end Namespace
