using RecipeMateDomain.Factories;
using RecipeMateModels.Models.Recipe;
using RecipeMateModels.Models.Units;
using RecipeMateModels.RequestModels.Equipment;
using RecipeMateModels.RequestModels.Ingredient;

namespace RecipeMateTests.Builders
{
    public class StepBuilder :
    Builder<Step<Unit>, StepBuilder>
    {
        private Step<Unit> step;

        protected override StepBuilder This
        {
            get { return this; }
        }

        public override Step<Unit> Build()
        {
            return step;
        }

        public StepBuilder WithIngredient(string unitType,decimal quantity) 
        {
            var ingredient = IngredientFactory.CreateIngredient(new IngredientModel
            {
                UnitType = unitType,
                Quantity = quantity,
            });
            step.Ingredients.Add(ingredient);

            return This;
        }

        public StepBuilder WithEquipment(string name)
        {
            var equipmentModel = new EquipmentModel
            {
                Name = name,
            };

            var equipment = EquipmentFactory.CreateEquipment(equipmentModel);
            step.Equipment.Add(equipment);

            return This;
        }
    }
}
