using RecipeMateModels.RequestModels.Equipment;

namespace RecipeMateDomain.Factories
{
    public static class EquipmentModelFactory
    {
        public static EquipmentModel CreateEquipmentModel(string name)
        {
            return new EquipmentModel
            {
                Name = name
            };
        }
    }
}
