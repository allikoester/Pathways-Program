namespace Recipe
{
    class Recipe
    {
        
        public string RecipeName { get; set; }  

        public string RecipeDescription { get; set;}

        public Recipe()
        {
            RecipeName = string.Empty;
            RecipeDescription = string.Empty;
        }

        public Recipe (string name, string description)
        {
            RecipeName = name;
            RecipeDescription = description;
        }

        public override string ToString()
        {
            return $"{RecipeName} is {RecipeDescription}";
        }

    } // end class
} // end namespace