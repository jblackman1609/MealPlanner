using MealPlanner.MealService.Application.Interfaces;
using MealPlanner.MealService.Domain.Entities;
using MealPlanner.MealService.Infrastructure.Contexts;
using MealPlanner.MealService.Infrastructure.Models;

namespace MealPlanner.MealService.Infrastructure.Repositories;

/// <summary>
/// Represents a repository responsible for managing meal entities within the meal planning application. This class 
/// implements the IMealRepository interface, providing an abstraction for adding meal entities to the underlying data 
/// store. The MealRepository class interacts with the SqlServerContext to persist meal data, allowing for efficient 
/// retrieval and management of meal entities within the system.
/// </summary>
public class MealRepository : IMealRepository
{
    /// <summary>
    /// Gets the instance of the SqlServerContext used for interacting with the underlying data store. This context
    /// provides the necessary methods for adding, updating, and retrieving meal entities, enabling the MealRepository 
    /// to persist meal data in a decoupled manner. The SqlServerContext is injected into the repository via the constructor, 
    /// allowing for flexible configuration and management of the data access layer.
    /// </summary>
    private readonly SqlServerContext _dbContext;

    /// <summary>
    /// Initializes a new instance of the MealRepository class with the specified SqlServerContext. This constructor allows
    /// for the injection of the database context, enabling the repository to interact with the underlying data store in a 
    /// decoupled manner. The SqlServerContext provides the necessary methods for managing meal entities, allowing the 
    /// MealRepository to persist meal data efficiently within the meal planning application.
    /// </summary>
    /// <param name="dbContext"></param>
    public MealRepository(SqlServerContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Asynchronously adds a new meal entity to the underlying data store. This method allows for the persistence of meal 
    /// entities, enabling other components of the system to interact with meal data in a decoupled manner. The AddAsync 
    /// method maps the provided Meal entity to a MealModel, which is then added to the Meals DbSet within the 
    /// SqlServerContext. Finally, the changes are saved to the database, ensuring that the meal data is persisted for 
    /// future retrieval and management.
    /// 
    /// </summary>
    /// <param name="meal"></param>
    /// <returns></returns>
    public async Task AddAsync(Meal meal)
    {
        _dbContext.Meals.Add(Map(meal));
        await _dbContext.SaveChangesAsync();
    }

    /// <summary>
    /// Maps a Meal entity to a MealModel, which is used for persisting meal data within the underlying data store.
    /// This method creates a new instance of the MealModel class, populating its properties with the corresponding values 
    /// from the provided Meal entity. The mapping process ensures that the meal data is correctly structured for storage in 
    /// the database, allowing for efficient retrieval and management of meal entities within the meal planning application.
    /// </summary>
    /// <param name="meal"></param>
    /// <returns></returns>
    private MealModel Map(Meal meal)
    {
        return new MealModel
        {
            Id = meal.Id.ToString(),
            MealType = meal.MealType.ToString(),
            RecipeModelId = meal.Recipe.Id.ToString(),
            CreatedAt = DateTime.UtcNow
        };
    }
}