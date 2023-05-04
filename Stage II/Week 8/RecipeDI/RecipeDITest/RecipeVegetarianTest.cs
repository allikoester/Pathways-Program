using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeDITest
{
    [TestClass]
    public class ReceipeVegetarianTest
    {
        [TestMethod]
        public void Vegetarian_CalculateCostOfMeal_GetCost()
        {
            // Arrange
            var faker = new Faker();
            var people = faker.Random.Number(500);

            // Act
            var vegetarian = new RecipeDI.Vegetarian();
            double actualCost = vegetarian.CalculateCostOfMeal(people);

            // assert
            Assert.AreEqual(people * 4.75, actualCost);
        }
    }
}