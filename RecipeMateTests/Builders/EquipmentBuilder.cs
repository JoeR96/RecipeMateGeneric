using RecipeMateDomain.Factories;
using RecipeMateModels.Models.Recipe;
using RecipeMateModels.RequestModels.Equipment;

namespace RecipeMateTests.Builders
{
    public class EquipmentBuilder :
    Builder<Equipment, EquipmentBuilder>
    {
        private EquipmentModel _name;

        protected override EquipmentBuilder This
        {
            get { return this; }
        }

        public override Equipment Build()
        {
            return EquipmentFactory.CreateEquipment(_name);
        }

        public EquipmentBuilder WithName(string name)
        {

            _name.Name = name;
            return This;
        }
    } 
}
