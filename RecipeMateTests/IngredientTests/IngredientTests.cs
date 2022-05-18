using RecipeMateDomain.Factories;
using RecipeMateModels.Models.Recipe;
using RecipeMateModels.Models.Units;
using System.Collections;
using FluentAssertions;

namespace RecipeMateTests.IngredientTests
{
    [TestFixture]
    public class IngredientTests
    {
        [TestCaseSource(typeof(IngredientTestData), nameof(IngredientTestData.IsRecipeTestCases))]
        public bool IngredientIsRecipe(long recipe)
        {       
            Ingredient<Unit> ingredient = new ();
            ingredient.RecipeId = recipe;

            return ingredient.IsRecipe;
        }
        [TestCaseSource(typeof(IngredientTestData), nameof(IngredientTestData.CreateIngredientTestCases))]
        public IIngredient<Unit> CreateIngredient(Measurements m, decimal quantity)
        {
            return IngredientFactory.CreateIngredient(m, quantity);
        }
    }

    public class IngredientTestData
    {
        public static IEnumerable IsRecipeTestCases
        {
            get
            {
                yield return new TestCaseData(null).Should().Be(false);
                yield return new TestCaseData(1).Should().Be(true);
            }
        }

        public static IEnumerable CreateIngredientTestCases
        {
            get
            {
                yield return new TestCaseData( Measurements.Teaspoon, 50m).Should().Be(typeof(IIngredient<Teaspoon>));

            }
        }
    }
}
