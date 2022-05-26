using FluentAssertions;
using RecipeMateDomain.Factories;
using RecipeMateModels.Models.Recipe;
using RecipeMateModels.Models.Units;
using RecipeMateModels.RequestModels.Ingredient;
using RecipeMateTests.Builders;
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


            IngredientModel tomatoModel = new IngredientModelBuilder()
                .WithName("Tomato")
                .WithQuantity(500)
                .WithUnitType("Gram")
                .Build();

            IngredientModel waterModel = new IngredientModelBuilder()
                .WithName("Water")
                .WithQuantity(500)
                .WithUnitType("Milliliter")
                .Build();

            IIngredient<Unit> Tomato = IngredientFactory.CreateIngredient(tomatoModel);
            IIngredient<Unit> Water = IngredientFactory.CreateIngredient(waterModel);

            Recipe recipe = new();

            recipe.Ingredients.Add(Tomato);
            recipe.Ingredients.Add(Water);

            Step<Unit> mixTomatoWithWater = new();
            Equipment whisk = new EquipmentBuilder()
                            .WithName("Whisk")
                            .Build();
            mixTomatoWithWater.Equipment.Add(whisk);
            mixTomatoWithWater.Instruction = "Combine ";
            recipe.Steps.Add(mixTomatoWithWater);

            Step<Unit> pourSoupInToBowl = new();
            Equipment bowl = new EquipmentBuilder()
                .WithName("Bowl")
                .Build();

            pourSoupInToBowl.Equipment.Add(bowl);
            pourSoupInToBowl.Instruction = "Pour Soup in to bowl";
            recipe.Steps.Add(pourSoupInToBowl);

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
