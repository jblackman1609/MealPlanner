using MealPlanner.MealService.Domain.Enums;
using MealPlanner.SharedKernel.Domain;

namespace MealPlanner.MealService.Domain.DomainEvents;

public class MealPreparedEvent : DomainEvent
{

    public MealPreparedEvent(Guid eventId, string correlationId, string eventName)
        : base(eventId, correlationId, nameof(MealPreparedEvent))
    {        
    }    
}