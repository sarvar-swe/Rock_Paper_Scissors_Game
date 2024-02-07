public static class Error
{
    public static void ErrorMessage(Enum errorType)
    {
        if(errorType.Equals(ErrorEnum.InvalidLenght))
        {
            Console.WriteLine("Invalid options: please enter odd number of moves, and the number of moves should be enqual or larger than 3\n");
            ExampleMessage();
        }

        if(errorType.Equals(ErrorEnum.InvalidArguments))
        {
            Console.WriteLine("Invalid options: all moves must be distinct\n");
            ExampleMessage();
        }
    }

    private static void ExampleMessage()
    {
        Console.WriteLine("Example:\nRock Paper Scissors or\nRock Paper Scissors Lizard Spock or\nRock Paper 3 4 5 or\n1 2 3 4 5 6 7 8 9\n");
    }
}