using FluentAssertions;
using RecipeMateDomain.Factories;
using RecipeMateModels.Models.Recipe;
using RecipeMateModels.Models.Units;
using System;
using System.Collections;
using System.Linq;

namespace RecipeMateTests.RecipeTests
{
    [TestFixture]
    public class RecipeTests
    {
        [Test]
        public void CreateRecipe()
        {
            IIngredient<Unit> Tomato = IngredientFactory.CreateIngredient(Measurements.Gram, 500);
            IIngredient<Unit> Water = IngredientFactory.CreateIngredient(Measurements.Milliliter, 500);

            Recipe recipe = new();

            recipe.Ingredients.Add(Tomato);
            recipe.Ingredients.Add(Water);

            Step<Unit> mixTomatoWithWater = new();
            Equipment whisk = new Equipment();

            mixTomatoWithWater.Equipment.Add(whisk);
            mixTomatoWithWater.Instruction = "Combine ";
            recipe.Steps.Add(mixTomatoWithWater);

        }

        [TestFixture]
        public class IngredientTests
        {
            [TestCaseSource(typeof(RecipeTestData), nameof(RecipeTestData.TestCases))]
            public void IngredientMeasurementIsCorrect(Ingredient<Unit> ingredient, decimal result)
            {
                ingredient.Quantity.Should().Be(500);

            }
        }

        public class RecipeTestData
        {
            public static IEnumerable TestCases
            {
                get
                {
                    yield return new TestCaseData(IngredientFactory.CreateIngredient(Measurements.Gram, 500), 500);
                    yield return new TestCaseData(new Recipe()).Returns(true);
                }
            }
        }
    }

    
}
