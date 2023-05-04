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

        public Recipe()
        {
            RecipeName = string.Empty;
            RecipeDescription = string.Empty;
        }

        public Recipe(string name, string description)
        {
            RecipeName = name;
            RecipeDescription = description;
        }

        public override string ToString()
        {
            return $"{RecipeName} is {RecipeDescription}";
        }

    } // end class
} // end namespace
