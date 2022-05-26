using RecipeMateModels.Models.Recipe;

namespace RecipeMateDomain.Factories
{
    public static class RecipeFactory
    {
        public static Recipe CreateRecipe(RecipeModel recipeModel)
        {

            Recipe recipe = new Recipe();

            recipeModel.Ingredients.
                ForEach(x => recipe.Ingredients.Add(
                    IngredientFactory.CreateIngredient(x)));

            recipeModel.Steps.
                ForEach(x => recipe.Steps.Add(
                    StepFactory.CreateStep(x)));
            recipeModel.Equipment.
                ForEach(x => recipe.Equipment.Add(
                    EquipmentFactory.CreateEquipment(x)));

            return recipe;
        }
    }
}
