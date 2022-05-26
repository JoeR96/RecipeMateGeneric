using RecipeMateModels.Models.Recipe;
using RecipeMateModels.RequestModels.Equipment;

namespace RecipeMateDomain.Factories
{
    public static class EquipmentFactory
    {
        public static Equipment CreateEquipment(EquipmentModel model)
        {
            return new Equipment
            {
                Name = model.Name,
            };
        }
    }

}
