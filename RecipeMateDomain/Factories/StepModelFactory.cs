using RecipeMateModels.Models.Step;
using RecipeMateModels.RequestModels.Equipment;
using RecipeMateModels.RequestModels.Ingredient;

namespace RecipeMateDomain.Factories
{
    public static class StepModelFactory
    {
        public static StepModel CreateStepModel(string step, List<IngredientModel> ingredients, List<EquipmentModel> equipment)
        {
            return new StepModel
            {
                Step = step,
                Ingredients = ingredients,
                Equipment = equipment              
            };
        }
    }
}
