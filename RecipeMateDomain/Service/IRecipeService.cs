
using RecipeMateModels.Models.Recipe;

namespace RecipeMateDomain.Service
{
    public interface IRecipeService 
    {
        public Task<RecipeModel> AddRecipeAsync(RecipeModel model);

        public Task<bool> DeleteRecipeAsync(string userId, Guid itemId, CancellationToken cancellationToken);

 
    }
}