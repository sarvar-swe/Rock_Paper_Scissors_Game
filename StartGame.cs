public static class StartGame
{
    public static Enum Start(int userMove, int computerMove)
    {
        int result = userMove - computerMove;

        if (result > 0)
        {
            return GameResultEnum.WIN;
        }
        else if (result < 0)
        {
            return GameResultEnum.LOSE;
        }

        return GameResultEnum.DRAW;
    }

    public static bool ResultOfGame(int userMove, int computerMove)
    {
        if(Start(userMove, computerMove).Equals(GameResultEnum.WIN))
            Console.WriteLine("You win!");
        
        if(Start(userMove, computerMove).Equals(GameResultEnum.LOSE))
            Console.WriteLine("You lose!");
        
        if(Start(userMove, computerMove).Equals(GameResultEnum.DRAW))
            Console.WriteLine("Draw!");
        
        return true;
    }
}