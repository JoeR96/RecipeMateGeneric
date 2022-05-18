using RecipeMateModels.Models.Recipe;
using RecipeMatePersistence.Repository;

namespace RecipeMateDomain.Service
{
    public class RecipeService : IRecipeService
    {
        public RecipeService(IRepository<Recipe> repository)
        {
            Repository = repository;
        }
        private IRepository<Recipe> Repository { get; }

        public Task<RecipeModel> AddRecipeAsync(RecipeModel model)
        {//await Repository.Insert();
            //await Repository.Save();
            throw new NotImplementedException();
        }

        public Task<bool> DeleteRecipeAsync(string userId, Guid itemId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
