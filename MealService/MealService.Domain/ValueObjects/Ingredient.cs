using MealPlanner.SharedKernel.Domain;

namespace MealService.Domain.ValueObjects;
/// <summary>
/// Represents an ingredient used in a recipe. An ingredient is a value object that encapsulates the 
/// name and quantity of a specific component used in the preparation of a dish. It is immutable, meaning 
/// that once an instance of Ingredient is created, its properties cannot be changed. This immutability ensures 
/// that the state of the ingredient remains consistent throughout its lifecycle, promoting reliability and predictability 
/// in the domain model.  
/// </summary>
public class Ingredient
{
    /// <summary>
    /// Gets the name of the ingredient. This property is set through the constructor and is immutable, 
    /// ensuring that the name of the ingredient cannot be changed after the object is created. The name represents 
    /// the identifier for the ingredient within the domain model.
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Gets the quantity of the ingredient. This property is set through the constructor and is immutable, 
    /// ensuring that the quantity of the ingredient cannot be changed after the object is created. The quantity 
    /// represents the amount of the ingredient required for a recipe, and its immutability ensures that the state 
    /// of the ingredient remains consistent throughout its lifecycle, promoting reliability and predictability in 
    /// the domain model.
    /// </summary>
    public decimal Quantity { get; private set; }

    /// <summary>
    /// Initializes a new instance of the Ingredient class with the specified name and quantity.
    /// The name and quantity are set through the constructor to ensure that every ingredient has a defined
    /// state upon creation. This is crucial for maintaining the integrity of the domain model, as ingredients are 
    /// often compared and managed based on their properties.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="quantity"></param>
    public Ingredient(string name, decimal quantity)
    {
        Name = name;
        Quantity = quantity;
    }
}