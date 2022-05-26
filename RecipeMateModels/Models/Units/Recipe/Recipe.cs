
using RecipeMateModels.Models.Units;
using System.ComponentModel.DataAnnotations;

namespace RecipeMateModels.Models.Recipe
{
    public class Recipe : Entity
    {
        [Key]
        public long Id { get; set; }
        public string UserId { get; set; }
        public TimeOnly PrepTime { get; set; }
        public TimeOnly CookTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<IIngredient<Unit>> Ingredients = new();
        public List<IStep<Unit>> Steps = new();
        public List<Equipment> Equipment { get; set; } = new();
    }
}
