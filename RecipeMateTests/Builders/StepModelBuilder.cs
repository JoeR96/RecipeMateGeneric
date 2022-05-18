using RecipeMateDomain.Factories;
using RecipeMateModels.Models.Step;
using RecipeMateModels.Models.Units;

namespace RecipeMateTests.Builders
{
    public class StepModelBuilder :
    Builder<StepModel, StepModelBuilder>
    {
        private StepModel stepModel;

        protected override StepModelBuilder This
        {
            get { return this; }
        }

        public override StepModel Build()
        {
            return stepModel;
        }

        public StepModelBuilder WithIngredient(string name, decimal quantity)
        {
            var ingredient = IngredientModelFactory.CreateIngredientModel(name, quantity);
            stepModel.Ingredients.Add(ingredient);

            return This;
        }

        public StepModelBuilder WithEquipment(string name)
        {
            var equipment = EquipmentModelFactory.CreateEquipmentModel(name);
            stepModel.Equipment.Add(equipment);

            return This;
        }
    }
}
