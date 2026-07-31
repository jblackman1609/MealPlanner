using MealPlanner.SharedKernel.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace MealPlanner.SharedKernel.Application;

/// <summary>
/// Represents a generic interface for publishing domain events of type TEvent. This interface defines a method for asynchronously
/// publishing events, allowing for decoupled communication between different parts of the system. The generic type parameter 
/// TEvent is constrained to implement the IDomainEvent interface, ensuring that only valid domain events can be published.
/// </summary>
public interface IEventPublisher
{
    /// <summary>
    /// Asynchronously publishes the specified domain event of type TEvent. This method allows for the decoupled communication of
    /// events between different parts of the system, enabling event-driven architectures and facilitating the implementation of
    /// eventual consistency patterns.
    /// </summary>
    /// <typeparam name="TEvent">The type of the domain event to be published.</typeparam>
    /// <param name="event">The domain event instance to be published.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the asynchronous operation.</param>
    /// <returns>A task that represents the asynchronous publish operation.</returns>
    Task PublishAsync<TEvent>(TEvent @event, CancellationToken cancellationToken = default) where TEvent : IDomainEvent;
}