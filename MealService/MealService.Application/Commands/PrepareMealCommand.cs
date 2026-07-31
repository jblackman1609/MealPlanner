using MealPlanner.MealService.Domain.Entities;
using MealPlanner.MealService.Domain.Enums;
using MealPlanner.SharedKernel.Application;

namespace MealPlanner.MealService.Application.Commands;

/// <summary>
/// Represents a command to prepare a meal, encapsulating the necessary information such as the meal type and the associated recipe. 
/// This command is used within the meal planning application to initiate the meal preparation process, allowing other components of 
/// the system to respond accordingly. The PrepareMealCommand class implements the IRequest interface, enabling it to be processed
/// to produce a response of type Response<Meal>, which contains the details of the prepared meal.
/// </summary>
/// <param name="MealType"></param>
/// <param name="Recipe"></param>
public record PrepareMealCommand(
    MealTypes MealType,
    Recipe Recipe) : IRequest<Response<Meal>>;