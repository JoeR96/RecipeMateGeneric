using RecipeMateModels.Models.Recipe;
using RecipeMateModels.Models.Units;

namespace RecipeMateDomain.Factories
{
    public static class IngredientFactory
    {
        public static IIngredient<Unit> CreateIngredient(Measurements m, decimal quantity )
        {
            return m switch
            {
                Measurements.Gram => new Ingredient<Gram>(quantity),
                Measurements.Milliliter => new Ingredient<Milliliter>(quantity),
                Measurements.Tablespoon => new Ingredient<Tablespoon>(quantity),
                Measurements.Teaspoon => new Ingredient<Teaspoon>(quantity),
                Measurements.Cup => new Ingredient<Cup>(quantity),
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
