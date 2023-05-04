using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeDI
{
    public class ConsoleService
    {
        public string GetNewRecipeName(string prompt)
        {
            string newRecipe;
            do
            { 
            Console.WriteLine(prompt);  
            newRecipe = Console.ReadLine();
            if (string.IsNullOrEmpty(newRecipe))
            {
                Console.WriteLine("Please enter a new recipe name. ");
            }
        } while (string.IsNullOrEmpty(newRecipe));
            return newRecipe;
        }

        public string GetNewRecipeDescription()
        {
            string newDescription;
            do
            {
                Console.WriteLine("Enter brief description of recipe. ");
                newDescription = Console.ReadLine();
                if (string.IsNullOrEmpty(newDescription))
                {
                    Console.WriteLine("Please enter a brief description. ");
                }
            } while (string.IsNullOrEmpty(newDescription));

            return newDescription;
        }

        public int GetNumberOfPeople()
        {
            int people = 0;
            do
            {
                Console.WriteLine("How many people does the meal need to feed?");
                string peopleS = Console.ReadLine();

                while (!int.TryParse(peopleS, out people))
                {
                    Console.WriteLine("Not a valid input. ");
                    peopleS = Console.ReadLine();
                }

                if (people < 0)
                {
                    Console.WriteLine("Please enter a valid number. ");
                }
            } while (people < 0);
            return people;
        }

        public void ConsoleCost(double cost)
        {
            Console.WriteLine($"The total cost of the meal is ${cost}.");
        }

        public void ConsoleLogRecipe(string newRecipe, string newDescription, double cost, int people)
        {
            Console.WriteLine($"New recipe filed. \n{newRecipe} is {newDescription}, and will cost ${cost}, for {people} people.");
        }
    }
}
