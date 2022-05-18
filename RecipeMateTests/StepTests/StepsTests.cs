using FluentAssertions;
using RecipeMateDomain.Factories;
using RecipeMateModels.Models.Step;
using RecipeMateModels.RequestModels.Equipment;
using RecipeMateModels.RequestModels.Ingredient;
using RecipeMateTests.Builders;
using System.Linq;

namespace RecipeMateTests.StepTests
{
    [TestFixture]
    public class StepsTests
    {
        [Test]
        public void CreateStep()
        {
            StepModel stepModel = new StepModelBuilder()
                .WithEquipment("Knife")
                .WithEquipment("Chopping Board")
                .WithIngredient("Onion", 1)
                .Build();
                
            var model = new StepModel
            {
                Step = "Dice Onions",
                Equipment = new()
                {
                    new EquipmentModel
                    {
                        Name = "Big Boy Knife"
                    },
                    new EquipmentModel
                    {
                        Name = "Chopping Board"
                    }
                },
                Ingredients = new()
                {
                    new IngredientModel
                    {
                        Name = "Onion",
                    }
                }
            };
            var result = StepFactory.CreateStep(model);
            result.Equipment.Count.Should().Be(2);
            result.Ingredients.Count.Should().Be(1);
            result.Equipment.First().Name.Should().Be("Big Boy Knife");
            result.Equipment.Last().Name.Should().Be("Chopping Board");
            result.Ingredients.First().Name.Should().Be("Onion");
        }
    }
}
