using Microsoft.EntityFrameworkCore;

namespace RecipeListAPI.Models
{
    public class RecipeListContext : DbContext
    {
        public RecipeListContext(DbContextOptions<RecipeListContext> options) : base(options) { } 

        public DbSet<RecipeListRecipe> RecipeLists { get; set; } = null!;

    }
}
