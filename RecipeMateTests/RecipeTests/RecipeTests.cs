using RecipeMateDomain.Factories;
using RecipeMateModels.Models.Recipe;
using RecipeMateTests.Builders;

namespace RecipeMateTests.RecipeTests
{
    [TestFixture]
    public class RecipeTests
    {
        [Test]
        public void CreateRecipe()
        {
            RecipeModel recipeModel = new RecipeModel();

            //recipeModel.Ingredients = new List<Ingredient>()
            //{
            //    new IngredientBuilder().
            //}
            RecipeFactory.CreateRecipe(recipeModel);
        }   
    }

    
}
