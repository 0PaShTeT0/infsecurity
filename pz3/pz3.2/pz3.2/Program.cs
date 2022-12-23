using System;
using System.Security.Cryptography;
using System.Text;

namespace hash
{
    class Program
    {
        public static void Main()
        {
            String cthash = "po1MVkAE7IjUUwu61XxgNg==";
            String athash = ""; 

            int counter = 0;
            while (athash != cthash)
            {
                byte[] messageArray = Encoding.Unicode.GetBytes(counter.ToString());
                messageArray = ComputeHashMd5(messageArray); 
                athash = Convert.ToBase64String(messageArray);
                Console.WriteLine(cthash + "   "+athash + "----->" + counter);
                counter++;
            }
            Console.WriteLine(counter - 1 + " is password.");

            static byte[] ComputeHashMd5(byte[] input)
            {
                var md5 = MD5.Create();
                return md5.ComputeHash(input);

            }

        }
    }
}