public static class Validation
{
    public static bool IsValidLength(string[] arguments)
        => arguments.Length >= 3 && arguments.Length % 2 == 1;
    
    public static bool IsValidArguments(string[] arguments)
        => arguments.Length == arguments.Distinct().Count();
    
    public static bool IsValidInput(int argumentsLength, string input)
    {
        if(!IsNumber(input))
            return false;
        
        int temp = Convert.ToInt32(input);
        if (temp < 0 || temp > argumentsLength)
            return false;
        
        return true;
    }

    private static bool IsNumber(string input)
    {
        for(int i = 0; i < input.Length; i++)
        {
            if(!Char.IsDigit(input[i]))
            {
                return false;
            }
        }
        return true;
    }
}