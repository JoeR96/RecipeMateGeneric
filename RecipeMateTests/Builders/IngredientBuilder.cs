using RecipeMateDomain.Factories;
using RecipeMateModels.Models.Recipe;
using RecipeMateModels.Models.Units;

namespace RecipeMateTests.Builders
{
    public class IngredientBuilder :
    Builder<Ingredient<Unit>, IngredientBuilder>
    {
        private Ingredient<Unit> ingredient;

        protected override IngredientBuilder This
        {
            get { return this; }
        }

        public override Ingredient<Unit> Build()
        {

            return ingredient;
        }

        public IngredientBuilder WithIngredient(Measurements m, decimal quantity)
        {

            return This;
        }
    }
}
