using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm4_task3_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cryptographer crypt = new Cryptographer();

            crypt.CryptKey = 4;

            //string message = "\nExperience is the teacher of all things...\n\n\t\t\tGaius Julius Caesar";

            Console.WriteLine("Enter message you want to encrypt here: ");
            string message = Console.ReadLine();

            crypt.Encrypt(message);
            Console.WriteLine($"\n\tEncrypted message:\n{crypt.CryptText}");

            crypt.Decrypt();
            Console.WriteLine($"\n\tDecrypted message:\n{crypt.CryptText}\n");
        }
    }
}
