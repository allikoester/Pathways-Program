using Bogus;

namespace RecipeDITest
{
    [TestClass]
    public class RecipeBeefTest
    {
        [TestMethod]
        public void Beef_CalculateCostOfMeal_GetCost()
        {
            // Arrange
            var faker = new Faker();
            var people = faker.Random.Number(500);

            // Act
            var beef = new RecipeDI.Beef();
            double actualCost = beef.CalculateCostOfMeal(people);

            // assert
            Assert.AreEqual(people * 8.5, actualCost);
        }
    }
}