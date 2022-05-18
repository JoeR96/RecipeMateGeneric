using RecipeMateModels.RequestModels.Equipment;
using RecipeMateModels.RequestModels.Ingredient;

namespace RecipeMateModels.Models.Step
{
    public class StepModel
    {
        public string Step { get; set; }
        public List<IngredientModel> Ingredients { get; set; }
        public List<EquipmentModel> Equipment { get; set; }
    }
}
