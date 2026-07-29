namespace MealPlanner.SharedKernel.Domain
{
    /// <summary>
    /// Represents a base class for aggregate roots in the domain model. An aggregate root is an entity that 
    /// serves as the entry point for accessing and managing a group of related entities within an aggregate. 
    /// The Id property is used to uniquely identify the aggregate root, and it is typically assigned when the 
    /// aggregate root is created. The constructor takes a Guid parameter to initialize the Id property, ensuring 
    /// that each aggregate root has a unique identifier. The AddDomainEvent method allows adding domain events to 
    /// the aggregate root, enabling the capture and communication of significant occurrences or changes in the state 
    /// of the aggregate.
    /// </summary>
    public abstract class AggregateRoot : Entity
    {
        /// <summary>
        /// Gets the collection of domain events associated with the aggregate root. This property provides access to the
        /// domain events that have occurred within the aggregate, allowing other parts of the system to react to those events. 
        /// The domain events are typically added to the collection using the AddDomainEvent method, enabling the capture and 
        /// communication of significant occurrences or changes in the state of the aggregate.
        /// </summary>
        private readonly List<DomainEvent> _domainEvents = new List<DomainEvent>();

        /// <summary>
        /// Gets the collection of domain events associated with the aggregate root as a read-only collection. This property provides
        /// access to the domain events that have occurred within the aggregate, allowing other parts of the system to react to those 
        /// events without allowing modification of the collection. The read-only collection is typically used to expose the domain 
        /// events to external components while maintaining encapsulation and preventing unintended modifications.
        /// </summary>
        public IReadOnlyCollection<DomainEvent> DomainEvents => _domainEvents.AsReadOnly();

        /// <summary>
        /// Initializes a new instance of the AggregateRoot class with the specified unique identifier. This constructor is
        /// protected to prevent direct instantiation of the AggregateRoot class, as it is intended to be used as a base class 
        /// for other aggregate roots. The Id parameter is used to set the unique identifier of the aggregate root, ensuring 
        /// that each aggregate root has a unique identifier.
        /// </summary>
        /// <param name="id"></param>
        protected AggregateRoot(Guid id) : base(id)
        {
            Id = id;
        }

        /// <summary>
        /// Adds a domain event to the collection of domain events associated with the aggregate root. This method allows 
        /// capturing and communicating significant occurrences or changes in the state of the aggregate, enabling other 
        /// parts of the system to react to those events. The domain event is typically added to the collection using this 
        /// method, ensuring that it is properly tracked and managed within the aggregate.
        /// </summary>
        /// <param name="domainEvent"></param>
        protected void AddDomainEvent(DomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }
    }
}