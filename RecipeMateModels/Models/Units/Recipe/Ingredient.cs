using RecipeMateModels.Models.Units;

namespace RecipeMateModels.Models.Recipe
{
    public interface IIngredient<out T> where T : Unit
    {
        public long Id { get; set; }
        public long? RecipeId { get; set; }
        public decimal Quantity { get; set; }
        public bool IsRecipe { get; set; }
        public string Name { get; set; }

    }
    public class Ingredient<T> : IIngredient<T> where T : Unit
    {
        public string Name { get; set; }
        public long Id { get; set; }
        public long? RecipeId { get; set; } = 0;
        public decimal Quantity { get; set; }

        public bool IsRecipe
        {
            get { return IsRecipe; }
            set { IsRecipe = RecipeId == 0 ? false : value; }
        }
    }

    
}

  