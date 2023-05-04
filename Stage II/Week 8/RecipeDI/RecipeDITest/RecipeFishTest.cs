using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeDITest
{
    [TestClass]
    public class RecipeFishTest
    {
        [TestMethod]
        public void Fish_CalculateCostOfMeal_GetCost()
        {
            // Arrange
            var faker = new Faker();
            var people = faker.Random.Number(500);

            // Act
            var fish = new RecipeDI.Fish();
            double actualCost = fish.CalculateCostOfMeal(people);

            // assert
            Assert.AreEqual(people * 6.25, actualCost);
        }
    }
}