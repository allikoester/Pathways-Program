namespace RestaurantApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing the default constructor. ");
            Restaurant rest1 = new Restaurant();
            Console.WriteLine(rest1.RestaurantName);
            Console.WriteLine(rest1.RestaurantRating);

            Console.WriteLine("Testing the overload constructor. ");
            Restaurant rest2 = new Restaurant("Blue Sushi", 4);
            Console.WriteLine(rest2.RestaurantName);
            Console.WriteLine(rest2.RestaurantRating);

            Console.WriteLine(" ");

            Burgers rest3 = new Burgers("Honest Abe's", 4, "Greatest Burger Ever");
            Console.WriteLine(rest3);




        } // end Main
    } // end class
} // end namespace 