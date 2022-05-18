using RecipeMateModels.RequestModels.Ingredient;

namespace RecipeMateDomain.Factories
{
    public static class IngredientModelFactory
    {
        public static IngredientModel CreateIngredientModel(string name, decimal quantity, long recipeId = 0)
        {
            return new IngredientModel
            {
                Name = name,
                Quantity = quantity,
                RecipeId = recipeId
            };
        }
    }
}
