using FluentAssertions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using RecipeMateDomain.Service;
using RecipeMateModels.Models.Recipe;
using RecipeMateTests.Builders;
using RecipeMateWebAPI.EndPoints.Recipes;
using RecipeMateWebAPI.Validator;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace RecipeMateTests.RecipeTests
{
    [TestFixture]
    public class RecipeApiTests
    {
        [Test]
        public async Task CreateSuccesfulAsync()
        {
            var mockHttpContext = CreateMockHttpContext();
            var recipe = new RecipeModel
            {
                UserId = "Bzzt",
                Steps = new()
                {
                    new StepModelBuilder()
                    .WithEquipment("Knife")
                    .WithIngredient("Onion", 1)
                    .Build()
                },
                Ingredients = new()
                {
                    new IngredientModelBuilder()
                   .WithName("Onion")
                   .WithQuantity(1)
                   .WithUnitType("Gram")
                   .Build()
                }
            };

            var recipeService = new Mock<IRecipeService>();

            recipeService.Setup(x => x.AddRecipeAsync(It.IsAny<RecipeModel>())).ReturnsAsync(recipe);
            var result = await RecipeEndPoints.CreateAsync(recipeService.Object, new RecipeValidator(), recipe);
            await result.ExecuteAsync(mockHttpContext);

            mockHttpContext.Response.Body.Position = 0;
            var jsonOptions = new JsonSerializerOptions(JsonSerializerDefaults.Web);
            var responseRecipe = await JsonSerializer.DeserializeAsync<RecipeModel>(mockHttpContext.Response.Body, jsonOptions);

            mockHttpContext.Response.StatusCode.Should().Be(201);
            responseRecipe.Steps.Count.Should().Be(1);
            responseRecipe.Ingredients.Count.Should().Be(1);
        }

        private static HttpContext CreateMockHttpContext() =>
    new DefaultHttpContext
    {
        // RequestServices needs to be set so the IResult implementation can log.
        RequestServices = new ServiceCollection().AddLogging().BuildServiceProvider(),
        Response =
        {
            // The default response body is Stream.Null which throws away anything that is written to it.
            Body = new MemoryStream(),
        },
    };
    }
}
