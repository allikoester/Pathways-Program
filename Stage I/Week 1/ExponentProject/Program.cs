/*
Developer Name: Alli Koester
Last Update: 3/9/23

Program Description: Obtain a base and low and high exponents from the user to determine every expontential value between low and high 
    exponent. Continue until user want to quit. 

Requirements: 
    (1)    The input will come from user via console, and the output will be to the user
    (2)    The numbers will be integers greater than or equal to 1
    (3)    High exponent will be greater than low exponent 

Algorithm: 
    A. Do
        I.      Obtain base number
        II.     Obtain low exponent
        III.    Obtain high exponent 
        IV.     For each exponent from low exponent to high exponent
            i. Output/print base to the exponent using Power method
        V.      Prompt user  -- do you want to continue? y to continue, anything else to close
    B. While user wants to continue
*/

namespace ExponentProject
{
  class Program
  {

/*
Method description: Obtain a valid integer within input range
    Requirements: 
        (1) The input will come from user via console, and the output will be to the user
        (2) The prompt for the user will be a string passed to the method
        (3) The number will be determined valid or invalid and returned
    Algorithm: 
        I. Assign integer
        II.   Do 
            a.  Prompt the user for the number
            b.  Get the number from the user
            c.  If the number is invalid (<1 or >100)
                i.  Provide error message
            While number is invalid 
        III. Return number
*/

    static int GetAValidInteger(string prompt, int lowRange) 
    {
        // I. Assign integer
            int x = 0;
        
        // II. Do
            do
                {
            // a.  Prompt the user for the number
                Console.Write(prompt + "greater than or equal to " + lowRange + ": ");
            // b.  Get the number from the user
                x = Convert.ToInt32(Console.ReadLine());
            // c.  If the number is invalid (<1 or >100)
                if (x < lowRange)
                {
                // i.  Provide error message
                    Console.WriteLine("Value must be greater than or equal to " + lowRange);
            }
        
            } // end do  
            while (x < lowRange);

            //. Return value 
            return x;
            

    } // end of Method

    /*
    Method Description: Take base number to power of exponent

    */

    static double PowerMethod(int baseNumber, int exponent)
    {
        double newValue = Math.Pow(baseNumber, exponent);
        return newValue;
    }
  

    static void Main(string[] args)
    {
            char userResponse;
            int baseNumber; 
            int lowExponent; 
            int highExponent; 
            double newValue; 
        

        // A.   Do 
            do
            {
                // I.      Obtain base number
                    baseNumber = GetAValidInteger("Please enter base number ", 1);
                // II.     Obtain low exponent
                    lowExponent = GetAValidInteger("Please enter low exponent ", 1);
                // III.    Obtain high exponent 
                    highExponent = GetAValidInteger("Please enter high exponent that is greater than the low exponent ", lowExponent);
                    
                // IV.     For each exponent from low exponent to high exponent
                    var j = lowExponent;
                    for (int i = 0; i <= (highExponent - j); j++)
                    {
                        newValue = PowerMethod(baseNumber, j);
                        Console.WriteLine(newValue);
                   
                    }

                    // i. Output/print base to the exponent using Power method

                // V.      Prompt user  -- do you want to continue? y to continue, anything else to close
                    Console.WriteLine("Would you like to end? (y) ");
                    userResponse = Convert.ToChar(Console.ReadLine());
            } // end do 
            // while 
                while (userResponse != 'y'); 
       
        // B. While user wants to continue



    } //end Main
    

  } // end class 
} // end namespace


