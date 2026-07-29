namespace MealService.Domain.ValueObjects
{
    /// <summary>
    /// Represents an ingredient used in a meal. An ingredient is a value object that encapsulates the 
    /// name and quantity of the ingredient. The Name property represents the name of the ingredient, 
    /// while the Quantity property represents the amount or measurement of the ingredient. The constructor 
    /// initializes the Name and Quantity properties with the provided values, ensuring that each ingredient 
    /// has a defined name and quantity.
    /// </summary>
    public class Ingredient
    {
        /// <summary>
        /// Gets the name of the ingredient. This property represents the name of the ingredient, allowing it to be
        /// identified and distinguished from other ingredients. The Name property is typically set during the
        /// initialization of the ingredient.
        /// </summary>
        public string Name { get; private set; }
        
        /// <summary>
        /// Gets the quantity of the ingredient. This property represents the amount or measurement of the ingredient.
        /// The Quantity property is typically set during the initialization of the ingredient.
        /// </summary>
        public string Quantity { get; private set; }

        /// <summary>
        /// Initializes a new instance of the Ingredient class with the specified name and quantity. This constructor
        /// ensures that each ingredient has a defined name and quantity, allowing it to be used in meal preparation and planning. 
        /// </summary>
        /// <param name="name">The name of the ingredient.</param>
        /// <param name="quantity">The quantity of the ingredient.</param>
        public Ingredient(string name, string quantity)
        {
            Name = name;
            Quantity = quantity;
        }
    }
}