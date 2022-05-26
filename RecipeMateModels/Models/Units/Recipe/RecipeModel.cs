using RecipeMateModels.Models.Step;
using RecipeMateModels.RequestModels.Equipment;
using RecipeMateModels.RequestModels.Ingredient;
using System.ComponentModel.DataAnnotations;

namespace RecipeMateModels.Models.Recipe
{
    public class RecipeModel
    {
        [Required]
        public string UserId { get; set; }
        public long Id { get; set; }
        public TimeOnly PrepTime { get; set; }
        public TimeOnly CookTime { get; set; }
        public List<IngredientModel> Ingredients { get; set; } = new();
        public List<StepModel> Steps { get; set; } = new();
        public List<EquipmentModel> Equipment { get; set; } = new();
    }
}
