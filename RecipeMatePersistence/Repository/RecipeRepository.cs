using Microsoft.EntityFrameworkCore;
using NodaTime;
using RecipeMateModels.Models.Recipe;
using RecipeMateModels.Models.Units;
using RecipeMatePersistence.Extension;
using RecipeMatePersistence.Persistence;

namespace RecipeMatePersistence.Repository;
public sealed class RecipeRepository : IRecipeRepository
{
    public RecipeRepository(RecipeContext context, IClock clock)
    {
        Clock = clock;
        Context = context;
    }


    private RecipeContext Context { get; }
    private IClock Clock { get; }

    public async Task<Recipe> AddRecipeAsync(
        List<IIngredient<Unit>> ingredients,
        List<IStep<Unit>> steps,
        string text,
        CancellationToken cancellationToken = default)
    {
        await EnsureDatabaseAsync(cancellationToken);

        var item = new Recipe
        {
            CreatedAt = UtcNow(),
            Ingredients = ingredients,
            Steps = steps,
        };

        Context.Add(item);

        await Context.SaveChangesAsync(cancellationToken);

        return item;
    }

    public async Task<bool> DeleteItemAsync(
        string userId,
        long itemId,
        CancellationToken cancellationToken = default)
    {
        var item = await GetRecipeAsync(userId, itemId, cancellationToken);

        if (item is null)
        {
            return false;
        }

        Context.Items.Remove(item);

        await Context.SaveChangesAsync(cancellationToken);

        return true;
    }

    public async Task<bool> DeleteRecipeAsync(string userId, Guid itemId, CancellationToken cancellationToken = default)
    {
        var item = await GetRecipeAsync(userId, itemId, cancellationToken);

        if (item is null)
        {
            return false;
        }

        Context.Items.Remove(item);

        await Context.SaveChangesAsync(cancellationToken);

        return true;
    }

    public async Task<Recipe?> GetRecipeAsync(
        string userId,
        long itemId,
        CancellationToken cancellationToken = default)
    {
        await EnsureDatabaseAsync(cancellationToken);

        var item = await Context.Items.FindItemAsync(itemId, cancellationToken);

        if (item is null || !string.Equals(item.UserId, userId, StringComparison.Ordinal))
        {
            return null;
        }

        return item;
    }

    public async Task<IList<Recipe>> GetRecipesAsync(
        string userId,
        CancellationToken cancellationToken = default)
    {
        await EnsureDatabaseAsync(cancellationToken);

        return await Context.Items
            .Where(x => x.UserId == userId)
            .OrderBy(x => x.Id)
            .ToListAsync(cancellationToken);
    }

    public Task GetRecipesAsync(string userId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    private async Task EnsureDatabaseAsync(CancellationToken cancellationToken)
        => await Context.Database.EnsureCreatedAsync(cancellationToken);

    private DateTime UtcNow() => Clock.GetCurrentInstant().ToDateTimeUtc();

}