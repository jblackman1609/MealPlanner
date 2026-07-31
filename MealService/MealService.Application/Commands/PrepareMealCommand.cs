using MealPlanner.MealService.Domain.Entities;
using MealPlanner.MealService.Domain.Enums;
using MealPlanner.SharedKernel.Application;

namespace MealPlanner.MealService.Application.Commands;

public record PrepareMealCommand(
    MealTypes MealType,
    Recipe Recipe) : IRequest<Response<Meal>>;