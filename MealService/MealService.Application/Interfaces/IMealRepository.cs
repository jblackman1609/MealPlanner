using MealPlanner.MealService.Domain.Entities;

namespace MealPlanner.MealService.Application.Interfaces;

/// <summary>
/// Defines the contract for a repository responsible for managing meal entities within the meal planning application.
/// This interface provides an abstraction for adding meal entities to the underlying data store, allowing for the 
/// implementation of various data access strategies while maintaining a consistent interface for interacting with meal data.
/// The IMealRepository interface is designed to facilitate the persistence and retrieval of meal entities, enabling
/// other components of the system to interact with meal data in a decoupled manner. Implementations of this interface
/// can leverage different data storage mechanisms, such as relational databases, NoSQL databases, or in-memory collections, 
/// while adhering to the defined contract for managing meal entities.
/// </summary>
public interface IMealRepository
{
    /// <summary>
    /// Asynchronously adds a new meal entity to the underlying data store. This method allows for the persistence of meal 
    /// entities, enabling other components of the system to interact with meal data in a decoupled manner.
    /// </summary>
    /// <param name="meal"></param>
    /// <returns></returns>
    Task AddAsync(Meal meal);
}