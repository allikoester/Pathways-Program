namespace RecipeListAPI.Models
{
    public class RecipeListDTO
    {

        public long Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public int People { get; set; }

        public bool IsComplete { get; set; }

        public double Cost { get; set; } 
    }
}
