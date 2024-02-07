public static class Menu
{
    public static void PrintMenu(string[] arguments)
    {
        Console.WriteLine("Available moves:");

        for (int i = 0; i < arguments.Length; i++)
        {
            Console.WriteLine($"{i + 1} - {arguments[i]}");
        }

        Console.WriteLine("0 - exit");
        Console.WriteLine("? - help");
    }
}