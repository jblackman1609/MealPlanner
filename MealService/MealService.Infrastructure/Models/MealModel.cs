namespace MealPlanner.MealService.Infrastructure.Models;

/// <summary>
/// Represents a data model for a meal entity within the meal planning application. This class encapsulates the 
/// necessary properties related to a meal, including its unique identifier (Id), the associated recipe model 
/// identifier (RecipeModelId), the type of meal (MealType), and the timestamp indicating when the meal was 
/// created (CreatedAt).
/// </summary>
public class MealModel
{
    /// <summary>
    /// Gets or sets the unique identifier for the meal entity. This property is used to uniquely identify a meal within 
    /// the system, allowing for efficient retrieval and management of meal data. The Id property is initialized to an 
    /// empty string.
    /// </summary>
    public string Id { get; set; } = string.Empty;
    
    /// <summary>
    /// Gets or sets the identifier for the associated recipe model. This property links the meal to its corresponding 
    /// recipe within the system.
    /// </summary>
    public string RecipeModelId { get; set; } = string.Empty;
    
    /// <summary>
    /// Gets or sets the type of meal. This property categorizes the meal based on its characteristics or intended use.
    /// </summary>
    public string MealType { get; set; } = string.Empty;
    
    /// <summary>
    /// Gets or sets the timestamp indicating when the meal was created. This property is initialized to the current UTC time.
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}