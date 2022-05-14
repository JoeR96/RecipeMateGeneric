using Microsoft.EntityFrameworkCore;
using RecipeMateModels.Models.Recipe;

namespace RecipeMatePersistence.Persistence
{
    public class RecipeContext : DbContext
    {
        public RecipeContext(DbContextOptions<RecipeContext> options)
            : base(options)
        {
        }

        public DbSet<Recipe> Items { get; set; }
    }
}
