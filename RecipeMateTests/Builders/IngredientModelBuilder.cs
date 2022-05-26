using RecipeMateDomain.Factories;
using RecipeMateModels.Models.Step;
using RecipeMateModels.Models.Units;
using RecipeMateModels.RequestModels.Ingredient;

namespace RecipeMateTests.Builders
{
    public class IngredientModelBuilder :
    Builder<IngredientModel, IngredientModelBuilder>
    {
        private IngredientModel ingredientModel = new IngredientModel();

        protected override IngredientModelBuilder This
        {
            get { return this; }
        }


        public IngredientModelBuilder WithName(string name)
        {
            ingredientModel.Name = name;
            return This;
        }
        public IngredientModelBuilder WithQuantity(decimal quantity)
        {
            ingredientModel.Quantity = quantity;
            return This;
        }
        public IngredientModelBuilder WithUnitType(string unit)
        {
            ingredientModel.UnitType = unit;
            return This;
        }
        public override IngredientModel Build()
        {
            return ingredientModel;
        }


    }
}
