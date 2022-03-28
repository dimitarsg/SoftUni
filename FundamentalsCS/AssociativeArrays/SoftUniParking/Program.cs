using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());
            Dictionary<string, string> userCar = new Dictionary<string, string>();

            for (int i = 0; i < commandsCount; i++)
            {
                string[] commands = Console.ReadLine()
                    .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string currentCommand = commands[0];
                string currentUserName = commands[1];
                string currentLicensePlate = string.Empty;
                if (commands.Length == 3)
                {
                    currentLicensePlate = commands[2];
                }

                switch (currentCommand)
                {
                    case "register":
                        if (userCar.ContainsKey(currentUserName))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {userCar[currentUserName]}");
                        }
                        else
                        {
                            userCar.Add(currentUserName, currentLicensePlate);
                            Console.WriteLine($"{currentUserName} registered {currentLicensePlate} successfully");
                        }
                        break;

                    case "unregister":
                        if (userCar.ContainsKey(currentUserName))
                        {
                            userCar.Remove(currentUserName);
                            Console.WriteLine($"{currentUserName} unregistered successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {currentUserName} not found");
                        }
                        break;

                    default:
                        break;
                }
            }

            foreach (var user in userCar)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
