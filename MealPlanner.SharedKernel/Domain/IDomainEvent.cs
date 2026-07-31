namespace MealPlanner.SharedKernel.Domain;

public interface IDomainEvent
{
    string EventName { get; }
}