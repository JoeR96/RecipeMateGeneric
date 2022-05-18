using RecipeMateModels.Models.Recipe;

namespace RecipeMateDomain.Factories
{
    public static class EquipmentFactory
    {
        public static Equipment CreateEquipment(string name)
        {
            return new Equipment
            {
                Name = name
            };
        }
    }

}
