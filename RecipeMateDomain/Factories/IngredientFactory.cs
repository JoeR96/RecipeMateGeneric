using RecipeMateDomain.Helpers;
using RecipeMateModels.Models.Recipe;
using RecipeMateModels.Models.Units;
using RecipeMateModels.RequestModels.Ingredient;

namespace RecipeMateDomain.Factories
{
    public static class IngredientFactory
    {
        public static IIngredient<Unit> CreateIngredient(IngredientModel ingredientModel)
        {
            var ingredient = CreateIngredientFromUnit(ingredientModel.UnitType);
            ingredient.Quantity = ingredientModel.Quantity;

            return ingredient;
        }



        //Old Scenario
        public static IIngredient<Unit> CreateIngredientFromUnit(string unitType)
        {
            Measurements m = EnumHelper.ParseEnum<Measurements>(unitType);
            return m switch
            {
                Measurements.Gram => new Ingredient<Gram>(),
                Measurements.Milliliter => new Ingredient<Milliliter>(),
                Measurements.Tablespoon => new Ingredient<Tablespoon>(),
                Measurements.Teaspoon => new Ingredient<Teaspoon>(),
                Measurements.Cup => new Ingredient<Cup>(),
                _ => throw new NotImplementedException()
            };

        }
    }

    public enum Measurements
    {
        Gram,
        Milliliter,
        Tablespoon,
        Teaspoon,
        Cup
    }
}
