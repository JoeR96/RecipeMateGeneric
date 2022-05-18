using RecipeMateDomain.Factories;
using RecipeMateModels.Models.Recipe;
using RecipeMateModels.Models.Units;

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

        public StepBuilder WithIngredient(Measurements m,decimal quantity) 
        {
            var ingredient = IngredientFactory.CreateIngredient(m, quantity);
            step.Ingredients.Add(ingredient);

            return This;
        }

        public StepBuilder WithEquipment(string name)
        {
            var equipment = EquipmentFactory.CreateEquipment(name);
            step.Equipment.Add(equipment);

            return This;
        }
    }
}
