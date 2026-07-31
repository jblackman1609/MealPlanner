using MealPlanner.MealService.Domain.Enums;
using MealPlanner.SharedKernel.Domain;

namespace MealPlanner.MealService.Domain.DomainEvents;

/// <summary>
/// Represents a domain event that is triggered when a meal has been prepared in the meal planning application. 
/// This event encapsulates the necessary information related to the meal preparation process, including the unique 
/// event identifier (EventId), correlation identifier (CorrelationId), and the name of the event (EventName). 
/// The MealPreparedEvent class inherits from the DomainEvent base class, allowing it to be used within the domain 
/// model to signal that a meal has been successfully prepared, enabling other components of the system to react accordingly.
/// </summary>
public class MealPreparedEvent : DomainEvent
{
    /// <summary>
    /// Initializes a new instance of the MealPreparedEvent class with the specified unique event identifier (EventId), 
    /// correlation identifier (CorrelationId), and event name (EventName). This constructor allows for the creation of 
    /// a MealPreparedEvent object that encapsulates the details of a meal preparation event, enabling other components 
    /// of the system to respond to the event as needed. The EventId is generated using Guid.NewGuid () to ensure uniqueness 
    /// across all event instances, while the CorrelationId is used to correlate related events within the system.
    /// </summary>
    /// <param name="eventId"></param>
    /// <param name="correlationId"></param>
    /// <param name="eventName"></param>
    public MealPreparedEvent(Guid eventId, string correlationId, string eventName)
        : base(eventId, correlationId, eventName)
    {        
    }    
}