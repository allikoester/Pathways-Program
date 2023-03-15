using System;
namespace NumberOfPossilibities
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int T;
            int M;
            do
            {
                string line = (Console.ReadLine());
                string[] NMT = line.Split(' ');
                N = Convert.ToInt32(NMT[0]);
                M = Convert.ToInt32(NMT[1]);
                T = Convert.ToInt32(NMT[2]);

                if ((N < 1) || (N > 500))
                {
                    Console.WriteLine("Please enter number between 1 and 500, inclusively ");
                }
                if ((M < 1) || (M > 500))
                {
                    Console.WriteLine("Please enter number between 1 and 500, inclusively ");
                }
                if ((T < 1) || (T > 500))
                {
                    Console.WriteLine("Please enter number between 1 and 500, inclusively ");
                }
            }

            while ((N < 1) || (N > 500) && ((M < 1) || (M > 500)) && ((M < 1) || (M > 500)));
            int totalPossibilities = N * M * T;
            Console.Write(totalPossibilities);
        }
    }
}

