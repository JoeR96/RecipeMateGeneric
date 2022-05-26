using System.ComponentModel.DataAnnotations;

namespace RecipeMateModels.Models.Recipe
{
    public class Equipment
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}