using System;
namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {

            int h;
            int b;

            do
            {
                string line = (Console.ReadLine());
                string[] hb = line.Split(' ');
                h = Convert.ToInt32(hb[0]);
                b = Convert.ToInt32(hb[1]);

                if ((h < 1) || (h > 1000))
                {
                    Console.WriteLine("Please enter number between 1 and 1000, inclusively ");
                }
                if ((b < 1) || (b > 1000))
                {
                    Console.WriteLine("Please enter number between 1 and 1000, inclusively ");
                }

            } // end do 
            while ((h < 1) && (h > 1000) && (b < 1) && (b > 1000));

            double triangleArea = (h * b) / 2;
            double finalArea = Math.Round(triangleArea, 7);
            Console.Write(finalArea);

        } // end Main
    } // end class
} // end namespace