using Castle.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeDI
{
    internal class RecipeService
    {
        private readonly IRecipe _recipe;

        public RecipeService(IRecipe recipe)
        {
            _recipe = recipe;
        }

        public void GetNewRecipe()
        {
            _recipe.GetNewRecipe();
        }
    }
}
