using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe
{
    internal class RecipeView
    {
        public string RecipeName { get; set; }

        public string RecipeDescription { get; set; }

        public string CookingType { get; set; }

        public double CookingTime { get; set; }

        public List<Recipe> recipeList { get; set; }

        bool userChoice;
        string? userChoiceString;


        public RecipeView(List<Recipe> recipeList) 
        { 
            RecipeName = string.Empty;
            RecipeDescription = string.Empty;
            CookingType = string.Empty;
            CookingTime = 0;
            GetOption();
        }

        public string ToString()
        {
            return $"{RecipeName} is {RecipeDescription}, and cooks in the {CookingType} for {CookingTime} hours. ";
        }

        public void GetOption()
        {
            do
            {
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
                OptionList();
            }

            if (CheckInput(userChoiceString, new string[] { "a" }))
            {
                    OptionAdd();
            }
            } // end do for program
            //    while option is not quit
            while (!(userChoiceString == "Q") && !(userChoiceString == "q"));
        }

        public bool CheckInput(string? input, string[] validValues)
        {
            if (string.IsNullOrEmpty(input)) return false;

            for (int i = 0; i < validValues.Length; i++)
            {
                if (validValues[i].ToUpper() == input.ToUpper()) return true;
            }
            return false;
        } // end CheckInput method


        public void OptionList()
        {
            foreach (Recipe recipe in recipeList)
            {
                Console.WriteLine(recipe.ToString());
            }
            Console.WriteLine(" ");

        }

        public void OptionAdd()
        {

                    //            a. Prompt user for new recipe name
                    Console.WriteLine("Please enter a new recipe name. ");
                    //            b.Get new recipe
                    RecipeName = Console.ReadLine();
                    //            c.Validate recipe
                    if (RecipeName == null)
                    {
                        Console.WriteLine("Please enter a valid recipe name. ");
                    }


                //        ii. Prompt/get new recipe description
                do
                {
                    Console.WriteLine("Please enter a brief description. ");
                    RecipeDescription = Console.ReadLine();
                    if (string.IsNullOrEmpty(RecipeDescription))
                    {
                        Console.WriteLine("Please enter a valid description. ");
                    }
                } while (string.IsNullOrEmpty(RecipeDescription));

                    Console.WriteLine("Please enter cooking time. ");
                    CookingTime = double.Parse(Console.ReadLine());

                
                    Recipe newRecipe = new Recipe(RecipeName, RecipeDescription, CookingType, CookingTime);

            } // end else 'Add'

    } // end class
} // end namespace
