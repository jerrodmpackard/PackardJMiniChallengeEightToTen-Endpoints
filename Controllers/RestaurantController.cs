using Microsoft.AspNetCore.Mvc;
using PackardJMiniChallengeEightToTen_Endpoints.Services.Restaurant;

namespace PackardJMiniChallengeEightToTen_Endpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class RestaurantController : Controller
{
    private readonly IRestaurantService _restaurantService;

    public RestaurantController(IRestaurantService restaurantService)
    {
        _restaurantService = restaurantService;
    }

    [HttpGet]
    [Route("EnterFastFoodRestaurantOrPizza/{userChoice}")]
    public string RestaurantPicker(string userChoice)
    {
        return _restaurantService.RestaurantPicker(userChoice);
    }
}
