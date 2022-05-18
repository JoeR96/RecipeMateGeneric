using RecipeMateModels.Models.Units;

namespace RecipeMateModels.Models.Recipe
{
    public interface IStep<out T> where T : Unit
    {
        public string Instruction { get; set; }
        public List<Equipment> Equipment { get; set; }
        public List<IIngredient<Unit>> Ingredients { get; set; }
        public TimeOnly Time { get; set; }
    }

    public class Step<T> : IStep<T> where T : Unit
    {

        public string Instruction { get; set; }
        public List<Equipment> Equipment { get; set; } = new List<Equipment>();
        public List<IIngredient<Unit>> Ingredients { get; set; }
        public TimeOnly Time { get; set; }
    }

   
}