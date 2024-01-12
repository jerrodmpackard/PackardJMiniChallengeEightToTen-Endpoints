namespace PackardJMiniChallengeEightToTen_Endpoints.Services.GuessIt;

public class GuessItService : IGuessItService
{
    public string EasyGuessIt(string easyGuess)
    {
        Random randomClass = new Random();
        int easyRandom = randomClass.Next(1, 11);

        int isANumber = 0;

        bool success = Int32.TryParse(easyGuess, out isANumber);

        if (success && isANumber > 0 && isANumber <= 10)
        {
            if (isANumber == easyRandom)
            {
                return "Congratulations! You win!";
            }
            else if (isANumber < easyRandom)
            {
                return $"{isANumber} is lower than the correct number. The correct number was {easyRandom}.";
            }
            else
            {
                return $"{isANumber} is higher than the correct number. The correct number was {easyRandom}.";
            }
        }
        else
        {
            return "Please make sure you are entering a number between 1 and 10.";
        }
    }

    public string MediumGuessIt(string mediumGuess)
    {
        Random randomClass = new Random();
        int mediumRandom = randomClass.Next(1, 51);

        int isANumber = 0;

        bool success = Int32.TryParse(mediumGuess, out isANumber);

        if (success && isANumber > 0 && isANumber <= 50)
        {
            if (isANumber == mediumRandom)
            {
                return "Congratulations! You win!";
            }
            else if (isANumber < mediumRandom)
            {
                return $"{isANumber} is lower than the correct number. The correct number was {mediumRandom}.";
            }
            else
            {
                return $"{isANumber} is higher than the correct number. The correct number was {mediumRandom}.";
            }
        }
        else
        {
            return "Please make sure you are entering a number between 1 and 50.";
        }
    }

    public string HardGuessIt(string hardGuess)
    {
        Random randomClass = new Random();
        int hardRandom = randomClass.Next(1, 101);

        int isANumber = 0;

        bool success = Int32.TryParse(hardGuess, out isANumber);

        if (success && isANumber > 0 && isANumber <= 100)
        {
            if (isANumber == hardRandom)
            {
                return "Congratulations! You win!";
            }
            else if (isANumber < hardRandom)
            {
                return $"{isANumber} is lower than the correct number. The correct number was {hardRandom}.";
            }
            else
            {
                return $"{isANumber} is higher than the correct number. The correct number was {hardRandom}.";
            }
        }
        else
        {
            return "Please make sure you are entering a number between 1 and 100.";
        }
    }
}
