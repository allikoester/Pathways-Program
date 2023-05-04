/*

Developer Name: Alli Koester
Last Update: 3/17/23

Program: Store up to 25 restaurants and their star rating in a text file. Provide menu of options to open user's list of restaurants, 
    save list of restaurants, add a restaurant and rating, print list of restaurants and ratings, update list of restaurants, delete a restaurant, 
    and quit the program. 

Requirments: 
(1) Input will come from the user console
(2) Restaurant intput will be string
(3) Rating input will be an integer between 0 and 5

Algorithm: 
I. Declare variables
II. Do 
    A. Do 
        i. Provide user with menu options
        ii. Get user option choice
        iii. Validate user option choice
    B. While input is invalid
    C. If option choice is 'Open'
        i. Declare variables
        ii. Open text file using streamReading
            a. Declare variables
            b. Write to the console the file is open
            c. Write to console the text file and load into arrays
    D. Else if the option is 'Save'
        i. Declare variables
        ii. Open text file using streamWriter 
        iii. Foreach restaurant name in restaurant array and foreach restaurant rating in rating array
            a. Write to text file 
            b. For each restaurant name in restaurant array
            a. If empty space
                I. Prompt user to input new restaurant name
                II. Get new restaurant name from the user
                III. Prompt user to input new restaurant rating
                IV. Get new restaurant rating from the user
            b. If no empty space, provide error
    F. Else is the option is 'Print'
        i. For each name and rating
            a. If the space is not null
                I. Print out restaurant name and rating
            b. If there are no restaurants/ratings listed
                I. Provide error
    G. Else is the option is 'Update' 
        i. Prompt user for name of restaurant
        ii. Get name of restaurant from user
            a. If restaurant is in array 
                I. What does user want to change restaurant name to
                II. Assign integer number to variable
                III. What does user want to change rating to
            b. If not error
    F. Else if the options is 'Delete'
        i. Prompt user for name of restaurant
        ii. Get name of restaurant from user
            a. If restaurant is in array 
                I. Delete restaurant name
                II. Delete rating
            b. If not error
    H. Else the option is 'Quit' 


*/

