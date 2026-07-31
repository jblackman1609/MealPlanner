using MealPlanner.MealService.Application.Commands;
using MealPlanner.MealService.Domain.Entities;
using MealPlanner.SharedKernel.Application;
using MealPlanner.MealService.Application.Interfaces;
using MealPlanner.MealService.Domain.DomainEvents;

namespace MealPlanner.MealService.Application.Handlers;

public class PrepareMealCommandHandler : IRequestHandler<PrepareMealCommand, Response<Meal>>
{
    private readonly IMealRepository _repository;
    private readonly IMealPublisher _publisher;
    private readonly string topic = "meal-prepared";

    public PrepareMealCommandHandler(IMealRepository repository, IMealPublisher publisher) =>
        (_repository, _publisher) = (repository, publisher);
    
    public async Task<Response<Meal>> HandleAsync(PrepareMealCommand request, CancellationToken cancellationToken = default)
    {
        var meal = new Meal(Guid.NewGuid(), request.Recipe, request.MealType);

        await _repository.AddAsync(meal);
        await _publisher
        .PublishAsync(topic, new MealPreparedEvent(Guid.NewGuid(), Guid.NewGuid().ToString(), "meal-prepared-event"), cancellationToken);

        return new Response<Meal>(meal, true, "Meal prepared successfully.");
    }
}