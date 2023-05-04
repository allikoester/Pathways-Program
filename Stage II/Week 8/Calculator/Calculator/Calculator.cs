namespace CalculatorApp
{
    class Calculator
    {
  
        public double Number1 { get; set; }

        public double Number2 { get; set; }

        public Calculator()
        {
            Number1 = 0;
            Number2 = 0;
        }

        public double DoOperation(string operation)
        {
            double result = double.NaN;

            switch (operation)
            {
                case "a":
                    result = Number1 + Number2;
                    break;
                case "s":
                    result = Number1 - Number2;
                    break;
                case "m":
                    result = Number1 * Number2;
                    break;
                case "d":
                    if (Number2 != 0)
                    {
                        result = Number1 / Number2;
                    }
                    break;
                default:
                    break;
            }
            return result;
        }

    } // end class 

} // end namespace 