namespace RestaurantArray
{
    class Program
    {
        static void Main(string[] args)
        {

            // I. Declare variables
            bool userChoice;
            string userChoiceString;
            string[] restaurants = new string[25];
            int[] ratings = new int[25];
            const string FileName = "restaurants.txt";

            // II. Do 
            do
            {

                // A. Do
                do
                {

                    // i. Provide user with menu options
                    Console.WriteLine("What's your pleasure? ");
                    Console.WriteLine("O: Open the data file into an array.");
                    Console.WriteLine("S: Save the array to the data file.");
                    Console.WriteLine("C: Add a name to the array.");
                    Console.WriteLine("R: Read a name from the array.");
                    Console.WriteLine("U: Update a name in the array.");
                    Console.WriteLine("D: Delete a name from the array.");
                    Console.WriteLine("Q: Quit the program.");

                    // ii. Get user option choice
                    userChoiceString = Console.ReadLine();

                    // iii. Validate user option choice
                    userChoice = CheckInput(userChoiceString, new string[] { "o", "s", "c", "r", "u", "d", "q" });

                    if (!userChoice)
                    {
                        Console.WriteLine("Please enter a valid option.");
                    }

                    // B. While input is invalid
                } while (!userChoice);

                //  C. If option choice is 'Open'

                if (CheckInput(userChoiceString, new string[] { "o" }))

                {
                    Console.WriteLine("In the O/o area");

                    // i. Declare variables
                    int index = 0;

                    // ii. Open text file using streamReading
                    using var sr = File.OpenText(FileName);
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

                            restaurants[index] = restaurantName;
                            ratings[index] = restaurantRating ?? 0;
                            index++;
                        }
                        Console.WriteLine(" ");
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
                    {

                        // iii. Foreach restaurant name in restaurant array 
                        while ((restaurants[index] != null))
                        {
                            sw.WriteLine(restaurants[index]);
                            sw.WriteLine(ratings[index]);

                            index++;
                        }
                    }
                    Console.WriteLine("Text file saved. ");
                    Console.WriteLine("");
                }

                // E. Else if the option is 'Add' if there is room
                else if (CheckInput(userChoiceString, new string[] { "c" }))
                {
                    Console.WriteLine("In the C/c area");

                    // i. Declare variables
                    string newName;
                    int newRating;
                    bool foundOne = false;

                    // ii. For each restaurant name in restaurant array

                    for (int index = 0; index < restaurants.Length; index++)


                    {
                        // a. If empty space
                        if (string.IsNullOrEmpty(restaurants[index]))
                        {
                            // I. Prompt user to input new restaurant name
                            Console.WriteLine("Please enter new restaurant name. ");
                            // II. Get new restaurant name from the user
                            newName = Console.ReadLine();
                            // III. Assign to index
                            restaurants[index] = newName;
                            do
                            {
                                // I. Prompt user to input new restaurant rating
                                Console.WriteLine("Please enter new restaurant rating from 0 to 5. ");
                                // II. Get new restaurant rating from the user
                                newRating = Convert.ToInt32(Console.ReadLine());
                                if ((newRating < 0) || (newRating > 5))
                                {
                                    Console.WriteLine("Please enter a valid number");
                                }
                            }
                            while ((newRating < 0) || (newRating > 5));
                            ratings[index] = newRating;
                            foundOne = true;
                            break;
                        }
                    }

                    // b. If no empty space, provide error
                    if (!foundOne)
                    {
                        Console.WriteLine("Index if full. ");
                        Console.WriteLine(" ");
                    }
                }

                //  F. Else is the option is 'Print'
                else if (CheckInput(userChoiceString, new string[] { "r" }))
                {
                    Console.WriteLine("In the R/r area");

                    // i. For each name and rating
                    for (int index = 0; index < restaurants.Length; index++)
                    {
                        // a. If the space is not null
                        if (!string.IsNullOrEmpty(restaurants[index]))
                        {
                            // I. Print out restaurant name and rating
                            Console.WriteLine(restaurants[index]);
                            Console.WriteLine(ratings[index]);
                        }

                    }
                    // b. If there are no restaurants/ratings listed
                    if (restaurants.Length == 0)
                    {
                        // I. Provide error
                        Console.WriteLine("There are no restaurants in the list. ");
                    }
                }

                // G. Else is the option is 'Update' 
                else if (CheckInput(userChoiceString, new string[] { "u" }))
                {
                    Console.WriteLine("In the U/u area");

                    // i. Prompt user for name of restaurant
                    Console.WriteLine("Please enter name of restaurant to update. ");

                    // ii. Get name of restaurant from user
                    string restaurantEntered = Console.ReadLine();
                    bool foundOne = false;

                    var restaurantList = restaurants.ToList();
                    var foundRestrauant = restaurantList.FirstOrDefault(x => x == restaurantEntered);

                    for (int index = 0; index < restaurants.Length; index++)
                    {
                        // a. If restaurant name is in array 
                        if (restaurants[index].ToUpper().Trim() == restaurantEntered.ToUpper().Trim())
                        {
                            // I. What does user want to change restaurant name to
                            Console.WriteLine("What would you like to update name to? ");
                            string restaurantUpdated = Console.ReadLine();
                            restaurants[index] = restaurantUpdated;

                            // c. What does user want to change rating to
                            Console.WriteLine("What would you like to update rating to? ");
                            int ratingEntered = Convert.ToInt32(Console.ReadLine());
                            ratings[index] = ratingEntered;

                            foundOne = true;
                            break;
                        }
                    }
                    // b. If not error
                    if (!foundOne)
                    {
                        Console.WriteLine("Name entered does not match a name on the list. ");
                    }
                }

                // F. Else if the options is 'Delete'
                else if (CheckInput(userChoiceString, new string[] { "d" }))
                {
                    Console.WriteLine("In the D/d area");

                    // i. Prompt user for name of restaurant
                    Console.WriteLine("Please enter name of restaurant to delete. ");

                    // ii. Get name of restaurant from user
                    string restaurantEntered = Console.ReadLine();
                    bool foundOne = false;

                    for (int index = 0; index < restaurants.Length; index++)
                    {
                        // a. If restaurant is in array 
                        if (restaurants[index] == restaurantEntered)
                        {
                            // II. Delete restaurant name
                            restaurants[index] = string.Empty;
                            // III. Delete rating
                            ratings[index] = -1;

                            foundOne = true;
                            break;
                        }
                    }
                    // b. If not, error
                    if (!foundOne)
                    {
                        Console.WriteLine("Name entered does not match a name on the list. ");
                    }

                }

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
    }  // end program
}  // end namespace