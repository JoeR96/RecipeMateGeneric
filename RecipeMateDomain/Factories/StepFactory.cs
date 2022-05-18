using RecipeMateModels.Models.Recipe;
using RecipeMateModels.Models.Step;
using RecipeMateModels.Models.Units;
using RecipeMateModels.RequestModels.Ingredient;
using System.Collections.Generic;

namespace RecipeMateDomain.Factories
{
    public static class StepFactory
    {
        public static Step<Unit> CreateStep(StepModel model) 
        {
            return new Step<Unit>
            {
                Instruction = model.Step,
                Ingredients = MapIngredients(model),
                Equipment = MapEquipment(model)
            };
        }

        private static List<IIngredient<Unit>> MapIngredients(StepModel model)
        {
           return model.Ingredients.Select(x => new Ingredient<Unit>()
            {
                Name = x.Name,
                Quantity = x.Quantity,
                RecipeId = IsRecipe(x) ? 
                0 : x.RecipeId
            }).ToList().ConvertAll(o => (IIngredient<Unit>)o);

        }

        private static bool IsRecipe(IngredientModel x)
        {
            return x.RecipeId == null || x.RecipeId == 0;
        }

        private static List<Equipment> MapEquipment(StepModel model)
        {
            return model.Equipment.Select(x => new Equipment()
            {
                Name = x.Name
            }).ToList();
        }
    }


}
