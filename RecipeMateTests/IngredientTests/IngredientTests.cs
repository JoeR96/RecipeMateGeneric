using RecipeMateModels.Models.Recipe;
using RecipeMateModels.Models.Units;
using System.Collections;

namespace RecipeMateTests.IngredientTests
{
    [TestFixture]
    public class IngredientTests
    {
        [TestCaseSource(typeof(IngredientTestData), nameof(IngredientTestData.TestCases))]
        public bool IngredientIsRecipe(Recipe recipe)
        {       
            Ingredient<Unit> ingredient = new ();
            ingredient.Recipe = recipe;

            return ingredient.IsRecipe;
        }
    }

    public class IngredientTestData
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(null).Returns(false);
                yield return new TestCaseData(new Recipe()).Returns(true);
            }
        }
    }
}
