using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipeListAPI.Models;

namespace RecipeListAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeListRecipesController : ControllerBase
    {
        private readonly RecipeListContext _context;

        public RecipeListRecipesController(RecipeListContext context)
        {
            _context = context;
        }

        // GET: api/RecipeListRecipes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RecipeListDTO>>> GetRecipeLists()
        {
          if (_context.RecipeLists == null)
          {
              return NotFound();
          }
            return await _context.RecipeLists.Select(x => RecipeListToDTO(x)).ToListAsync();
        }

        // GET: api/RecipeListRecipes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RecipeListDTO>> GetRecipeListRecipe(long id)
        {
          if (_context.RecipeLists == null)
          {
              return NotFound();
          }
            var recipeListRecipe = await _context.RecipeLists.FindAsync(id);

            if (recipeListRecipe == null)
            {
                return NotFound();
            }

            return RecipeListToDTO(recipeListRecipe);
        }

        // PUT: api/RecipeListRecipes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRecipeListRecipe(long id, RecipeListDTO recipeListDTO)
        {
            if (id != recipeListDTO.Id)
            {
                return BadRequest();
            }

            var recipeListRecipe = await _context.RecipeLists.FindAsync(id);
            if (recipeListRecipe == null)
            {
                return NotFound();
            }

            recipeListRecipe.Name = recipeListDTO.Name;
            recipeListRecipe.Description = recipeListDTO.Description;
            recipeListRecipe.People = recipeListDTO.People;
            recipeListRecipe.IsComplete = recipeListDTO.IsComplete;
            recipeListRecipe.Cost = GetCost(recipeListRecipe.People);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecipeListRecipeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/RecipeListRecipes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RecipeListDTO>> PostRecipeListRecipe(RecipeListDTO recipeListDTO)
        {
            var recipeListRecipe = new RecipeListRecipe
            {
                Name = recipeListDTO.Name,
                Description = recipeListDTO.Description,
                People = recipeListDTO.People,
                IsComplete = recipeListDTO.IsComplete,
                Cost = GetCost(recipeListDTO.People)
            };

            _context.RecipeLists.Add(recipeListRecipe);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetRecipeListRecipe), new { id = recipeListRecipe.Id }, RecipeListToDTO(recipeListRecipe));
        }

        // DELETE: api/RecipeListRecipes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecipeListRecipe(long id)
        {
            if (_context.RecipeLists == null)
            {
                return NotFound();
            }
            var recipeListRecipe = await _context.RecipeLists.FindAsync(id);
            if (recipeListRecipe == null)
            {
                return NotFound();
            }

            _context.RecipeLists.Remove(recipeListRecipe);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RecipeListRecipeExists(long id)
        {
            return (_context.RecipeLists?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        private static RecipeListDTO RecipeListToDTO(RecipeListRecipe recipeListRecipe) => new RecipeListDTO
        {
            Id = recipeListRecipe.Id,
            Name = recipeListRecipe.Name,
            Description = recipeListRecipe.Description,
            People = recipeListRecipe.People,
            IsComplete = recipeListRecipe.IsComplete,
            Cost = recipeListRecipe.Cost
        };

        public double GetCost(int people)
        {
            return people * 5.5;
        }
    }
}
