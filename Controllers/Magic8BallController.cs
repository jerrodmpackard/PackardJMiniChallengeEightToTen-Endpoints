using Microsoft.AspNetCore.Mvc;
using PackardJMiniChallengeEightToTen_Endpoints.Services.Magic8Ball;

namespace PackardJMiniChallengeEightToTen_Endpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class Magic8BallController : Controller
{
    private readonly IMagic8BallService _magic8BallService;

    public Magic8BallController(IMagic8BallService magic8BallService)
    {
        _magic8BallService = magic8BallService;
    }

    [HttpGet]
    [Route("EnterAQuestion/{question}")]
    public string Magic8Ball(string question)
    {
        return _magic8BallService.Magic8Ball(question);
    }
}
