using MealPlanner.SharedKernel.Domain;
using MealPlanner.MealService.Domain.Enums;

namespace MealPlanner.MealService.Domain.Entities;

/// <summary>
/// Represents a meal entity in the meal planning application, encapsulating the details of a specific meal, including 
/// its associated recipe and meal type.
/// </summary>
public class Meal : AggregateRoot
{
    /// <summary>
    /// Gets the recipe associated with the meal. This property is read-only and is set during the creation of the Meal 
    /// instance, ensuring that the recipe cannot be changed once the meal has been created. The Recipe property provides 
    /// access to the Recipe entity that defines the ingredients and preparation instructions for the meal.
    /// </summary>
    public Recipe Recipe { get; private set; }

    /// <summary>
    /// Gets the meal type associated with the meal. This property is read-only and is set during the creation of the Meal
    /// instance, ensuring that the meal type cannot be changed once the meal has been created. The MealType property provides 
    /// access to the MealTypes enumeration value that categorizes the meal based on its typical consumption time, such as 
    /// Breakfast, Lunch, or Dinner.
    /// </summary>
    public MealTypes MealType { get; private set; }

    /// <summary>
    /// Initializes a new instance of the Meal class with the specified unique identifier (Id), associated recipe, and meal type.
    /// This constructor allows for the creation of a Meal object that encapsulates the details of a specific meal, including 
    /// its recipe and meal type. The Id is generated using Guid.NewGuid() to ensure uniqueness across all meal instances.
    /// </summary>
    /// <param name="id"></param>
    /// <param name="recipe"></param>
    /// <param name="mealType"></param>
    public Meal(Guid id, Recipe recipe, MealTypes mealType) : base(id)
    {
        Recipe = recipe;
        MealType = mealType;
    }
}