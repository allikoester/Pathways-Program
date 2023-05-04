namespace RestaurantApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Testing default. ");
            Restaurant rest1 = new Restaurant();
            Console.WriteLine(rest1);

            Console.WriteLine(" ");

            Console.WriteLine("Testing overload");
            Restaurant rest2 = new Restaurant("Freddy's", 4);
            Console.WriteLine(rest2);

            Console.WriteLine("Please enter total bill amount. ");
            double totalBill = Convert.ToDouble(Console.ReadLine());
            double tip = rest2.CalculateTip(totalBill);
            Console.WriteLine("The tip is $" + tip);

            Console.WriteLine(" ");

            FineDining rest3 = new FineDining("JTK", 2);
            Console.WriteLine(rest3);

            Console.WriteLine("Please enter total bill amount. ");
            totalBill = Convert.ToDouble(Console.ReadLine());
            tip = rest3.CalculateTip(totalBill);
            Console.WriteLine("The tip is $" + tip);

            Console.WriteLine(" ");

            DiningIn rest4 = new DiningIn("Granite City", 1);
            Console.WriteLine(rest4);

            Console.WriteLine("Please enter total bill amount. ");
            totalBill = Convert.ToDouble(Console.ReadLine());
            tip = rest4.CalculateTip(totalBill);
            Console.WriteLine("The tip is $" + tip);

            Console.WriteLine(" ");

            TakeOut rest5 = new TakeOut("Taco Johns", 1);
            Console.WriteLine(rest5);

            Console.WriteLine("Please enter total bill amount. ");
            totalBill = Convert.ToDouble(Console.ReadLine());
            tip = rest5.CalculateTip(totalBill);
            Console.WriteLine("The tip is $" + tip);

            Console.WriteLine(" ");

            Restaurant[] restaurantArray = new Restaurant[10];
            restaurantArray[1] = rest1;
            Console.WriteLine(restaurantArray[1]);

            restaurantArray[2] = rest2;
            Console.WriteLine(restaurantArray[2]);

            restaurantArray[3] = rest3;
            Console.WriteLine(restaurantArray[3]);

            restaurantArray[4] = rest4;
            Console.WriteLine(restaurantArray[4]);

            restaurantArray[5] = rest5;
            Console.WriteLine(restaurantArray[5]);
            restaurantArray[5].Name = "Momo's";

            Console.WriteLine(restaurantArray[5]);
            Console.WriteLine(rest5);


        } // end Main
    } // end class
} // end namespace