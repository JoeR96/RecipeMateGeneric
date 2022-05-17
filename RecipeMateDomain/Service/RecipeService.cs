//using RecipeMateModels.Models;
//using RecipeMateModels.Models.Recipe;
//using RecipeMateModels.ViewModels.Recipe;
//using RecipeMatePersistence.Repository;

//namespace RecipeMateDomain.Service
//{
//    public class RecipeService : IRecipeService
//    {
//        public RecipeService(IRepository<Recipe> repository)
//        {
//            Repository = repository;
//        }
//        private IRepository<Recipe> Repository { get; }

//        public Task<string> AddRecipeAsync(string userId, string text, CancellationToken cancellationToken)
//        {
//            throw new NotImplementedException();
//        }


//        //public async Task<bool> DeleteRecipeAsync(
//        // string userId,
//        // Guid itemId,
//        // CancellationToken cancellationToken)
//        //{
//        //    return null;
//        //    //return await Repository.DeleteAsync(userId, itemId, cancellationToken);
//        //}

//        //public async Task<RecipeModel?> GetAsync(string userId, Guid itemId, CancellationToken cancellationToken)
//        //{
//        //    //var item = await Repository.GetRecipeAsync(userId, itemId, cancellationToken);

//        //    //if (item is null)
//        //    //{
//        //    //    return null;
//        //    //}

//        //    //return MapRecipe(item);
//        //    return null;
//        //}

//        //private RecipeModel? MapRecipe(Recipe receipe)
//        //{
//        //    return new RecipeModel
//        //    {
//        //        Id = receipe.Id,
//        //        PrepTime = receipe.PrepTime,
//        //        CookTime = receipe.CookTime,
//        //        CreatedAt = receipe.CreatedAt,
//        //        Ingredients = receipe.Ingredients,
//        //        Steps = receipe.Steps
//        //    };
//        //}

//        public Task GetListAsync(string userId, CancellationToken cancellationToken)
//        {
//            throw new NotImplementedException();
//        }

//        //Task<RecipeListViewModel> IRecipeService.GetListAsync(string userId, CancellationToken cancellationToken)
//        //{
//        //    throw new NotImplementedException();
//        //}
//    }
//}
