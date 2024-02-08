using ConsoleTables;

public static class TableGenerator
{
    public static void PrintTable(string[] arguments)
    {
        string[] items = arguments.Prepend("v PC \\ User >").ToArray();
        var table = new ConsoleTable(items);

        for(int i = 0; i < arguments.Length; i++)
        {
            var row = new string[arguments.Length + 1];
            row[0] = arguments[i];

            for(int j = 0; j < arguments.Length; j++)
            {
                row[j + 1] = Enum.GetName(typeof(GameResultEnum), StartGame.Start(i, j, arguments.Length));
            }

            table.AddRow(row.ToArray());
        }

        table.Write(Format.Alternative);
    }
}