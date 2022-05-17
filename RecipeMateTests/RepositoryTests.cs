using FluentAssertions;
using RecipeMateDomain.Factories;
using RecipeMateModels.Models;
using RecipeMateModels.Models.Recipe;
using RecipeMateModels.Models.Units;
using RecipeMatePersistence.Repository;
using System.Linq;

namespace RecipeMateTests
{
    [TestFixture]
    public class RepositoryTests
    {
        [Test]
        public void SaveAsyncRecipe()
        {
            var helper = new TestHelper();

            var repo = helper.GetInMemoryRepository<Recipe>();
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

            repo.Insert(recipe);
 
            var result = repo.GetById(recipe.Id);

            result.Should().NotBeNull();
            result.Steps.First().Equipment.Should().Contain(whisk);
            result.Steps.First().Should().Be(mixTomatoWithWater);
            result.Steps.First().Instruction.Should().Be("Combine ");

            result.Steps.Last().Equipment.Should().Contain(bowl);
            result.Steps.Last().Should().Be(pourSoupInToBowl);
            result.Steps.Last().Instruction.Should().Be("Pour Soup in to bowl");

        }
    }
}
