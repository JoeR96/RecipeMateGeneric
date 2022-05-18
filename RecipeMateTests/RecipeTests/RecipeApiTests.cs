using Moq;
using RecipeMateDomain.Service;
using RecipeMateModels.Models.Recipe;
using RecipeMateWebAPI.EndPoints.Recipes;
using RecipeMateWebAPI.Validator;
using System.Threading.Tasks;

namespace RecipeMateTests.RecipeTests
{
    [TestFixture]
    public class RecipeApiTests
    {
        [Test]
        public async Task CreateSuccesfulAsync()
        {
            var recipe = new RecipeModel{};

            var recipeService = new Mock<IRecipeService>();
   

            recipeService.Setup(x => x.AddRecipeAsync(It.IsAny<RecipeModel>())).ReturnsAsync(recipe);

            var result = await RecipeEndPoints.CreateAsync(recipeService.Object, new RecipeValidator(), recipe);

        }
    }
}
