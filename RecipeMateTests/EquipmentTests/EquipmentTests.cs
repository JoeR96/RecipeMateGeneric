using FluentAssertions;
using RecipeMateDomain.Factories;
using RecipeMateModels.RequestModels.Equipment;

namespace RecipeMateTests.EquipmentTests
{
    [TestFixture]
    public class EquipmentTests
    {
        [Test]
        public void CreateEquipment()
        {
            var equipmentModel = new EquipmentModel
            {
                Name = "Knife"
            };

            var result = EquipmentFactory.CreateEquipment(equipmentModel);
            result.Name.Should().Be("Knife");
        }
    }
}
