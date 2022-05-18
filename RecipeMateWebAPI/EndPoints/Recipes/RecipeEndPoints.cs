using FluentValidation;
using RecipeMateDomain.Service;
using RecipeMateModels.Models.Recipe;

namespace RecipeMateWebAPI.EndPoints.Recipes
{
    public static class RecipeEndPoints
    {
        public static void MapGuitarEndpoints(this WebApplication app)
        {
            app.MapPost("/recipe/create", CreateAsync);
            //app.MapGet("/recipe/{id}", ReadAsync);
            //app.MapGet("/recipe", ReallAllAsync);
            //app.MapPut("/recipe", UpdateAsync);
            //app.MapDelete("/recipe/{id}", DeleteAsync);
        }

        public static void AddGuitarServices(this WebApplicationBuilder builder, string repositoryImplementation)
        {
            builder.Services.AddScoped<IRecipeService, RecipeService>();
            builder.Services.AddScoped<IRecipeService, RecipeService>();
        }

        public async static Task<IResult> CreateAsync(IRecipeService recipeService, IValidator<RecipeModel> validator, RecipeModel recipe)
        {
            var validationResult = validator.Validate(recipe);
            if (!validationResult.IsValid)
            {
                return Results.BadRequest(new { errors = validationResult.Errors.Select(x => x.ErrorMessage) });
            }

            recipe = await recipeService.AddRecipeAsync(recipe);
            return Results.Created($"/recipe/{recipe.Id}", recipe);
        }
    }
}
