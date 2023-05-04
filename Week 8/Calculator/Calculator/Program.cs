
using System.Reflection;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            bool exitApp = false;
            string operation;

            Console.WriteLine("CALCULATOR APP\n\n");


            while (!exitApp)
            {
                calculator.Number1 = getValidNumber();
                calculator.Number2 = getValidNumber();

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
            
                try
                {
                    double result = calculator.DoOperation(operation);
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
            
                Console.WriteLine("Press 'Q' to quit the program. Any other key to continue. ");
                string inputToEnd = Console.ReadLine().ToLower();
                if (inputToEnd == "q")
                {
                    exitApp = true;
                }
                
            } // end while continuing program 
            return;

        } // end Main 

        static double getValidNumber()
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

       
    } // end class
} // end namespace