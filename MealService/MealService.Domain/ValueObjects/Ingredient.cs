using MealPlanner.MealService.Enums;

namespace MealPlanner.MealService.Domain.ValueObjects;

/// <summary>
/// Represents an ingredient used in a meal, encapsulating its name and quantity. This class is designed as a value object, 
/// meaning that its equality is based on the values of its properties rather than its identity. The Name and Quantity 
/// properties are immutable after construction, ensuring that the state of an Ingredient instance cannot be changed once 
/// it has been created.
/// </summary>
public class Ingredient
{
    /// <summary>
    /// Gets the name of the ingredient. This property is immutable after construction, ensuring that the name of an Ingredient 
    /// instance cannot be changed once it has been created. The Name property is a string that represents the name of the 
    /// ingredient, such as "Tomato" or "Chicken Breast".
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Gets the quantity of the ingredient. This property is immutable after construction, ensuring that the quantity of an 
    /// Ingredient instance cannot be changed once it has been created. The Quantity property is a string that represents the
    /// quantity of the ingredient, such as "2 cups" or "1 lb".
    /// </summary>
    public string Quantity { get; private set; }

    /// <summary>
    /// Gets the scale of the ingredient. This property is immutable after construction, ensuring that the scale of an 
    /// Ingredient instance cannot be changed once it has been created. The Scale property is an enumeration that represents 
    /// the scale of the ingredient, such as grams, liters, or pieces.
    /// </summary>
    public Scales Scale { get; private set; }

    /// <summary>
    /// Initializes a new instance of the Ingredient class with the specified name and quantity. This constructor allows for the
    /// creation of an Ingredient object that encapsulates the name and quantity of the ingredient, providing a standardized way 
    /// to represent ingredients used in meals. The Name and Quantity properties are set during construction and cannot be modified 
    /// afterward, ensuring the immutability of the Ingredient instance.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="quantity"></param>
    internal Ingredient(string name, string quantity, Scales scale)
    {
        Name = name;
        Quantity = quantity;
        Scale = scale;
    }
}