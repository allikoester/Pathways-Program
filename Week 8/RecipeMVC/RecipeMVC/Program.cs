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

using Recipe;
using System.Collections.Generic;

namespace Recipe
{
    class Program
    {
        static void Main(string[] args)
        {
           

            RecipeController recipeController = new RecipeController();


        } // end Main 

        
    } // end class
} // end namespace
