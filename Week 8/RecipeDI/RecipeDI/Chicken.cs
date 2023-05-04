using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeDI
{
    public class Chicken : ConsoleService, IRecipe
    {
        public void GetNewRecipe()
        {
            string newRecipe = GetNewRecipeName("Enter name of new chicken recipe.");
            string newDescription = GetNewRecipeDescription();
            int people = GetNumberOfPeople();
            double cost = CalculateCostOfMeal(people);
            ConsoleLogRecipe(newRecipe, newDescription, cost, people);
        }

        public double CalculateCostOfMeal(int people)
        {
            double cost = people * 5.5;
            ConsoleCost(cost);
            return cost;
        }

    }
}
