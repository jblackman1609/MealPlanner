namespace MealService.Domain.Enums
{
    /// <summary>
    /// Represents the different types of meals that can be planned and prepared. The MealTypes enumeration 
    /// defines a set of named constants that correspond to common meal categories, including Breakfast, Lunch, 
    /// Dinner, and Snack. This enumeration can be used to categorize meals in the application, allowing for 
    /// better organization and filtering of meal plans based on the type of meal being prepared or consumed.
    /// </summary>
    public enum MealTypes
    {
        /// <summary>
        /// Represents a breakfast meal, typically consumed in the morning. Breakfast meals often include foods 
        /// such as eggs, cereal, toast, fruit, and beverages like coffee or juice. This meal type is important for 
        /// providing energy and nutrients to start the day.
        /// </summary>
        Breakfast,

        /// <summary>
        /// Represents a lunch meal, typically consumed in the middle of the day. Lunch meals often include sandwiches, 
        /// salads, soups, and other light to moderate dishes. This meal type is important for maintaining energy levels 
        /// throughout the afternoon and can vary widely based on cultural and personal preferences.
        /// </summary>
        Lunch,

        /// <summary>
        /// Represents a dinner meal, typically consumed in the evening. Dinner meals often include a variety of dishes, 
        /// such as meats, vegetables, grains, and desserts. This meal type is important for providing sustenance and nutrition 
        /// at the end of the day and is often a time for family or social gatherings.
        /// </summary>
        Dinner,

        /// <summary>
        /// Represents a snack, which is a small portion of food typically consumed between main meals. Snacks can include 
        /// items such as fruits, nuts, yogurt, or packaged snack foods. This meal type is important for maintaining energy 
        /// levels and preventing hunger between larger meals, and can also be a source of enjoyment or indulgence.
        Snack
    }    
}