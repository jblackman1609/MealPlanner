namespace MealService.Domain.Entities
{
    /// <summary>
    /// Represents a recipe in the meal service domain. A recipe is an entity that encapsulates the name of 
    /// the recipe and a list of ingredients required to prepare the meal. The Name property represents the 
    /// name of the recipe, while the Ingredients property holds a collection of Ingredient value objects that 
    /// define the components of the recipe. The constructor initializes the Id, Name, and Ingredients properties 
    /// with the provided values, ensuring that each recipe has a unique identifier, a defined name, and a list of 
    /// ingredients.
    /// </summary>
    public class Recipe : Entity
    {
        private readonly List<Ingredient> _ingredients = new();
        /// <summary>
        /// Gets the name of the recipe. This property represents the name of the recipe, allowing it to be identified
        /// and distinguished from other recipes. The Name property is typically set during the initialization of the
        /// recipe.
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Gets the list of ingredients required for the recipe. This property holds a collection of Ingredient value objects 
        /// that define the components of the recipe. The Ingredients property is typically set during the initialization of the 
        /// recipe and can be used to access and utilize the ingredients when preparing the meal.
        /// </summary>
        public IReadOnlyCollection<Ingredient> Ingredients => _ingredients.AsReadOnly();

        /// <summary>
        /// Initializes a new instance of the Recipe class with the specified unique identifier, name, and list of ingredients. 
        /// This constructor ensures that each recipe has a unique identifier, a defined name, and a list of ingredients, allowing 
        /// it to be used in meal planning and preparation.
        /// </summary>
        /// <param name="id">The unique identifier for the recipe.</param>
        /// <param name="name">The name of the recipe.</param>
        /// <param name="ingredients">The list of ingredients required for the recipe.</param>
        public Recipe(Guid id, string name, List<Ingredient> ingredients) : base(id)
        {
            Name = name;
            _ingredients.AddRange(ingredients);
        }

        /// <summary>
        /// Adds an ingredient to the list of ingredients required for the recipe. This method allows adding a new ingredient
        /// to the recipe, enabling the recipe to be modified and updated with additional components as needed. The ingredient 
        /// is typically added to the collection using this method, ensuring that it is properly tracked and managed within the 
        /// recipe.
        /// </summary>
        /// <param name="ingredient"></param>
        public void Add(Ingredient ingredient)
        {
            _ingredients.Add(ingredient);
        }
    }
}