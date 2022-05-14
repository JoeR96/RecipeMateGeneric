using FluentAssertions;
using RecipeMateDomain.Factories;
using RecipeMateModels.Models.Recipe;
using RecipeMateModels.Models.Units;
using System;
using System.Linq;

namespace RecipeMateTests.RecipeTests
{
    [TestFixture]
    public class CreateRecipeTests
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

            Step<Unit> pourSoupInToBowl = new();
            Equipment bowl = new Equipment();

            pourSoupInToBowl.Equipment.Add(bowl);
            pourSoupInToBowl.Instruction = "Pour Soup in to bowl";
            recipe.Steps.Add(pourSoupInToBowl);

            recipe.Steps.First().Equipment.Should().Contain(whisk);
            recipe.Steps.First().Should().Be(mixTomatoWithWater);
            recipe.Steps.First().Instruction.Should().Be("Combine ");

            recipe.Steps.Last().Equipment.Should().Contain(bowl);
            recipe.Steps.Last().Should().Be(pourSoupInToBowl);
            recipe.Steps.Last().Instruction.Should().Be("Pour Soup in to bowl");
        }
    }

    
}
