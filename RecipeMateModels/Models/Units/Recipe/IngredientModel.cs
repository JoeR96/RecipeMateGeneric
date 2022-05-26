using System.ComponentModel.DataAnnotations;

namespace RecipeMateModels.RequestModels.Ingredient
{
    public class IngredientModel
    {
        [Required]
        public string UnitType { get; set; }
        [Required]
        public bool IsRecipe { get; set; } = false;
        [Required]
        public string Name { get; set; }
        public long? RecipeId { get; set; }
        public decimal Quantity { get; set; }
    }
}
