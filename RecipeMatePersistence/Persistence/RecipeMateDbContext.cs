using Microsoft.EntityFrameworkCore;
using RecipeMateModels.Models.Recipe;

namespace RecipeMatePersistence.Persistence
{
    public class RecipeMateDbContext : DbContext
    {
        public RecipeMateDbContext(DbContextOptions<RecipeMateDbContext> options)
            : base(options)
        {
        }

        public DbSet<Recipe> Recipes { get; set; }
    }
}
