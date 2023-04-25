namespace Recipe
{
    class StoveTop : Recipe
    {
        public string CookingType { get; set; } 

        public string CookingDuration { get; set; } 

        public StoveTop(string cookingType, string cookingDuration, string recipeName, string recipeDescription) 
            : base(recipeName, recipeDescription)
        {
            CookingType = cookingType;
            CookingDuration = cookingDuration;  
        }

        public override string ToString()
        {
            return base.ToString()
                + $", and is cooked on the {CookingType} for {CookingDuration}";
        }
    } // end class
} // end namespace