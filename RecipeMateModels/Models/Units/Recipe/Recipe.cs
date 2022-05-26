
using RecipeMateModels.Models.Units;
using System.ComponentModel.DataAnnotations;

namespace RecipeMateModels.Models.Recipe
{
    public class Recipe : Entity
    {
        [Key]
        public long Id { get; set; }
        public string UserId { get; set; }
        public DateTime PrepTime { get; set; }
        public DateTime CookTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<IIngredient<Unit>> Ingredients = new();
        public List<IStep<Unit>> Steps = new();
        public List<Equipment> Equipment { get; set; } = new();
    }
}
