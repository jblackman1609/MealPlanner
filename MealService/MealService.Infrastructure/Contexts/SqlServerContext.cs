using MealPlanner.MealService.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace MealPlanner.MealService.Infrastructure.Contexts;

/// <summary>
/// Represents the SQL Server database context for the meal planning application. This context is responsible for 
/// managing the connection to the SQL Server database and providing access to the meal-related data models. It extends 
/// the DbContext class from Entity Framework Core, allowing for interaction with the database using LINQ queries and 
/// other EF Core features. The SqlServerContext class defines a DbSet for MealModel entities, enabling CRUD operations 
/// on meal data within the application.    
/// </summary>
public class SqlServerContext : DbContext
{
    /// <summary>
    /// Initializes a new instance of the SqlServerContext class with the specified options. This constructor is used to 
    /// configure the database context with the provided options, such as the connection string and other EF Core settings.
    /// </summary>
    /// <param name="options"></param>
    public SqlServerContext(DbContextOptions<SqlServerContext> options) : base(options)
    {
    }

    /// <summary>
    /// Gets or sets the DbSet representing the collection of MealModel entities within the database context. This property 
    /// allows for querying and managing meal data in the SQL Server database using Entity Framework Core. The Meals property 
    /// is initialized to null! to indicate that it will be populated by the EF Core framework at runtime, ensuring that it is 
    /// not null when accessed.
    /// </summary>
    public DbSet<MealModel> Meals { get; set; } = null!;

    /// <summary>
    /// Configures the model for the database context using the provided ModelBuilder. This method is called by the EF Core 
    /// framework during the model creation process, allowing for customization of the entity mappings and relationships. 
    /// </summary>
    /// <param name="modelBuilder"></param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<MealModel>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.RecipeModelId).IsRequired();
            entity.Property(e => e.MealType).IsRequired();
            entity.Property(e => e.CreatedAt).IsRequired();
        });
    }
}