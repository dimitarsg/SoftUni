using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> heartsPerHouse = Console.ReadLine()
                .Split('@', (char)StringSplitOptions.RemoveEmptyEntries)
                .Select(e => e.Trim())
                .ToList()
                .Where(e => !string.IsNullOrWhiteSpace(e))
                .Select(int.Parse)
                .ToList();
            int lastPosition = 0;
            int successfulDeliveries = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Love!")
                {
                    break;
                }

                string[] jumpData = command
                    .Split(' ')
                    .ToArray();
                lastPosition += int.Parse(jumpData[1]);

                if (lastPosition >= heartsPerHouse.Count || lastPosition < 0)
                {
                    lastPosition = 0;
                }

                int currentPosition = heartsPerHouse[lastPosition];

                if (currentPosition == 0)
                {
                    Console.WriteLine($"Place {lastPosition} already had Valentine's day.");
                }

                if (currentPosition - 2 == 0)
                {
                    heartsPerHouse[lastPosition] -= 2;
                    Console.WriteLine($"Place {lastPosition} has Valentine's day.");
                    successfulDeliveries++;
                }

                if (currentPosition - 2 > 0)
                {
                    heartsPerHouse[lastPosition] -= 2;
                }
            }

            if (successfulDeliveries == heartsPerHouse.Count)
            {
                Console.WriteLine("Mission was successful.");
                return;
            }

            Console.WriteLine($"Cupid's last position was {lastPosition}.");
            Console.WriteLine($"Cupid has failed {heartsPerHouse.Count - successfulDeliveries} places.");
        }
    }
}
