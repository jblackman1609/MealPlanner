namespace MealPlanner.SharedKernel.Domain
{
    /// <summary>
    /// Represents a base class for domain events in the domain model. A domain event is an object that represents 
    /// a significant occurrence or change in the state of the domain. It is typically used to capture and communicate 
    /// important events that have happened within the domain, allowing other parts of the system to react to those events. 
    /// The Id property is used to uniquely identify the domain event, and the OccurredOn property indicates the timestamp 
    /// when the event occurred. The constructor initializes the Id property with a new unique identifier (Guid) and sets 
    /// the OccurredOn property to the current UTC time.
    /// </summary>
    public abstract class DomainEvent
    {
        /// <summary>
        /// Gets the unique identifier of the domain event. This property is used to distinguish the domain event from other
        /// events in the domain model. The Id is typically assigned when the domain event is created, ensuring that each 
        /// event has a unique identifier.
        /// </summary>
        public Guid Id { get; protected set; }

        /// <summary>
        /// Gets the timestamp indicating when the domain event occurred. This property is used to track the timing of the
        /// event, allowing other parts of the system to react to the event based on its occurrence time. The OccurredOn 
        /// property is typically set to the current UTC time when the domain event is created, providing a consistent and 
        /// reliable way to record the timing of events in the domain model.
        /// </summary>
        public DateTime OccurredOn { get; protected set; } = DateTime.UtcNow;

        /// <summary>
        /// Initializes a new instance of the DomainEvent class. This constructor is protected to prevent direct instantiation
        /// of the DomainEvent class, as it is intended to be used as a base class for other domain events. The constructor 
        /// initializes the Id property with a new unique identifier (Guid) and sets the OccurredOn property to the current UTC time, 
        /// ensuring that each domain event has a unique identifier and a timestamp indicating when it occurred.
        /// </summary>
        protected DomainEvent()
        {
            Id = Guid.NewGuid();
        }
    }
}