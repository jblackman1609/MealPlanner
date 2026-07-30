namespace MealPlanner.SharedKernel.Domain;

/// <summary>
/// Represents a base class for aggregate roots in the domain model, inheriting from the Entity class. Aggregate roots are the main 
/// entry points for accessing and managing related entities within an aggregate, ensuring consistency and encapsulation of business 
/// rules.
/// </summary>
public abstract class AggregateRoot : Entity
{
    /// <summary>
    /// Gets the collection of domain events associated with the aggregate root. This property is read-only and provides access to 
    /// the list of domain events that have occurred within the aggregate root. The domain events are stored in a private readonly 
    /// list, and the IReadOnlyCollection interface is used to expose the events to external consumers while preventing modification 
    /// of the underlying list. This design allows for tracking and handling domain events in a controlled manner.  
    /// </summary>
    private readonly List<DomainEvent> _domainEvents;

    /// <summary>
    /// Gets the collection of domain events associated with the aggregate root. This property is read-only and provides access 
    /// to the list of domain events that have occurred within the aggregate root. The domain events are stored in a private 
    /// readonly list, and the IReadOnlyCollection interface is used to expose the events to external consumers while preventing 
    /// modification of the underlying list. This design allows for tracking and handling domain events in a controlled manner.
    /// </summary>
    public IReadOnlyCollection<DomainEvent> DomainEvents => _domainEvents.AsReadOnly();

    /// <summary>
    /// Initializes a new instance of the AggregateRoot class with a unique identifier (Id). The Id is generated using Guid.NewGuid() to 
    /// ensure uniqueness across all aggregate root instances.
    /// </summary>
    /// <param name="id"></param>
    protected AggregateRoot(Guid id) : base(id)
    {
        _domainEvents = new List<DomainEvent>();
    }

    /// <summary>
    /// Adds a domain event to the collection of domain events associated with the aggregate root. This method allows derived 
    /// classes to add domain events that have occurred within the aggregate root, enabling event-driven behavior and facilitating 
    /// event handling.
    /// </summary>
    /// <param name="domainEvent"></param>
    protected void Add(DomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }
}