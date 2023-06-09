﻿namespace RecipeApi.Models
{
    public class RecipeDTO
    {
        public long Id { get; set; }

        public string? Name { get; set; }

        public string? Description { get; set; }

        public bool IsComplete { get; set; }
    }
}
