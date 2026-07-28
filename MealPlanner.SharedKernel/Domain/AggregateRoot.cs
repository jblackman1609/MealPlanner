namespace MealPlanner.SharedKernel.Domain
{
    public abstract class AggregateRoot : Entity
    {
        public Guid Id { get; protected set; }
        private readonly List<DomainEvent> _domainEvents = new List<DomainEvent>();
        public IReadOnlyCollection<DomainEvent> DomainEvents => _domainEvents.AsReadOnly();

        protected AggregateRoot()
        {
            Id = id;
        }

        protected void AddDomainEvent(DomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }
    }
}