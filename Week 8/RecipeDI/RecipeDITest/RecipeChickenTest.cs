using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeDITest
{
    [TestClass]
    public class RecipeChickenTest
    {
        [TestMethod]
        public void Chicken_CalculateCostOfMeal_GetCost()
        {
            // Arrange
            var faker = new Faker();
            var people = faker.Random.Number(500);

            // Act
            var chicken = new RecipeDI.Chicken();
            double actualCost = chicken.CalculateCostOfMeal(people);

            // assert
            Assert.AreEqual(people * 5.5, actualCost);
        }
    }
}