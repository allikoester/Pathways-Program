using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorMVC
{
    internal class CalcModel
    {
        private double number1;
        private double number2;
        private string operation;
        private double result; 

        public double Number1
        {
            get { return number1; }
            set { number1 = value; }
        }

        public double Number2
        {
            get { return number2; }
            set { number2 = value; }
        }

        public string Operation
        {
            get { return operation; }
            set { operation = value; }
        }

        public double Result
        {
            get { return result; }
            set { result = value; }
        }

        public CalcModel()
        {
            Number1 = 0;
            Number2 = 0;
            Operation = string.Empty;   
        }

        public CalcModel(double number1, double number2, string operation)
        {
            Number1 = number1;
            Number2 = number2;
            Operation = operation;
        }

        public double DoOperation()
        {
            Result = double.NaN;

            switch (operation)
            {
                case "a":
                    Result = Number1 + Number2;
                    break;
                case "s":
                    Result = Number1 - Number2;
                    break;
                case "m":
                    Result = Number1 * Number2;
                    break;
                case "d":
                    if (Number2 != 0)
                    {
                        Result = Number1 / Number2;
                    }
                    break;
                default:
                    break;
            }
            return Result;
        }



    }
}
