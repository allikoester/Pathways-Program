namespace ShapesApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Test of Default ");
            Shapes shape1 = new Shapes();
            Console.WriteLine(shape1);

            Console.WriteLine("Test of overload ");
            Shapes shape2 = new Shapes(4.0, 7.0);
            Console.WriteLine(shape2);

            Console.WriteLine(" ");

            Rectangle shape3 = new Rectangle(3.5, 7.75);
            shape3.GetArea();
            Console.WriteLine(shape3);

            Triangle shape4 = new Triangle(5.25, 8.0, 4.5, 4.5);
            shape4.GetArea();
            Console.WriteLine(shape4);


        } // end Main
    } // end class
} // end namespace


