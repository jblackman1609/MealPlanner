using MealPlanner.SharedKernel.Application;

/// <summary>
/// The IMealPublisher interface defines the contract for a publisher responsible for publishing meal-related events 
/// within the meal planning application. It extends the IEventPublisher interface, which provides the foundational 
/// methods for event publishing. Implementations of this interface can be used to publish events related to meal 
/// planning, such as meal creation, updates, or deletions, allowing for a decoupled and event-driven architecture 
/// within the application.
/// </summary>
namespace MealPlanner.MealService.Application.Interfaces;

/// <summary>
/// Defines the contract for a publisher responsible for publishing meal-related events within the meal planning application.
/// This interface provides an abstraction for publishing events, allowing for the implementation of various event publishing 
/// strategies while maintaining a consistent interface for interacting with meal events.
/// </summary>
public interface IMealPublisher : IEventPublisher
{    
}