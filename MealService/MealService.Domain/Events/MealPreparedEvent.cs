using MealPlanner.SharedKernel.Domain;

namespace MealService.Domain.Events;

/// <summary>
/// Represents an event that is triggered when a meal has been prepared. This event encapsulates the unique identifiers 
/// of the meal and the associated recipe, allowing for the tracking and management of meal preparation within the application. 
/// The MealPreparedEvent class inherits from the DomainEvent base class, which provides a structured representation of 
/// domain events in the system.
/// </summary>
/// <param name="MealId"></param>
/// <param name="RecipeId"></param>
public record MealPreparedEvent(Guid MealId, Guid RecipeId) : DomainEvent
{
}                   