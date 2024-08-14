Random samBot = new Random();

string playerGuess = " ";
string playerAnswer = " ";
int playerScore = 0;

string? readResult;
bool gameEnd = false;

while (gameEnd != true)
{
    Console.WriteLine("Players, your question is: Yes, or No.");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        playerGuess = readResult.ToLower().Trim();
    }

    if ((playerGuess != "y") && (playerGuess != "yes") && (playerGuess != "n") && (playerGuess != "no"))
    {
        Console.WriteLine("Oooh, sorry, player. That's not a valid answer.");
        gameEnd = true;
    }
    else
    {
        string samAnswer = " ";
        int samRandom = samBot.Next(2);

        if (samRandom == 1)
            samAnswer = "Yes";
        else
            samAnswer = "No";

        if (playerGuess == "yes" || playerGuess == "y")
        {
                playerAnswer = "Yes";
        }
        else if (playerGuess == "no" || playerGuess == "n")
        {
                playerAnswer = "No";
        }

        if (samAnswer == playerAnswer)
        {
            playerScore++;
            Console.WriteLine($"The answer is {samAnswer}. That is a point for you, player, bringing your total to {playerScore}.");
        }
        else
        {
            Console.WriteLine($"Ooh, sorry, player. The correct answer was {samAnswer}. No points for you this round.");
        }

    }
}