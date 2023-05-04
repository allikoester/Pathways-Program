using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMVC
{
    internal class CalcView
    { 
         public double GetValidNumber()
        {
            Console.WriteLine("Please input a number, then press enter.");
            string numberInput = Console.ReadLine();
            double number = 0;
            while (!double.TryParse(numberInput, out number))
            {
                Console.WriteLine("Not a valid input. Please enter a number. ");
                numberInput = Console.ReadLine();
            }
            return number;
        }

         public string SelectOperation()
        {
            string operation;
            do
            {
                Console.WriteLine("Choose an operation to perform:");
                Console.WriteLine("A -- Add");
                Console.WriteLine("S -- Subract");
                Console.WriteLine("M -- Multiply");
                Console.WriteLine("D -- Divide");

               operation = Console.ReadLine().ToLower();
                if (operation == "" && operation != "a" && operation != "s" && operation != "m" && operation != "d")
                {
                    Console.WriteLine("Please enter a valid input. ");
                }
            }
            while (operation == "" && operation != "a" && operation != "s" && operation != "m" && operation != "d");
            return operation;
        }

         public void DisplayResult(double result)
        {
            try
            {
                if (double.IsNaN(result))
                {
                    Console.WriteLine("Operation cannot be performed. ");
                }
                else
                    Console.WriteLine("Result is: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred. " + ex.Message);
            }
        }

        public bool QuitProgram()
        {
            bool exitApp = false;
            Console.WriteLine("Press 'Q' to quit the program. Any other key to continue. ");
            string inputToEnd = Console.ReadLine().ToLower();
            if (inputToEnd == "q")
            {
                exitApp = true;
            }
            return exitApp;
        }


    } // end class
} // end namespace
