/*

Developer name: Alli Koester
Last update: 3/6/23

Program description: This program will obtain a value that is a number/temperature in Celcius from the user and convert to Fahrenheit, 
    and provide the user the temperature number in Fahrenheit

Requirements: 
    (1) The input will come from user via console, and the output will be to the user
    (2) The number that is a Celsius temperature will be an integer between 1 and 150 inclusively 
    (3) The number that is a Fahrenheit temperature will be calculated by taking the input number *9/5 + 32

Algorithm: 
    I.      Prompt the user for the Celsius temperature 
    II.     Get the number that is the celsius temperature from the user
    III.    Convert the celsius temperature to Fahrenheit temperature 
    IV.     Provide the Fahrenheit temperature back to the user 

 */

using System;
namespace CelciusToFahrenheit
{
  class Program
  {
    static void Main(string[] args)
    {

        // I.      Prompt the user for the Celsius temperature 

            Console.Write("Please enter the Degree Celsius between 1 and 150 ");

        // II.     Get the number that is the celsius temperature from the user

            double degreesCelcius = Convert.ToDouble(Console.ReadLine());

        // III.    Convert the number of feet to the number of inches 

            double degreesFahrenheit = degreesCelcius *9/5 + 32;
         

        // IV.     Provide the number of inches back to the user 

            Console.WriteLine("The Degrees Fahrenheit is " + degreesFahrenheit );


    } // end Main
  } // end Program 
} // end Namespace