/*

Developer Name: Alli Koester 
Update: 3/7/23

Program Description: Obtain 10 numbers from user, determine maximum number, and provide user with maximum number

Requirements: 
    (1)    The input will come from user via console, and the output will be to the user
    (2)    The numbers will be integers between 1 and 100, inclusively

Algorithm: 
    I.  Assign integer a negative value as current maximum 
    II. For 10 times:
        A.   Do 
            a.  Prompt the user for the number
            b.  Get the number from the user
            c.  If the number is invalid (<1 or >100)
                i.  Provide error message
            While number is invalid 
        B.  If number is greater than current maximum
            a.  Current maximum becomes number 
    III. Provide current maximum number to user 

*/

namespace MaximumNumber 
{
  class Program
  {
    static void Main(string[] args)
    {

        // I.  Assign integer a negative value as current maximum 
            
            int currentNum =-1;
            int finalMax =-1;

        // II. For 10 times:

            for (int i=0; i <10; i++)
            {

                // A.   Do 
                    do
                    {
                    // a.  Prompt the user for the number

                        Console.Write("Please enter number from 1 to 100 ");
                    
                    // b.  Get the number from the user

                        currentNum = Convert.ToInt32(Console.ReadLine());

                    // c.  If the number is invalid (<1 or >100)

                        if ((currentNum <= 0) || (currentNum >100))
                        {
                        // i.  Provide error message

                            Console.WriteLine("Please enter number between 1 and 100, inclusively "); 

                        } // end if input is valid

                    } // end do, enter number loop

                    // While number is invalid 

                    while ((currentNum <=0) || (currentNum >100));
                    
                // B.  If number is greater than current maximum
                    
                  if (currentNum >= finalMax)
                    {
                        // a.  Current maximum becomes number 
                            
                          finalMax = currentNum;

                    } // end if greater than max

            } // end for 
                    
        // III. Provide current maximum number to user

            Console.WriteLine("The maximum number is " + finalMax );

    } // end Main
  } // end Program 
} // end Namespace
