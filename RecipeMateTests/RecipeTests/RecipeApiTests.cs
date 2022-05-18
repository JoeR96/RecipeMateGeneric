using Moq;
using RecipeMateDomain.Service;
using RecipeMateModels.Models.Recipe;
using RecipeMateModels.Models.Step;
using RecipeMateWebAPI.EndPoints.Recipes;
using RecipeMateWebAPI.Validator;
using System.Threading.Tasks;
using RecipeMateModels.RequestModels;
using RecipeMateModels.RequestModels.Ingredient;
using RecipeMateModels.RequestModels.Equipment;
using RecipeMateModels.Models.Units;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RecipeMateTests.RecipeTests
{
    [TestFixture]
    public class RecipeApiTests
    {
        [Test]
        public async Task CreateSuccesfulAsync()
        {
            var recipe = new RecipeModel
            {
                UserId = "Bzzt",
                Steps = new()
                {
                    new StepModel
                    {
                        Step = "Chop Onion",
                        Equipment = new()
                        {
                            new EquipmentModel
                            {
                                Name = "Knife"
                            }
                        },
                        Ingredients = new()
                        {
                            new IngredientModel
                            {
                                Name = "Onion" 
                            }
                        }
                    }
                },
                Ingredients = new()
                {
                    new IngredientModel
                    {
                        Name = "Onion"
                    }
                }
            };
            var recipeService = new Mock<IRecipeService>();

            recipeService.Setup(x => x.AddRecipeAsync(It.IsAny<RecipeModel>())).ReturnsAsync(recipe);

            //Task<IResult> result = await RecipeEndPoints.CreateAsync(recipeService.Object, new RecipeValidator(), recipe);
        }
    }
}
