using System.Security.Cryptography;
using System.Text;

public static class GameSecurity
{
    public static byte[] GenerateKey()
    {
        var rng = RandomNumberGenerator.Create();
        byte[] key = new byte[32];
        rng.GetBytes(key);
        return key;
    }

    public static string GenerateHMAC(byte[] key, string move)
    {
        byte[] moveBytes = Encoding.UTF8.GetBytes(move);

        using var hmac = new HMACSHA256(key);
        byte[] hmacBytes = hmac.ComputeHash(moveBytes);
        string resultHash = BitConverter.ToString(hmacBytes).Replace("-", "");

        return resultHash;
    }
}