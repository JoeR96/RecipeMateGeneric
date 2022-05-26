using FluentAssertions;
using RecipeMateDomain.Factories;
using RecipeMateModels.Models.Recipe;
using RecipeMateModels.Models.Units;
using System.Collections;

namespace RecipeMateTests.IngredientTests
{
    public class IngredientTestData
    {
        public static IEnumerable IsRecipeTestCases
        {
            get
            {
                yield return new TestCaseData(null);
                yield return new TestCaseData(1);
            }
        }

        public static IEnumerable CreateIngredientTestCases
        {
            get
            {
                yield return new TestCaseData(Measurements.Teaspoon, 50m).Should().Be(typeof(IIngredient<Teaspoon>));

            }
        }
    }
}
