namespace MealPlanner.SharedKernel.Domain
{
    public abstract class DomainEvent
    {
        public Guid Id { get; protected set; }
        public DateTime OccurredOn { get; protected set; } = DateTime.UtcNow;

        protected DomainEvent()
        {
            Id = Guid.NewGuid();
        }
    }
}