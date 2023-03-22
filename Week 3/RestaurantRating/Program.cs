
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
            Restaurant rest2 = new Restaurant("Freddy's", 4);
            Console.WriteLine(rest2.RestaurantName);
            Console.WriteLine(rest2.RestaurantRating);

            Console.WriteLine("Initializing array of restaurants. ");
            Restaurant[] restaurantArray = new Restaurant[25];

            Console.WriteLine("Initializing each element of array of restaurants. ");
            for (int i = 0; i < 25; i++)
            {
                Restaurant temp = new Restaurant();
                restaurantArray[i] = temp;
            }

            Console.WriteLine("Printing array of restaurants. ");
            foreach (Restaurant rest in restaurantArray)
            {
                if ((rest.RestaurantName != " "))
                {
                    Console.WriteLine(rest.RestaurantName);
                    Console.WriteLine(rest.RestaurantRating);
                }

            }

            Console.WriteLine("Test the get/set");
            restaurantArray[17].RestaurantName = "Freddy's";
            restaurantArray[17].RestaurantRating = 4;

            Console.WriteLine("Printing array of restaurants. ");
            foreach (Restaurant rest in restaurantArray)
            {
                if ((rest.RestaurantName != " "))
                {
                    Console.WriteLine(rest.RestaurantName);
                    Console.WriteLine(rest.RestaurantRating);
                }
            }

            Console.WriteLine("Getting data from data file. ");
            int index = 0;

            // ii. Open text file using streamReading
            using var sr = File.OpenText("restaurants.txt");
            {
                // a. Declare variables
                string? restaurantName;
                int? restaurantRating;

                // b. Write to the console the file is open
                Console.WriteLine(" Here is the content of the file restaurants.txt : ");

                // c. Write to console the text file and load into arrays
                while (((restaurantName = sr.ReadLine()) != null) && (restaurantRating = Convert.ToInt32(sr.ReadLine())) != null)
                {
                    Console.WriteLine(restaurantName);
                    Console.WriteLine(restaurantRating);

                    restaurantArray[index].RestaurantName = restaurantName;
                    restaurantArray[index].RestaurantRating = restaurantRating ?? 0;
                    index++;
                }
                Console.WriteLine(" ");
            }

            foreach (Restaurant rest in restaurantArray)
            {
                if ((rest.RestaurantName != " "))
                {
                    Console.WriteLine(rest.RestaurantName);
                    Console.WriteLine(rest.RestaurantRating);
                }
            }

            foreach (Restaurant rest in restaurantArray)
            {
                if ((rest.RestaurantName != " "))
                {
                    Console.WriteLine(rest);
                }
            }

        } // end Main
    } // end class Program
}