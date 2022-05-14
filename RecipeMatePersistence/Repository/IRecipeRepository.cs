using RecipeMateModels.Models.Recipe;

namespace RecipeMatePersistence.Repository
{
    public interface IRecipeRepository
    {
        Task<Recipe> AddRecipeAsync(string userId, string text, CancellationToken cancellationToken = default);

        Task<Recipe?> GetRecipeAsync(string userId, Guid itemId, CancellationToken cancellationToken = default);
        Task<bool> DeleteRecipeAsync(string userId, Guid itemId, CancellationToken cancellationToken = default);
        Task<IList<Recipe>> GetRecipesAsync(string userId, CancellationToken cancellationToken = default);



    }
}