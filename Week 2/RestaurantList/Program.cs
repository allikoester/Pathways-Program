/*

Developer Name: Alli Koester
Last Update: 3/20/23

Program: Store up to 25 restaurants and their star rating in a text file. Provide menu of options to open user's list of restaurants, 
    save list of restaurants, add a restaurant and rating, print list of restaurants and ratings, update list of restaurants, delete a restaurant, 
    and quit the program. 

Requirments: 
(1) Input will come from the user console
(2) Restaurant and rating intput will be strings


Algorithm: 
I. Declare variables
II. Do 
    A. Do 
        i. Provide user with menu options
        ii. Get user option choice
        iii. Validate user option choice
    B. While input is invalid
    C. If option choice is 'Load'
        i. Open text file using streamReading
            a. Write to console the text file and load into list
    D. Else if the option is 'Save'
        i. Declare variables
        ii. Open text file using streamWriter 
        iii. Foreach restaurant and rating in list
            a. Write to text file 
    E. Else if the option is 'Add' 
        i. Prompt user to input new restaurant name
        ii. Get new restaurant name from the user
        iii. Prompt user to input new restaurant rating
        iv. Get new restaurant rating from the user
        v. Assign new input
        vi. Add new input to the list
    F. Else is the option is 'Print'
        i. For each name and rating on the list
        ii. Print out restaurant name and rating
    G. Else is the option is 'Update' 
        i. Prompt user for name of restaurant
        ii. Get name of restaurant from user
            a. If restaurant is in list 
                I. What does user want to change restaurant name to
                II. What does the user want to change rating to
                III. Remove old input from the list
                IV. Add updated input to the list
    F. Else if the options is 'Delete'
        i. Prompt user for name of restaurant and rating
        ii. Get name of restaurant and rating from user
            a. If restaurant is in list
                I. Delete restaurant and rating
            b.If not error
    H. Else the option is 'Quit' 


*/

