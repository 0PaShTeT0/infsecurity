using System.Security.Cryptography;


public class Rand_Crypto
{
    public static byte[] GenerateRandNum()
    {
        using (var randomNumberGenerator = RandomNumberGenerator.Create())
        {
            int bit = 64;
            var randomNumber = new byte[bit];
            randomNumberGenerator.GetBytes(randomNumber);
            return randomNumber;
        }
    }
    public static void Main()
    {
        int c = 1;
        int n;

        Console.Write("Write number");
        Console.WriteLine();
        n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var rnd = GenerateRandNum();
            Console.Write(c + ". ");
            Console.WriteLine(Convert.ToBase64String(rnd));
            c++;
        }
        Console.ReadLine();
    }
}
