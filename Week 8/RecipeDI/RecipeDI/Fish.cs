using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeDI
{
    public class Fish : ConsoleService, IRecipe
    {
        public void GetNewRecipe()
        {
            string newRecipe = GetNewRecipeName("Enter name of new fish recipe.");
            string newDescription = GetNewRecipeDescription();
            int people = GetNumberOfPeople();
            double cost = CalculateCostOfMeal(people);
            ConsoleLogRecipe(newRecipe, newDescription, cost, people);
        }

        public double CalculateCostOfMeal(int people)
        {

            double cost = people * 6.25;
            ConsoleCost(cost);
            return cost;
        }

    }
}
