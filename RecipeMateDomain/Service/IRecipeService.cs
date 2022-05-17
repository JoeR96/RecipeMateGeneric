using RecipeMateModels.Models.Recipe;
using RecipeMateModels.ViewModels.Recipe;

namespace RecipeMateDomain.Service
{
    public interface IRecipeService
    {
        Task<string> AddRecipeAsync(string userId, string text, CancellationToken cancellationToken);

        Task<bool> DeleteRecipeAsync(string userId, Guid itemId, CancellationToken cancellationToken);

        //Task<RecipeModel?> GetAsync(string userId, Guid itemId, CancellationToken cancellationToken);

        //Task<RecipeListViewModel> GetListAsync(string userId, CancellationToken cancellationToken);
    }
}