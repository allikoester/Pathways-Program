/*

Developer Name: Alli Koester
Last Update: 3/8/23

Description: Obtain 10 numbers from the user, determine minimum number, and provide user with minimum number

Requirements: 
   (1) The input will come from user via console, and the output will be to the user
   (2) The numbers will be integers between 1 and 10000, inclusively

Algorithm: 
   I. Assign integer values 
   I. For 10 times
       A. Do 
           a. Prompt user for number
           b. Get number from user 
           c. If number is invalid (<1 or >10000)
               i. Provid error message
       B. While number is invalid
       C. If number is less than current minimum 
           a. Current minimum becomes number
   II. Provide minimum number to user 

*/


namespace MinimumNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            // I. Assign integer values  

            int highNumber = 10001;
            int userNumber = 10001;
            int numberMinimum = 10001;
            bool validRange;

            // II. For 10 times
            for (int i = 0; i < 10; i++)
            {

                // A. Do 
                do
                {
                    // a. Prompt user for number

                    Console.Write("Please enter a number ");

                    // b. Get number from user 

                    userNumber = Convert.ToInt32(Console.ReadLine());

                    // c. If number is invalid (<1 or >10000)
                    validRange = ((userNumber >= 1) && (userNumber <= highNumber - 1));
                    if (!validRange)
                    {
                        // i. Provid error message

                        Console.WriteLine("Please enter a number between 1 and 10000, inclusively ");

                    } // end if -- error message

                } // end do -- obtain number

                // B. While number is invalid

                while (!validRange);

                // C. If number is less than current minimum 

                if (userNumber <= numberMinimum)
                {
                    // a. Current minimum becomes number

                    numberMinimum = userNumber;

                } // end if 
            } // end for

            // III. Provid minimum number to user 

            Console.WriteLine("The minimum number is " + numberMinimum);

        } // end Main
    } // end Program 
} // end Namespace
