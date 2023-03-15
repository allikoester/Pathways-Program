using System;

namespace QuadrantSelection
{
    class Program
    {
        static void Main(string [] args)
        {
            int x;
            int y; 
            int output = 0;

           // Console.WriteLine("Please enter the first number ");
            x = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Please enter the second number ");
            y = Convert.ToInt32(Console.ReadLine());

            if ((x >= 1) && (x <= 1000) && (y >= 1) && (y <= 1000))
            {
                output = 1;
            }
            else if ((x <= -1) && (x >= -1000) && (y <= -1) && (y >= -1000))
            {
                output = 3;
            }
            else if ((x <= -1) && (x >= -1000) && (y >= 1) && (y <= 1000))
            {
                output = 2;
            }
            else if ((x >= 1) && (x <= 1000) && (y <= -1) && (y >= -1000))
            {
                output = 4;
            }

            Console.WriteLine(output);
        }
    }
}