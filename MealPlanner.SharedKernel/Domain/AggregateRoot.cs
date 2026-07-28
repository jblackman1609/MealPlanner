/// <summary>
/// Represents a base class for aggregate roots in the domain model.
/// An aggregate root is an entity that serves as the entry point for a cluster of related entities and value objects, 
/// collectively known as an aggregate.
/// </summary>
public abstract class AggregateRoot : Entity
{
    /// <summary>
    /// Initializes a new instance of the AggregateRoot class with the specified unique identifier.
    /// The Id is set through the constructor to ensure that every aggregate root has a unique identity upon creation. 
    /// This is crucial for maintaining the integrity of the domain model, as aggregate roots are often compared and managed 
    /// based on their identities.
    /// </summary>
    /// <param name="id"></param>
    protected AggregateRoot(Guid id) : base(id)
    {
    }

    /// <summary>
    /// Gets the collection of domain events that have occurred within the aggregate root.
    /// This collection is used to track significant occurrences or changes in the state of the aggregate root and its 
    /// related entities and value objects.
    /// </summary>
    protected IList<DomainEvent>? _domainEvents;

    /// <summary>
    /// Gets the collection of domain events that have occurred within the aggregate root.
    /// This collection is used to track significant occurrences or changes in the state of the aggregate root and its 
    /// related entities and value objects.
    /// </summary>
    public IReadOnlyCollection<DomainEvent> DomainEvents => _domainEvents!.ToList();

    /// <summary>
    /// Adds a domain event to the collection of domain events for the aggregate root.
    /// This method is used to track significant occurrences or changes in the state of the aggregate root and its related entities and value objects. The domain event is added to the collection, allowing it to be processed later,
    /// such as by a domain event handler or an event bus. The method ensures that the collection is initialized if it is null, 
    /// and then adds the provided domain event to the collection.
    /// </summary>
    /// <param name="domainEvent"></param>
    protected void AddDomainEvent(DomainEvent domainEvent)
    {
        _domainEvents ??= new List<DomainEvent>();
        _domainEvents.Add(domainEvent);
    }
}