using System;
using System.Security.Cryptography;
using System.Text;



namespace hesh
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Write the massage to hesh:");
            Console.WriteLine("--------------------");

            string str = Console.ReadLine();

            Console.WriteLine("--------------------");
            Console.WriteLine("1 -> Hash using MD5");
            Console.WriteLine("2 -> Hash using SHA");
            Console.WriteLine("--------------------");
            Console.WriteLine("Choose your variant: ");

            int num = Convert.ToInt32(Console.ReadLine());

            byte[] message = Encoding.Unicode.GetBytes(str);
            var strmd5 = ComputeHashMd5(message);
            var sha256 = ComputeHashSha256(message);
            var sha1 = ComputeHashSHA1(message);
            var sha384 = ComputeHashSHA384(message);
            var sha512 = ComputeHashSHA512(message);
            Guid guid1 = new Guid(strmd5);

            static byte[] ComputeHashMd5(byte[] input)
            {
                var md5 = MD5.Create();
                return md5.ComputeHash(input);

            }

            static byte[] ComputeHashSha256(byte[] input)
            {
                using (var sha256 = SHA256.Create())
                {
                    return sha256.ComputeHash(input);
                }
            }

            static byte[] ComputeHashSHA1(byte[] input)
            {
                using (var sha1 = SHA1.Create())
                {
                    return sha1.ComputeHash(input);
                }
            }

            static byte[] ComputeHashSHA512(byte[] input)
            {
                using (var sha512 = SHA512.Create())
                {
                    return sha512.ComputeHash(input);
                }
            }

            static byte[] ComputeHashSHA384(byte[] input)
            {
                using (var sha384 = SHA384.Create())
                {
                    return sha384.ComputeHash(input);
                }
            }

            if(num == 1)
            {
                Console.WriteLine($"Hash MD5: {Convert.ToBase64String(strmd5)}\nGUID:{guid1}\n-------------------------");
            }
            if(num == 2)
            {
                Console.WriteLine($"Hash SHA1:{Convert.ToBase64String(sha1)}\n-------------------------\nHash SHA256:{Convert.ToBase64String(sha256)}\n-------------------------\nHash SHA384:{Convert.ToBase64String(sha384)}\n-------------------------\nHash SHA512:{Convert.ToBase64String(sha512)}\n");
            }
        }

    }
}