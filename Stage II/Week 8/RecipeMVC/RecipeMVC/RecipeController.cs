using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe
{
    internal class RecipeController
    {
        private RecipeView recipeView;
        private Recipe recipe;
        public RecipeController() 
        {
            Recipe recipe = new Recipe();
            var recipeList = recipe.GetRecipeList();
            recipeView = new RecipeView(recipeList);
            recipeView.GetOption();

        }

        

    } // end class
} // end namespace