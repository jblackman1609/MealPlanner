using MealPlanner.SharedKernel.Domain;
using MealPlanner.MealService.Domain.Enums;

namespace MealPlanner.MealService.Domain.Entities;

public class Meal : AggregateRoot
{
    public Recipe Recipe { get; private set; }
    public MealTypes MealType { get; private set; }
    public Meal(Guid id, Recipe recipe, MealTypes mealType) : base(id)
    {
        Recipe = recipe;
        MealType = mealType;
    }
}