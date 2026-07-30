namespace MealPlanner.SharedKernel.Domain;

/// <summary>
/// Represents a base class for entities in the domain model, providing a unique identifier (Id) for each entity instance. 
/// </summary>
public abstract class Entity
{
    /// <summary>
    /// Gets the unique identifier (Id) of the entity. This property is protected set, allowing derived classes to set the Id while 
    /// preventing external modification.   
    /// </summary>
    public Guid Id { get; protected set; }

    /// <summary>
    /// Initializes a new instance of the Entity class with a unique identifier (Id). The Id is generated using Guid.NewGuid() to 
    /// ensure uniqueness across all entity instances.
    /// </summary>
    /// <param name="id"></param>
    protected Entity(Guid id) => Id = id;
}