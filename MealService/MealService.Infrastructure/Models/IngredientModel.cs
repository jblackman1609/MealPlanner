namespace MealPlanner.MealService.Infrastructure.Models;

/// <summary>
/// Represents a data model for an ingredient entity within the meal planning application. This class encapsulates the
/// necessary properties related to an ingredient, including its unique identifier (Id), name (Name), quantity (Quantity), 
/// scale (Scale), and the timestamp indicating when the ingredient was created (CreatedAt).
/// </summary>
public class IngredientModel
{
    /// <summary>
    /// Gets or sets the unique identifier for the ingredient entity. This property is used to uniquely identify an ingredient 
    /// within the system, allowing for efficient retrieval and management of ingredient data. The Id property is initialized 
    /// to an empty string.
    /// </summary>
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the name of the ingredient. This property represents the descriptive name of the ingredient, allowing for
    /// easy identification and categorization within the meal planning application. The Name property is initialized to an 
    /// empty string.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the quantity of the ingredient. This property represents the amount of the ingredient required for a recipe,
    /// allowing for accurate measurement and preparation of meals. The Quantity property is initialized to an empty string.
    /// </summary>
    public string Quantity { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the scale of the ingredient. This property represents the unit of measurement for the ingredient's quantity, 
    /// allowing for proper scaling and conversion of ingredient amounts. The Scale property is initialized to an empty string. 
    /// </summary>
    public string Scale { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the timestamp indicating when the ingredient was created. This property is initialized to the current UTC time,
    /// allowing for tracking of ingredient creation and management within the meal planning application. 
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}