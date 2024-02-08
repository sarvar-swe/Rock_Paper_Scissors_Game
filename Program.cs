using System.Security.Cryptography;

class Program
{
    public static void Main(string[] args)
    {
        if(!Validation.IsValidLength(args))
        {
            Error.ErrorMessage(ErrorEnum.InvalidLenght);
            return;
        }

        if(!Validation.IsValidArguments(args))
        {
            Error.ErrorMessage(ErrorEnum.InvalidArguments);
            return;
        }

        bool finished = false;
        while(!finished)
        {
            byte[] key = GameSecurity.GenerateKey();
            int computerMove = RandomNumberGenerator.GetInt32(args.Length);
            string hmac = GameSecurity.GenerateHMAC(key, args[computerMove]);

            Console.WriteLine($"HMAC: {hmac}");

            Menu.PrintMenu(args);

            Console.Write("Enter your move: ");

            var input = Console.ReadLine();

            if(input.Equals("0"))
            {
                return;
            }

            if(input.Equals("?"))
            {
                TableGenerator.PrintTable(args);
                continue;
            }
            
            if(Validation.IsValidInput(args.Length, input))
            {
                int userMove = Convert.ToInt32(input);
                Console.WriteLine($"Your move: {args[userMove - 1]}");
                Console.WriteLine($"Computer move: {args[computerMove]}");

                finished = StartGame.ResultOfGame(computerMove, userMove - 1, args.Length);

                Console.WriteLine($"HMAC key: {BitConverter.ToString(key).Replace("-", "")}");
                
            }
        }
    }
}