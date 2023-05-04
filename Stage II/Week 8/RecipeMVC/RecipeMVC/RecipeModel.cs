using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe
{
    internal class RecipeModel
    {
        public string RecipeName { get; set; }

        public string RecipeDescription { get; set; }

        public string CookingType { get; set; }

        public double CookingTime { get; set; }

        public RecipeModel()
        {
            RecipeName = string.Empty;
            RecipeDescription = string.Empty;
            CookingType = string.Empty;
            CookingTime = 0;
        }

        public RecipeModel(string name, string description, string type, double time)
        {
            RecipeName = name;
            RecipeDescription = description;
            CookingType = type;
            CookingTime = time;
        }



    } // end class
} // end namespace