namespace RestaurantList
{
    class Program
    {
        static void Main(string[] args)
        {

            // I. Declare variables
            bool userChoice;
            string userChoiceString;
            List<string> restaurants = new List<string>();
            const string FileName = "list.txt";

            // II. Do 
            do
            {

                // A. Do 
                do
                {

                    //  i. Provide user with menu options

                    Console.WriteLine("What's your pleasure? ");
                    Console.WriteLine("L: Load the data file into the list.");
                    Console.WriteLine("S: Save the list to the data file.");
                    Console.WriteLine("C: Add a restaurant and rating to the list.");
                    Console.WriteLine("R: Read a restaurant and rating from the list.");
                    Console.WriteLine("U: Update a restaurant and rating in the list.");
                    Console.WriteLine("D: Delete a restaurant and rating from the list.");
                    Console.WriteLine("Q: Quit the program.");

                    // ii. Get user option choice

                    userChoiceString = Console.ReadLine();

                    // iii. Validate user option choice
                    userChoice = CheckInput(userChoiceString, new string[] { "l", "s", "c", "r", "u", "d", "q" });

                    if (!userChoice)
                    {
                        Console.WriteLine("Please enter a valid option.");
                    }
                    // B. While input is invalid
                } while (!userChoice);

                //   C. If option choice is 'Load'
                if (CheckInput(userChoiceString, new string[] { "l" }))

                {
                    Console.WriteLine("In the L/l area");
                    // i. Open text file using streamReading
                    using (var sr = File.OpenText(FileName))
                    {
                        // a. Write to console the text file and load into list
                        Console.WriteLine(" Here is the content of the file list.txt : ");
                        string restaurantAndRating;
                        while ((restaurantAndRating = sr.ReadLine()) != null)
                        {
                            restaurants.Add(restaurantAndRating);
                        }
                        foreach (string s in restaurants)
                        {
                            Console.WriteLine(s);
                        }
                    }
                }

                // D. Else if the option is 'Save'
                else if (CheckInput(userChoiceString, new string[] { "s" }))
                {
                    Console.WriteLine("In the S/s area");

                    // i. Declare variables
                    int index = 0;

                    // ii. Open text file using streamWriter 
                    using var sw = File.CreateText(FileName);

                    // iii. Foreach restaurant and rating in restaurant list
                    foreach (string restaurantAndRating in restaurants)
                    {
                        if (!string.IsNullOrEmpty(restaurants[index]))
                        {// a. Write to text file 
                            sw.WriteLine(restaurantAndRating);
                        }
                    }

                    Console.WriteLine("Text file saved. ");
                    Console.WriteLine("");
                }

                //  E. Else if the option is 'Add' 
                else if (CheckInput(userChoiceString, new string[] { "c" }))
                {
                    Console.WriteLine("In the C/c area");

                    string? newRestaurant;
                    string? newRating;
                    // i. Prompt user to input new restaurant name
                    Console.WriteLine("Please enter new restaurant name. ");
                    // ii. Get new restaurant name from the user
                    newRestaurant = Console.ReadLine();
                    if (string.IsNullOrEmpty(newRestaurant))
                    {
                        Console.WriteLine("Please enter a valid restaurant name. ");
                    }
                    // iii. Prompt user to input new restaurant rating
                    Console.WriteLine("Please enter new restaurant rating. ");
                    // iv. Get new restaurant rating from the user
                    newRating = Console.ReadLine();
                    if (string.IsNullOrEmpty(newRating))
                    {
                        Console.WriteLine("Please enter a valid restaurant rating. ");
                    }
                    // v. Assign new input
                    string newInput = newRestaurant + ", " + newRating;
                    // vi. Add new input to the list
                    restaurants.Add(newInput);
                }

                // F. Else is the option is 'Print'
                else if (CheckInput(userChoiceString, new string[] { "r" }))
                {
                    Console.WriteLine("In the R/r area");
                    // i. For each name and rating on the list
                    foreach (string restaurantAndRating in restaurants)
                    {
                        // ii. Print out restaurant name and rating
                        Console.WriteLine(restaurantAndRating);
                    }
                }

                // G. Else is the option is 'Update' 
                else if (CheckInput(userChoiceString, new string[] { "u" }))
                {
                    Console.WriteLine("In the U/u area");

                    // i. Prompt user for name of restaurant
                    Console.WriteLine("Please enter name of restaurant and rating to update. ");
                    // ii. Get name of restaurant from user
                    string restaurantEntered = Console.ReadLine();

                    // a. If restaurant is in list 
                    int index = FindIndex(restaurantEntered, restaurants);
                    if (index == -1)
                    {
                        Console.WriteLine("Restaurant not found. ");
                    }
                    else
                    {
                        // I. What does user want to change restaurant name to
                        Console.WriteLine("What would you like to update restaurant name to? ");
                        string restaurantUpdated = Console.ReadLine();
                        // II. What does the user want to change rating to
                        Console.WriteLine("What would you like to update restaurant rating to? ");
                        string ratingUpdated = Console.ReadLine();

                        // III. Remove old input from the list
                        restaurants.Remove(restaurantEntered);

                        // IV. Add updated input to the list
                        string newInput = restaurantUpdated + ", " + ratingUpdated;
                        restaurants.Insert(index, newInput);
                    }

                }

                // F.Else if the options is 'Delete'






                else if (CheckInput(userChoiceString, new string[] { "d" }))
                {
                    Console.WriteLine("In the D/d area");

                    // i. Prompt user for name of restaurant and rating 
                    Console.WriteLine("Please enter name of restaurant and rating to delete. ");

                    // ii.Get restaurant and rating from user
                    string restaurantEntered = Console.ReadLine();

                    // a. If restaurant is in list
                    int index = FindIndex(restaurantEntered, restaurants);
                    // b.If not error
                    if (index == -1)
                    {
                        Console.WriteLine("Restaurant not found. ");
                    }
                    // I. Delete restaurant and rating
                    else
                    {
                        restaurants.Remove(restaurantEntered);
                    }
                }

                //  TODO: Else if the option is a Q or q then quit the program

                else
                {
                    Console.WriteLine("Good-bye!");
                }
            } while (!(userChoiceString == "Q") && !(userChoiceString == "q"));
        }  // end main

        static bool CheckInput(string? input, string[] validValues)
        {
            if (string.IsNullOrEmpty(input)) return false;

            for (int i = 0; i < validValues.Length; i++)
            {
                if (validValues[i].ToUpper() == input.ToUpper())
                {
                    return true;
                }
            }
            return false;
        }

        static int FindIndex(string nameEntered, List<string> restaurants)
        {
            // List<string> nameList = new List<string>();
            int index = -1;
            if (string.IsNullOrEmpty(nameEntered))
            {
                Console.WriteLine("Please enter a valid name. ");
            }
            else if (restaurants.Contains(nameEntered))
            {
                index = restaurants.IndexOf(nameEntered);
            }

            return index;
        }

    }  // end program
}  // end namespace
