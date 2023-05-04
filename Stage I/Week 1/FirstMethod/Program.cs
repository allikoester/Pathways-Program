
/*
Developer name: Alli Koester
Last update: 3/8/23
*/

namespace FirstMethod
{
  class Program
  {

/*
Method description: Take number of feet given by user and return number of inches 
    Requirements: 
        (1) The input will come from user via console, and the output will be to the user
        (2)The number of feet will be an integer passed to the method
        (3) The number of inches will be calculated by taking the number of feet * 12 and returning that value
    Algorithm: 
        I. Return number of feet * 12
*/

    static int FeetToInches (int feet) 
    {
        return feet * 12; 
    } // end of Method

    /*
Program description: Main method is testing FeetToInches method
    */

    static void Main(string[] args)
    {

        Console.WriteLine(FeetToInches (10));

        int inches = FeetToInches (20); 
        Console.WriteLine(inches);

        inches = 5;
        Console.WriteLine(FeetToInches(inches));

    } //end Main
    

  } // end class 
} // end namespace