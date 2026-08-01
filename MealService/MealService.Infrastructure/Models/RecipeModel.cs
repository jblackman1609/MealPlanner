namespace MealPlanner.MealService.Infrastructure.Models;

public class RecipeModel
{
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public List<IngredientModel> Ingredients { get; set; } = new List<IngredientModel>();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}