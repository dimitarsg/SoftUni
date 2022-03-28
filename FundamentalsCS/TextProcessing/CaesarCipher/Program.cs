using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            List<char> encryptedString = new List<char>();

            foreach (var character in inputString)
            {
                encryptedString.Add((char)((int)character + 3));
            }

            Console.WriteLine(string.Join("", encryptedString));
        }
    }
}
