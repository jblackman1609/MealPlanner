namespace MealPlanner.MealService.Infrastructure.Models;

/// <summary>
/// Represents a data model for a recipe entity within the meal planning application. This class encapsulates the
/// necessary properties related to a recipe, including its unique identifier (Id), name (Name), a list of associated 
/// ingredient models (Ingredients), and the timestamp indicating when the recipe was created (CreatedAt).
/// </summary>
public class RecipeModel
{
    /// <summary>
    /// Gets or sets the unique identifier for the recipe entity. This property is used to uniquely identify a recipe within 
    /// the system, allowing for efficient retrieval and management of recipe data. The Id property is initialized to an empty string.
    /// </summary>
    public string Id { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the name of the recipe. This property represents the descriptive name of the recipe, allowing for
    /// easy identification and categorization within the meal planning application. The Name property is initialized to an 
    /// empty string.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the list of ingredients associated with the recipe. This property allows for managing and displaying
    /// the ingredients required for preparing the recipe. The Ingredients property is initialized to an empty list.
    /// </summary>
    public List<IngredientModel> Ingredients { get; set; } = new List<IngredientModel>();

    /// <summary>
    /// Gets or sets the timestamp indicating when the recipe was created. This property is initialized to the current UTC time,
    /// allowing for tracking of recipe creation and management within the meal planning application. 
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}