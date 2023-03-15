/*

Developer Name: Alli Koester
Last Upate: 3/8/23

Description: User will input 10 values, determine average number, and average number will be reported back to user

Requirements:
    (1) The input will come from user via console, and the output will be to the user
    (2) The numbers will be integers between 1 and 100, inclusively

Algorithm: 
    I. Assign integer values
    II. For 10 times
        A. Do
            a. Prompt user for number
            b. Get number from user
            c. If number is invalid (<1 or >100)
                i. Provide error message
        B. While input is invalid
        C. Add input numbers together to obtain total value
        D. Obtain average number 
    III. Provide average number back to user 

*/

namespace AverageNumber 
{
  class Program
  {
    static void Main(string[] args)
    {

        // I. Assign integer values

            int userNumber = 0;
            int totalNumber = 0;
            int numberAverage; 

        // II. For 10 times

            for (int i=0; i <10; i++)
            {
        
            // A. Do
                do 
                {
                
                // a. Prompt user for number

                    Console.Write("Please enter a number ");

                // b. Get number from user

                    userNumber = Convert.ToInt32(Console.ReadLine());

                // c. If number is invalid (<1 or >100)

                    if ((userNumber < 0) || (userNumber > 100))
                    {
                
                    // i. Provide error message

                        Console.WriteLine("Please enter a number between 1 and 100, inclusively ");

                    } // end if -- error message 

                } // end do -- obtain valid number

            // B. While input is invalid

                while ((userNumber < 0) || (userNumber > 100));
         
         // C. Add input numbers together to obtain total value

               totalNumber = totalNumber + userNumber;

            } // end for 

                
                Console.WriteLine("The total number is: " + totalNumber);                

             // D.  Obtain average number 

                   numberAverage = totalNumber / 10;                 

        // III. Provide average number back to user 

            Console.WriteLine("The average number is: " + numberAverage);

    } // end Main
  } // end Program 
} // end Namespace
