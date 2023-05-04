/*

Developer name: Alli Koester
Last Update: 3/7/23

Description: This program will calculate appropriate medication dosage in miligrams based on weight by obtaining a value that is a 
    number of miligrams from user, obtaining a weight that is a number of pounds from user, converting number of pounds 
    to number of kilograms, and provide user with dosage number in miligrams.

Requirements: 
    (1) Income will come from the user via console, and output will be back to user
    (2) The medication dosage number that is miligrams will be a double between 1 and 100 inclusively 
    (3) The number that is pounds will be a double between 1 and 500 inclusively 
    (3) The number that is kilograms will be calculated by taking the input number / 2.205
    (4) The number that is the prescribed medication dosage will be calculated by taking medication dosage * number of kilograms

Algorithm: 
    I.      Prompt user for the weight based medication dose 
    II.     Get the weight based medication dose from user
    III.    Promt user for number of pounds of patient
    IV.     Get the number of pounds from user
    V.      Convert number of pounds to number of kilograms
    VI.     Calculate prescribed dose of medication 
    VII.    Provide prescribed medication dosage

*/

using System;
namespace MedDosing
{
  class Program
  {
    static void Main(string[] args)
    {

        // I.      Prompt user for the weight based medication dose 

            Console.WriteLine("Please enter weight based miligram of medication per kilogram between 1 and 100 ");

        // II.     Get the weight based medication dose from user

            double weightMgDose = Convert.ToDouble(Console.ReadLine());

        // III.    Promt user for number of pounds of patient

            Console.WriteLine("Please enter the number of pounds of patient between 1 and 500 ");

        // IV.      Get the number of pounds from user  

            double numPounds = Convert.ToDouble(Console.ReadLine());

        // V.       Convert number of pounds to number of kilograms

            double numKilograms = numPounds / 2.205;

        //VI.       Calculate prescribed dose of medication 

            double medDose = weightMgDose * numKilograms;

        // VII.      Provide prescribed medication dosage to user

            Console.WriteLine("The prescribed miligram of medication is " + medDose );


    } // end Main
  } // end Program 
} // end Namespace