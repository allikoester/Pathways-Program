namespace RecipeDI
{
    class Program
    {
        static void Main(string[] args)
        {

            IRecipe newRecipe = new Beef();
            RecipeService recipe1 = new RecipeService(newRecipe);
            recipe1.GetNewRecipe();

            IRecipe newRecipe2 = new Vegetarian();
            RecipeService recipe2 = new RecipeService(newRecipe2);
            recipe2.GetNewRecipe();

            IRecipe newRecipe3 = new Fish();
            RecipeService recipe3 = new RecipeService(newRecipe3);
            recipe3.GetNewRecipe();

            IRecipe newRecipe4 = new Chicken();
            RecipeService recipe4 = new RecipeService(newRecipe4);
            recipe4.GetNewRecipe();

        } // end Main
    } // end class
} // end namespace