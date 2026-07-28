using MealPlanner.SharedKernel.Domain;

namespace MealService.Domain.Entities;

/// <summary>
/// Represents a meal in the domain model. A meal is an entity that encapsulates a recipe, which defines the dish being prepared. 
/// It is identified by a unique identifier (Id) inherited from the base Entity class. The Meal class provides a structured 
/// representation of a culinary experience, allowing for the management and organization of meals within the application.
/// </summary>
public class Meal : AggregateRoot
{
    /// <summary>
    /// Gets the recipe associated with the meal. This property is set through the constructor and is immutable, 
    /// ensuring that the recipe associated with the meal cannot be changed after the object is created.
    /// </summary>
    public Recipe Recipe { get; private set; }

    /// <summary>
    /// Initializes a new instance of the Meal class with the specified unique identifier and recipe.
    /// The Id and recipe are set through the constructor to ensure that every meal has a defined state upon creation. 
    /// This is crucial for maintaining the integrity of the domain model, as meals are often compared and managed based 
    /// on their properties.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="recipe"></param>
    public Meal(Guid id, Recipe recipe) : base(id)
    {
        Recipe = recipe;
    }
}