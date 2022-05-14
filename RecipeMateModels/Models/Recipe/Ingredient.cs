using RecipeMateModels.Models.Units;

namespace RecipeMateModels.Models.Recipe
{
    public interface IIngredient<out T> where T : Unit
    {
        public long Id { get; set; }
        public Recipe Recipe { get; set; }
        public decimal Quantity { get; set; }
        public bool IsRecipe { get; set; }
    }
    public class Ingredient<T> : IIngredient<T> where T : Unit
    {
        public long Id { get; set; }
        public Recipe? Recipe { get; set; }
        public decimal Quantity { get; set; }

        public bool IsRecipe
        {
            get { return IsRecipe; }
            set { IsRecipe = Recipe == null ? false : value; }
        }
    }

    
}

