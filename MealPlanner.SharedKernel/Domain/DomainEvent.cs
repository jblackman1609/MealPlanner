/// <summary>
/// Represents a base class for domain events in the domain model.
/// A domain event is an object that captures a significant occurrence or change in the state of the domain model. 
/// It represents something that has happened in the past and is of interest to the domain experts.  
/// </summary>
public abstract class DomainEvent
{
    /// <summary>
    /// Gets the date and time when the domain event occurred. This property is set to the current UTC date and time when the 
    /// event is created, providing a timestamp for when the event took place. It is protected to allow derived classes to set 
    /// the value, but not external code, ensuring that the occurrence time of the event is controlled and cannot be arbitrarily 
    /// changed from outside the class.
    /// </summary>
    public DateTime OccurredOn { get; protected set; } = DateTime.UtcNow;
}