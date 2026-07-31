namespace MealPlanner.SharedKernel.Domain;

/// <summary>
/// Represents a base class for domain events in the domain model, providing properties to track the occurrence time (OccurredOn),
/// unique identifier (EventId), and correlation identifier (CorrelationId).
/// </summary>
public abstract class DomainEvent
{
    /// <summary>
    /// Gets the date and time when the domain event occurred. This property is set to the current UTC time when the event is created,
    /// allowing for accurate tracking of event occurrences in the system.
    /// </summary>
    public DateTime OccurredOn { get; protected set; }

    /// <summary>
    /// Gets the unique identifier (EventId) of the domain event. This property is protected set, allowing derived classes to set 
    /// the EventId while preventing external modification. The EventId is typically generated using Guid.NewGuid() to ensure 
    /// uniqueness across all event instances.
    /// </summary>
    public Guid EventId { get; protected set; }

    /// <summary>
    /// Gets the correlation identifier (CorrelationId) of the domain event. This property is protected set, allowing derived 
    /// classes to set the CorrelationId while preventing external modification.
    /// </summary>
    public string CorrelationId { get; protected set; } = string.Empty;

    /// <summary>
    /// Gets the name of the domain event. This property is protected set, allowing derived classes to set the EventName while
    /// preventing external modification. The EventName is typically set to the name of the derived event class, providing a way 
    /// to identify the type of event that occurred in the system.
    /// </summary>
    public string EventName { get; protected set; } = string.Empty;

    /// <summary>
    /// Initializes a new instance of the DomainEvent class with a unique identifier (EventId) and a correlation identifier 
    /// (CorrelationId).
    /// </summary>
    /// <param name="eventId"></param>
    /// <param name="correlationId"></param>
    /// <param name="eventName"></param>
    protected DomainEvent(Guid eventId, string correlationId, string eventName)
    {
        EventId = eventId;
        CorrelationId = correlationId;
        OccurredOn = DateTime.UtcNow;
    }
}