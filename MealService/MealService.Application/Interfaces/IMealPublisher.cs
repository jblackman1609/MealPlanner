using MealPlanner.SharedKernel.Application;

namespace MealPlanner.MealService.Application.Interfaces;

/// <summary>
/// Defines the contract for a publisher responsible for publishing meal-related events within the meal planning application.
/// This interface provides an abstraction for publishing events, allowing for the implementation of various event publishing 
/// strategies while maintaining a consistent interface for interacting with meal events.
/// </summary>
public interface IMealPublisher : IEventPublisher
{    
}