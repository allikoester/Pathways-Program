/*
Developer name: Alli Koester
Last update: 3/9/23
*/

namespace GetAValidInteger
{
  class Program
  {

/*
Method description: Obtain a valid integer within input range
    Requirements: 
        (1) The input will come from user via console, and the output will be to the user
        (2) The prompt for the user will be a string passed to the method
        (3) The low value will be an integer passed to the method
        (4) The high value will be an integer passed to the method
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

    static int GetAValidInteger(string prompt, int lowNumber, int highNumber) 
    {
        // I. Assign integer
            int number; 
        
        // II. Do
            do
                {
            // a.  Prompt the user for the number
                Console.Write(prompt);
            // b.  Get the number from the user
                number = Convert.ToInt32(Console.ReadLine());
            // c.  If the number is invalid (<1 or >100)
                if ((number < lowNumber) || (number > highNumber))
                {
                // i.  Provide error message
                    Console.WriteLine("Please enter a number between " + lowNumber + " and " + highNumber);
                } // end if

            } // end do  
            while ((number < lowNumber) || (number > highNumber));

        // III. Return number
            return number;

    } // end of Method

    /*
Program description: Main method is testing GetAValidInteger method
    */

    static void Main(string[] args)
    {

        // I. Call the method
            int yards = GetAValidInteger("Please enter number of yards ", 5, 55); 
        // II. Return valid number to user 
            Console.WriteLine("The valid number is " + yards);

        // I. Call the method
            int inches = GetAValidInteger("Please enter number of inches ", 10, 700);
        // II. Return valid number to user 
            Console.WriteLine("The valid number is " + inches);

    } //end Main
    

  } // end class 
} // end namespace
