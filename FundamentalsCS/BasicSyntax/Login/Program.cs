using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string userPassword = string.Empty;
            string correctPassword = string.Empty;
            int attempt = 0;


            for (int i = userName.Length - 1; i >= 0; i--)
            {

                correctPassword += userName[i];

            }

            while (userPassword != correctPassword)
            {

                userPassword = Console.ReadLine();
                attempt += 1;

                if (attempt != 4 && (userPassword != correctPassword))
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }

                if (attempt == 4 && (userPassword != correctPassword))
                {
                    Console.WriteLine($"User {userName} blocked!");
                    break;
                }
            }

            if (userPassword == correctPassword)
            {
                Console.WriteLine($"User {userName} logged in.");
            }
        }
    }
}
