using MealPlanner.SharedKernel.Domain;

namespace MealService.Domain.Entities;
/// <summary>
/// Represents a recipe in the domain model. A recipe is an entity that encapsulates the name of the dish and a 
/// list of ingredients required for its preparation. It is identified by a unique identifier (Id) inherited 
/// from the base Entity class. The Recipe class provides a structured representation of a culinary creation, 
/// allowing for the management and organization of recipes within the application.
/// </summary>
public class Recipe : Entity
{
    /// <summary>
    /// Gets the name of the recipe. This property is set through the constructor and is immutable, 
    /// ensuring that the name of the recipe cannot be changed after the object is created. The name 
    /// represents the identifier for the recipe within the domain model.
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Gets the list of ingredients required for the recipe. This property is set through the constructor and is immutable, 
    /// ensuring that the list of ingredients cannot be changed after the object is created. The ingredients represent the 
    /// components needed for the preparation of the dish, and their immutability ensures that the state of the recipe remains 
    /// consistent throughout its lifecycle, promoting reliability and predictability in the domain model.
    /// </summary>
    public List<Ingredient> Ingredients { get; private set; }

    /// <summary>
    /// Initializes a new instance of the Recipe class with the specified unique identifier, name, and list of ingredients.
    /// The Id, name, and ingredients are set through the constructor to ensure that every recipe has a defined state upon creation. 
    /// This is crucial for maintaining the integrity of the domain model, as recipes are often compared and managed based on their 
    /// properties.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="ingredients"></param>
    public Recipe(Guid id, string name, List<Ingredient> ingredients) : base(id)
    {
        Name = name;
        Ingredients = ingredients;
    }
}