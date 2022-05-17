using RecipeMateDomain.Service;
using System.Security.Claims;

namespace RecipeMateWebAPI.EndPoints.Recipes
{
    public static class RecipeEndPoints
    {
        //public static IServiceCollection AddToApi(this IServiceCollection services)
        //{
        //    services.AddScoped<IRecipeRepository, RecipeRepository>();
        //    services.AddScoped<IRecipeService, RecipeService>();

        //    services.AddSingleton<IClock>(_ => SystemClock.Instance);
        //    services.AddDbContext<RecipeContext>((serviceProvider, options) =>
        //    {
        //        var configuration = serviceProvider.GetRequiredService<IConfiguration>();
        //        var dataDirectory = configuration["DataDirectory"];

        //        if (string.IsNullOrEmpty(dataDirectory) || !Path.IsPathRooted(dataDirectory))
        //        {
        //            var environment = serviceProvider.GetRequiredService<IHostEnvironment>();
        //            dataDirectory = Path.Combine(environment.ContentRootPath, "App_Data");
        //        }

        //        // Ensure the configured data directory exists
        //        if (!Directory.Exists(dataDirectory))
        //        {
        //            Directory.CreateDirectory(dataDirectory);
        //        }

        //        var databaseFile = Path.Combine(dataDirectory, "TodoApp.db");
        //        //change this to SQL DB when DB is created(seed?)
        //        options.UseSqlServer("Data Source=" + databaseFile);
        //    });

        //    return services;
        //});

               
        //}

        //public static IEndpointRouteBuilder MapTodoApiRoutes(this IEndpointRouteBuilder builder)
        //{
        //    builder.MapGet("/api/recipes", async (
        //        IRecipeService service,
        //        ClaimsPrincipal user,
        //        CancellationToken cancellationToken) =>
        //        {
        //            return await service.GetListAsync(user.GetUserId, cancellationToken);
        //        }
        //        )
        //        .RequireAuthorization();

        //}
    
    }
}
