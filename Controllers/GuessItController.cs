using Microsoft.AspNetCore.Mvc;
using PackardJMiniChallengeEightToTen_Endpoints.Services.GuessIt;

namespace PackardJMiniChallengeEightToTen_Endpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class GuessItController : Controller
{
    private readonly IGuessItService _guessItService;

    public GuessItController(IGuessItService guessItService)
    {
        _guessItService = guessItService;
    }

    [HttpGet]
    [Route("EasyMode/{easyGuess}")]
    public string EasyGuessIt(string easyGuess)
    {
        return _guessItService.EasyGuessIt(easyGuess);
    }

    [HttpGet]
    [Route("MediumMode/{mediumGuess}")]
    public string MediumGuessIt(string mediumGuess)
    {
        return _guessItService.MediumGuessIt(mediumGuess);
    }

    [HttpGet]
    [Route("HardMode/{hardGuess}")]
    public string HardGuessIt(string hardGuess)
    {
        return _guessItService.HardGuessIt(hardGuess);
    }
}
