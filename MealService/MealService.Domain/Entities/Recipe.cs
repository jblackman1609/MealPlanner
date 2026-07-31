using MealPlanner.SharedKernel.Domain;
using MealPlanner.MealService.Domain.ValueObjects;

namespace MealPlanner.MealService.Domain.Entities;

/// <summary>
/// Represents a recipe entity in the domain model, encapsulating its name and a collection of ingredients. This class inherits 
/// from the Entity base class, which provides a unique identifier (Id) for each recipe instance. The Name property is immutable 
/// after construction, ensuring that the name of a Recipe instance cannot be changed once it has been created. The Ingredients 
/// property provides a read-only list of Ingredient value objects associated with the recipe, allowing for the encapsulation of 
/// ingredient details such as name and quantity. The Recipe class also provides methods to add new ingredients to the recipe, 
/// maintaining the integrity of the ingredient collection while adhering to the principles of domain-driven design.
/// </summary>
public class Recipe : Entity
{
    /// <summary>
    /// Gets the name of the recipe. This property is immutable after construction, ensuring that the name of a Recipe instance 
    /// cannot be changed once it has been created. The Name property is a string that represents the name of the recipe, such 
    /// as "Spaghetti Bolognese" or "Chicken Curry".
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Gets the collection of ingredients associated with the recipe. This property is read-only and provides access to the 
    /// list of Ingredient value objects that have been added to the recipe. The Ingredients property is implemented as a 
    /// read-only list, ensuring that external consumers cannot modify the underlying collection of ingredients directly.
    /// </summary>
    private readonly IList<Ingredient>? _ingredients;

    /// <summary>
    /// Gets the collection of ingredients associated with the recipe. This property is read-only and provides access to the 
    /// list of Ingredient value objects that have been added to the recipe. The Ingredients property is implemented as a read-only 
    /// list, ensuring that external consumers cannot modify the underlying collection of ingredients directly.
    /// </summary>
    public IReadOnlyList<Ingredient> Ingredients => _ingredients?.ToList() ?? new List<Ingredient>();

    /// <summary>
    /// Initializes a new instance of the Recipe class with the specified unique identifier (Id), name, and a collection of ingredients. 
    /// This constructor allows for the creation of a Recipe object that encapsulates the name and ingredients of the recipe.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="name"></param>
    /// <param name="ingredients"></param>
    internal Recipe(Guid id, string name, List<Ingredient> ingredients) : base(id)
    {
        Name = name;
        _ingredients = ingredients;
    }

    /// <summary>
    /// Adds a new ingredient to the collection of ingredients associated with the recipe. This method allows for the addition of 
    /// new Ingredient value objects to the recipe, enabling the encapsulation of ingredient details such as name and quantity 
    /// while maintaining the integrity of the ingredient collection. The Add method is internal, allowing it to be accessed
    /// only within the same assembly, ensuring that ingredient additions are controlled and adhere to the principles of 
    /// domain-driven design.
    /// </summary>
    /// <param name="ingredient"></param>
    internal void Add(Ingredient ingredient)
    {
        _ingredients?.Add(ingredient);
    }
}