namespace MealService.Domain.Enities
{
    /// <summary>
    /// Represents a meal in the meal service domain. A meal is an aggregate root that encapsulates the name 
    /// of the meal, the associated recipe, and the type of meal (e.g., breakfast, lunch, dinner). The Name 
    /// property represents the name of the meal, the Recipe property holds a reference to the associated Recipe 
    /// entity, and the MealType property indicates the type of meal. The constructor initializes the Id, Name, 
    /// Recipe, and MealType properties with the provided values, ensuring that each meal has a unique identifier, 
    /// a defined name, an associated recipe, and a specified meal type.
    /// </summary>
    public class Meal : AggregateRoot
    {
        /// <summary>
        /// Gets the associated recipe for the meal. This property holds a reference to the Recipe entity that defines
        /// the components and preparation instructions for the meal. The Recipe property is typically set during the 
        /// initialization of the meal.
        /// </summary>
        public Recipe Recipe { get; private set; }

        /// <summary>
        /// Gets the type of meal (e.g., breakfast, lunch, dinner). This property indicates the category or classification
        /// of the meal, allowing it to be organized and categorized based on its intended consumption time. The MealType 
        /// property is typically set during the initialization of the meal.
        /// </summary>
        public MealTypes MealType { get; private set; }

        /// <summary>
        /// Initializes a new instance of the Meal class with the specified unique identifier, associated recipe,
        /// and meal type. This constructor ensures that each meal has a unique identifier, an associated 
        /// recipe, and a specified meal type, allowing it to be used in meal planning and preparation.
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
}