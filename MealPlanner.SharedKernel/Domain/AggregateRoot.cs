public abstract class AggregateRoot : Entity
{
    protected AggregateRoot(Guid id) : base(id)
    {
    }

    protected IList<DomainEvent>? _domainEvents;
    public IReadOnlyCollection<DomainEvent> DomainEvents => _domainEvents!.ToList();
    protected void AddDomainEvent(DomainEvent domainEvent)
    {
        _domainEvents ??= new List<DomainEvent>();
        _domainEvents.Add(domainEvent);
    }
}