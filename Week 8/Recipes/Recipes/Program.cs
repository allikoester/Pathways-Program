/*
 
Developer Name: ALli Koester
Last Update: 4/25/23

Program: Create a list of recipes of different types. 
    Provide menu for user to view recipes, add to recipes

Algorithm: 
I. Create List
II. Add accounts to list 
III. Do 
    A. Do
        i. Provide user with menu options
        ii. Get user option choice
        iii. Validate user option 
    B. While input is invalid
    C. Is option is 'List' 
        i. Foreach account
            a. Print to console
    D. Else option is 'Add' 
        i. Do
            a. Prompt user for new recipe name 
            b. Get new recipe
            c. Validate recipe
            While recipe is in list
        ii. Prompt/get new recipe type
        iii. Prompt/get new recipe cooking instructions
        iv. Add to list 
    while option is not quit

*/

using System.Collections.Generic;

namespace Recipe
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userChoice;
            string? userChoiceString;
            string? recipeName;
            string? recipeDescription;
            string? cookingType;
            string? cookingDuration;

            //I.Create List
            //II. Add accounts to list 
            List<Recipe> recipeList = new List<Recipe>
            {
                new Bake("oven","25 minutes", "Herbed Chicken", "Chicken marinated with oil and herbs"),
                new StoveTop("stove top", "30 minutes", "Beef Tacos", "Ground beef cooked with onions, peppers, and spices"), 
                new CrockPot("crock pot", "6-8 hours", "Pork Chops", "Pork chops with creamy rice and veggies")
            };

            //III. Do 
            do
            {
                //    A. Do
                do
                {
                    //        i. Provide user with menu options
                    Console.WriteLine("Choose from following options: ");
                    Console.WriteLine("Press 'L' to list all recipes. ");
                    Console.WriteLine("Press 'A' to add a new recipe. ");
                    Console.WriteLine("Press'Q' to quit the program. ");

                    //        ii. Get user option choice
                    userChoiceString = Console.ReadLine();
                    //        iii. Validate user option 
                    userChoice = CheckInput(userChoiceString, new string[] { "l", "a", "q" });
                    if (!userChoice)
                    {
                        Console.WriteLine("Please enter a valid option. ");
                    }
                } // end do for valid option input
                //    B. While input is invalid
                while (!userChoice);

                //    C. If option is 'List' 
                if (CheckInput(userChoiceString, new string[] { "l" }))
                {
                    //        i. Foreach account
                    //            a. Print to console
                    foreach (Recipe recipe in recipeList)
                    {
                        Console.WriteLine(recipe.ToString());
                    }
                    Console.WriteLine(" ");

                } // end if 'List'

                //    D. Else option is 'Add' 
                if (CheckInput(userChoiceString, new string[] { "a" }))
                {
                    int index;
                    //        i. Do
                    do
                    {
                        //            a. Prompt user for new recipe name
                        Console.WriteLine("Please enter a new recipe name. ");
                        //            b.Get new recipe
                        recipeName = Console.ReadLine();
                        //            c.Validate recipe
                        if (recipeName == null)
                        {
                            Console.WriteLine("Please enter a valid recipe name. ");
                        }

                        index = FindIndex(recipeName, recipeList);
                        if (index != -1)
                        {
                            Console.WriteLine("Recipe name is already in use. Please enter a new recipe name. ");
                        }
                    }
                    //            While recipe is in list
                    while (index != -1 || recipeName == null);

                    //        ii. Prompt/get new recipe description
                    do
                    {
                        Console.WriteLine("Please enter a brief description. ");
                        recipeDescription = Console.ReadLine(); 
                        if(string.IsNullOrEmpty(recipeDescription))
                        {
                            Console.WriteLine("Please enter a valid description. ");
                        }
                    } while (string.IsNullOrEmpty(recipeDescription));

                    do
                    {
                        Console.WriteLine("Please enter cooking time. ");
                        cookingDuration = Console.ReadLine();
                        if (string.IsNullOrEmpty(cookingDuration))
                        {
                            Console.WriteLine("Please enter a valid description. ");
                        }
                    } while (string.IsNullOrEmpty(cookingDuration));

                    //        iii.Prompt / get new recipe cooking instructions
                    do
                    {
                        Console.WriteLine("Select a cooking type. ");
                        Console.WriteLine("Press 'B' for bake in the oven. ");
                        Console.WriteLine("Press 'S' for stove top. ");
                        Console.WriteLine("Press 'C' for crock pot. ");

                        userChoiceString = Console.ReadLine();
                        userChoice = CheckInput(userChoiceString, new string[] { "b", "s", "c" });
                        if (!userChoice)
                        {
                            Console.WriteLine("Please enter a valid option.");
                        }
                    } while (!userChoice);

                    if (CheckInput(userChoiceString, new string[] { "b" }))
                    {
                        cookingType = "oven";
                        Recipe newRecipe = new Bake(cookingType, cookingDuration, recipeName, recipeDescription);
                        recipeList.Add(newRecipe);
                        Console.WriteLine(newRecipe.ToString());
                    }

                    else if (CheckInput(userChoiceString, new string[] { "s" }))
                    {
                        cookingType = "stove top";
                        Recipe newRecipe = new StoveTop(cookingType, cookingDuration, recipeName, recipeDescription);
                        recipeList.Add(newRecipe);
                        Console.WriteLine(newRecipe.ToString());
                    }

                    else if (CheckInput(userChoiceString, new string[] { "c" }))
                    {
                        cookingType = "crock pot";
                        Recipe newRecipe = new CrockPot(cookingType, cookingDuration, recipeName, recipeDescription);
                        recipeList.Add(newRecipe);
                        Console.WriteLine(newRecipe.ToString());
                    }
                    Console.WriteLine(" ");

                } // end else 'Add'
            } // end do for program
            //    while option is not quit
            while (!(userChoiceString == "Q") && !(userChoiceString == "q"));


        } // end Main 

        static bool CheckInput(string? input, string[] validValues)
        {
            if (string.IsNullOrEmpty(input)) return false;

            for (int i = 0; i < validValues.Length; i++)
            {
                if (validValues[i].ToUpper() == input.ToUpper()) return true;
            }
            return false;
        } // end CheckInput method

        static int FindIndex(string recipeName, List<Recipe> recipeList)
        {
            int index = -1;
            index = recipeList.FindIndex(recipe => recipe.RecipeName == recipeName);
            return index;
        }
    } // end class
} // end namespace