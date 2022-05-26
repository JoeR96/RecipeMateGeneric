using FluentAssertions;
using RecipeMateDomain.Factories;
using RecipeMateModels.Models.Step;
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
                .WithInstruction("Chop Onion")
                .Build();            
     
            var result = StepFactory.CreateStep(stepModel);

            result.Equipment.Count.Should().Be(2);
            result.Ingredients.Count.Should().Be(1);
            result.Instruction.Should().Be("Chop Onion");
            result.Equipment.First().Name.Should().Be("Knife");
            result.Equipment.Last().Name.Should().Be("Chopping Board");
            result.Ingredients.First().Name.Should().Be("Onion");
        }
    }
}
