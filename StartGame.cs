public static class StartGame
{
    public static Enum Start(int computerMove, int userMove, int argsLength)
    {
        if(userMove == computerMove)
            return GameResultEnum.DRAW;

        if ((userMove > computerMove && userMove - computerMove <= argsLength / 2) ||
            (userMove < computerMove && computerMove - userMove > argsLength / 2))
        {
            return GameResultEnum.WIN;
        }
        else
        {
            return GameResultEnum.LOSE;
        }
    }

    public static bool ResultOfGame(int computerMove, int userMove, int argsLength)
    {
        if(Start(computerMove, userMove, argsLength).Equals(GameResultEnum.WIN))
            Console.WriteLine("You win!");
        
        if(Start(computerMove, userMove, argsLength).Equals(GameResultEnum.LOSE))
            Console.WriteLine("You lose!");
        
        if(Start(computerMove, userMove, argsLength).Equals(GameResultEnum.DRAW))
            Console.WriteLine("Draw!");
        
        return true;
    }
}