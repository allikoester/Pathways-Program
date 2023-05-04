using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe
{
    internal class Recipe
    {
        public string RecipeName { get; set; }
        public string RecipeDescription { get; set; }
        public string CookingType { get; set; }

        public double CookingTime { get; set; }



        public Recipe()
        {
            RecipeName = string.Empty;
            RecipeDescription = string.Empty;
            CookingType = string.Empty;
            CookingTime = 0;
        }

        public Recipe(string name, string description, string type, double time)
        {
            RecipeName = name;
            RecipeDescription = description;
            CookingType = type;
            CookingTime = time;
        }
        public List<Recipe> GetRecipeList()
        {
            return new List<Recipe>
            {
                new Recipe("Herbed Chicken", "Chicken marinated with oil and herbs", "oven", 0.5),
                new Recipe("Beef Tacos", "Ground beef cooked with onions, peppers, and spices", "stove top", 0.75),
                new Recipe("Pork Chops", "Pork chops with creamy rice and veggies", "crock pot", 7)
            };
        }

        //public List<Recipe> AddToList()
        //{

        //}





    } // end class
} // end namespace
