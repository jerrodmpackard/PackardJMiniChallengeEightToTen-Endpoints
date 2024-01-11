namespace PackardJMiniChallengeEightToTen_Endpoints.Services.GuessIt;

public interface IGuessItService
{
    public string EasyGuessIt(string easyGuess);
    public string MediumGuessIt(string mediumGuess);
    public string HardGuessIt(string hardGuess);
}
