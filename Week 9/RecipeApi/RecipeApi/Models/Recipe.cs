using Microsoft.EntityFrameworkCore;

namespace RecipeApi.Models
{
    public class Recipe
    {
        public long Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public bool IsComplete { get; set; }

        public string? Secret { get; set; } 
    }
}
