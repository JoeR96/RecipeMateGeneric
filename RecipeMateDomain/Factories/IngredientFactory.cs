using RecipeMateModels.Models.Recipe;
using RecipeMateModels.Models.Units;

namespace RecipeMateDomain.Factories
{
    public static class IngredientFactory
    {
        public static IIngredient<Unit> CreateIngredient(Measurements m, decimal quantity )
        {
            IIngredient<Unit> ingredient = m switch
            {
                Measurements.Gram => new Ingredient<Gram>(),
                Measurements.Milliliter => new Ingredient<Milliliter>(),
                Measurements.Tablespoon => new Ingredient<Tablespoon>(),
                Measurements.Teaspoon => new Ingredient<Teaspoon>(),
                Measurements.Cup => new Ingredient<Cup>(),
                _ => throw new NotImplementedException()
            };
            ingredient.Quantity = quantity;
            return ingredient;
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
