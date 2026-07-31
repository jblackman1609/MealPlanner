using MealPlanner.MealService.Application.Commands;
using MealPlanner.MealService.Domain.Entities;
using MealPlanner.SharedKernel.Application;
using MealPlanner.MealService.Application.Interfaces;
using MealPlanner.MealService.Domain.DomainEvents;

namespace MealPlanner.MealService.Application.Handlers;

/// <summary>
/// Represents a command handler responsible for processing the PrepareMealCommand within the meal planning application.
/// This handler implements the IRequestHandler interface, allowing it to handle requests of type PrepareMealCommand and 
/// produce a response of type Response<Meal>. The PrepareMealCommandHandler class encapsulates the logic for preparing a 
/// meal, including creating a new meal entity, persisting it to the underlying data store via the IMealRepository, and 
/// publishing a meal-prepared event using the IMealPublisher. This design promotes separation of concerns and enables other 
/// components of the system to respond to meal preparation events in a decoupled manner.
/// </summary>
public class PrepareMealCommandHandler : IRequestHandler<PrepareMealCommand, Response<Meal>>
{   
    /// <summary>
    /// The IMealRepository instance used for persisting meal entities to the underlying data store. 
    /// This repository abstraction allows for the implementation of various data access strategies while
    /// maintaining a consistent interface for interacting with meal data. The repository is injected into 
    /// the handler via the constructor, enabling the handler to persist meal entities in a decoupled manner.
    private readonly IMealRepository _repository;

    /// <summary>
    /// The IMealPublisher instance used for publishing meal-related events within the meal planning application.
    /// This publisher abstraction allows for the implementation of various event publishing strategies while 
    /// maintaining a consistent interface for interacting with meal events. The publisher is injected into
    /// the handler via the constructor, enabling the handler to publish meal-prepared events in a decoupled manner.
    /// </summary>
    private readonly IMealPublisher _publisher;

    /// <summary>
    /// The topic name used for publishing meal-prepared events. This string value represents the specific topic to which
    /// meal-prepared events are published, allowing other components of the system to subscribe to and react to these 
    /// events as needed. The topic name is defined as a private readonly field within the handler, ensuring 
    /// its immutability and consistent usage throughout the handler's implementation.
    /// </summary>
    private readonly string topic = "meal-prepared";

    /// <summary>
    /// Initializes a new instance of the PrepareMealCommandHandler class with the specified IMealRepository and IMealPublisher.
    /// This constructor allows for the injection of dependencies required for handling the PrepareMealCommand, enabling 
    /// the handler to interact with the underlying data store and publish meal-related events. The IMealRepository is used
    /// to persist meal entities, while the IMealPublisher is responsible for publishing events related to meal preparation, 
    /// allowing other components of the system to react accordingly.
    /// </summary>
    public PrepareMealCommandHandler(IMealRepository repository, IMealPublisher publisher) =>
        (_repository, _publisher) = (repository, publisher);
    
    /// <summary>
    /// Asynchronously handles the PrepareMealCommand by creating a new meal entity, persisting it to the underlying data store,
    /// and publishing a meal-prepared event. This method encapsulates the logic for preparing a meal, allowing other components 
    /// of the system to respond to the meal preparation process in a decoupled manner.
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<Response<Meal>> HandleAsync(PrepareMealCommand request, CancellationToken cancellationToken = default)
    {
        var meal = new Meal(Guid.NewGuid(), request.Recipe, request.MealType);

        await _repository.AddAsync(meal);
        await _publisher
        .PublishAsync(topic, new MealPreparedEvent(Guid.NewGuid(), Guid.NewGuid().ToString(), "meal-prepared-event"), cancellationToken);

        return new Response<Meal>(meal, true, "Meal prepared successfully.");
    }
}