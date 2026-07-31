namespace MealPlanner.SharedKernel.Domain;

/// <summary>
/// Represents a generic interface for domain events in the domain model, providing properties to track the occurrence time (OccurredOn),
/// unique identifier (EventId), and correlation identifier (CorrelationId).
/// </summary>
public interface IDomainEvent
{
    /// <summary>
    /// Gets the date and time when the domain event occurred. This property is set to the current UTC time when the event is created,
    /// allowing for accurate tracking of event occurrences in the system. 
    /// </summary>
    string EventName { get; }
}