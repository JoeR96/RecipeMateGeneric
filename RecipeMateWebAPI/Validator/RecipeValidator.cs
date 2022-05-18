using FluentValidation;
using RecipeMateModels.Models.Recipe;

namespace RecipeMateWebAPI.Validator
{

    public class RecipeValidator : AbstractValidator<RecipeModel>
    {
        public RecipeValidator()
        {
            RuleFor(x => x.Steps).NotEmpty().WithMessage("Step Required");
            RuleFor(x => x.UserId).NotEmpty().WithMessage("UserId Required");
            RuleFor(x => x.Ingredients).NotEmpty().WithMessage("Ingredients Required");
        }
    }
}
