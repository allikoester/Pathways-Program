/*

Developer name: Alli Koester
Last update: 3/7/23

Program description: This program will obtain a value that is a number in pounds from the user and convert to kilograms, 
    and provide the user the number of kilograms

Requirements: 
    (1) The input will come from user via console, and the output will be to the user
    (2) The number that is pounds will be a double between 1 and 500 inclusively 
    (3) The number that is kilograms will be calculated by taking the input number / 2.205

Algorithm: 
    I.      Prompt the user for the number of pounds
    II.     Get the number that is pounds from the user
    III.    Convert the number of pounds to number of kilograms
    IV.     Provide the number of kilograms back to the user 

 */

using System;
namespace PoundsToKilograms
{
  class Program
  {
    static void Main(string[] args)
    {

        // I.       Prompt the user for the number of pounds

            Console.Write("Please enter the number of Pounds from 1 to 500 ");

        // II.     Get the number that is pounds from the user

            double numberPounds = Convert.ToDouble(Console.ReadLine());

        // III.    Convert the number of pounds to number of kilograms

            double numberKilograms = numberPounds / 2.205;
         
        // IV.     Provide the number of kilograms back to the user

            Console.WriteLine("The number of kilograms is " + numberKilograms );


    } // end Main
  } // end Program 
} // end Namespace