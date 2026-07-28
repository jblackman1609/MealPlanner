/// <summary>
/// Represents a base class for entities in the domain model.
/// An entity is an object that has a distinct identity that runs through time and different states.
/// The identity is represented by the Id property, which is a unique identifier for the entity.
/// </summary>
public abstract class Entity
{
    /// <summary>
    /// The unique identifier for the entity.
    /// Protected set to allow derived classes to set the value, but not external code.
    /// This ensures that the entity's identity is controlled and cannot be arbitrarily changed from outside the class, 
    /// maintaining the integrity of the entity's identity. The Id is typically set through the constructor of the derived class, 
    /// ensuring that every entity` has a unique identity upon creation. This is crucial for maintaining the integrity of the 
    /// domain model, as entities are often compared and managed based on their identities. 
    /// </summary>
    public Guid Id { get; protected set; }

    /// <summary>
    /// Initializes a new instance of the Entity class with the specified unique identifier.
    /// The Id is set through the constructor to ensure that every entity has a unique identity upon
    /// creation. This is crucial for maintaining the integrity of the domain model, as entities are often compared and managed 
    /// based on their identities.
    /// </summary>
    /// <param name="id"></param>
    protected Entity(Guid id)
    {
        Id = id;
    }
}