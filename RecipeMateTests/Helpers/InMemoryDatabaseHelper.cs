using Microsoft.EntityFrameworkCore;
using RecipeMateModels.Models;
using RecipeMatePersistence.Persistence;
using RecipeMatePersistence.Repository;

namespace RecipeMateTests
{
    public class TestHelper
    {
        private readonly RecipeMateDbContext recipeContext;
        public TestHelper()
        {
            var builder = new DbContextOptionsBuilder<RecipeMateDbContext>();
            builder.UseInMemoryDatabase(databaseName: "RecipeDbInMemory");

            var dbContextOptions = builder.Options;
            recipeContext = new RecipeMateDbContext(dbContextOptions);
            recipeContext.Database.EnsureDeleted();
            recipeContext.Database.EnsureCreated();
        }

        public IRepository<T> GetInMemoryRepository<T>() where T : Entity
        {
            return new Repository<T>(recipeContext);         
        }

     
    }
}


