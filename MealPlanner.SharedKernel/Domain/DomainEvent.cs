namespace MealPlanner.SharedKernel.Domain;

public abstract class DomainEvent
{
    public DateTime OccurredOn { get; protected set; }
    public Guid EventId { get; protected set; }
    public string CorrelationId { get; protected set; } = string.Empty;

    protected DomainEvent(Guid eventId, string correlationId)
    {
        EventId = eventId;
        CorrelationId = correlationId;
        OccurredOn = DateTime.UtcNow;
    }
}