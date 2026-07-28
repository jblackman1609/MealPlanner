namespace MealPlanner.SharedKernel.Domain
{
    /// <summary>
    /// Represents a base class for entities in the domain model. An entity is an object that has a unique 
    /// identity and can be distinguished from other objects based on that identity. The Id property is used 
    /// to uniquely identify the entity, and it is typically assigned when the entity is created. The constructor 
    /// takes a Guid parameter to initialize the Id property, ensuring that each entity has a unique identifier.
    /// </summary>
    public abstract class Entity
    {
        /// <summary>
        /// Gets the unique identifier of the entity. This property is used to distinguish the entity from other 
        /// entities in the domain model.
        /// </summary>
        public Guid Id { get; protected set; }

        /// <summary>
        /// Initializes a new instance of the Entity class with the specified unique identifier. This constructor is
        /// protected to prevent direct instantiation of the Entity class, as it is intended to be used as a base 
        /// class for other domain entities. The Id parameter is used to set the unique identifier of the entity.
        /// </summary>
        /// <param name="id"></param>
        protected Entity(Guid id)
        {
            Id = id;
        }        
    }
}