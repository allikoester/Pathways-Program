using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe
{
    internal class Bake :Recipe
    {

            public string CookingType { get; set; }

            public string CookingDuration { get; set; }

            public Bake(string cookingType, string cookingDuration, string recipeName, string recipeDescription)
                : base(recipeName, recipeDescription)
            {
                CookingType = cookingType;
                CookingDuration = cookingDuration;
            }

            public override string ToString()
            {
                return base.ToString()
                    + $", and is cooked in the {CookingType} for {CookingDuration}";
            }
        } // end class
    } // end namespace
