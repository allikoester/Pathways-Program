using System;

namespace Demo
{
    class Program
    {
        public void test(ref int x, int y)
        {
            x = x + 1;
            y = y + 1;
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            /* local variable definition */
            int a = 99;
            int b = 110;

            Console.WriteLine("Before test, value of a : {0}", a);
            Console.WriteLine("Before test, value of b : {0}", b);

            /* calling a function to swap the values */
            p.test(ref a, b);

            Console.WriteLine("After test, value of a : {0}", a);
            Console.WriteLine("After test, value of b : {0}", b);

            Console.ReadLine();
        }
    }
}