using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> integersArray = Console.ReadLine()
                .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
                .Select(e => e.Trim())
                .ToList()
                .Where(e => !string.IsNullOrWhiteSpace(e))
                .ToList();
            string command = string.Empty;
            int movesCount = 0;

            while (command.ToLower() != "end" || integersArray.Count == 0)
            {
                command = Console.ReadLine();

                if (command.ToLower() == "end" || integersArray.Count == 0)
                {
                    break;
                }

                movesCount++;
                List<string> indexesToMatch = command
                .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
                .ToList();

                int firstIndex;
                int secondIndex;
                bool successFirstIndex = int.TryParse(indexesToMatch[0], out firstIndex);
                bool successSecondIndex = int.TryParse(indexesToMatch[1], out secondIndex);

                int arrayLength = integersArray.Count - 1;

                if (firstIndex >= 0 && secondIndex >= 0 && firstIndex != secondIndex && firstIndex <= arrayLength && secondIndex <= arrayLength && successFirstIndex && successSecondIndex)
                {
                    if (integersArray[firstIndex] == integersArray[secondIndex])
                    {
                        string numberToRemove = integersArray[firstIndex];
                        Console.WriteLine($"Congrats! You have found matching elements - {numberToRemove}!");
                        integersArray.Remove(numberToRemove);
                        integersArray.Remove(numberToRemove);
                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }
                }
                else
                {
                    integersArray.Insert((integersArray.Count / 2), $"-{movesCount}a");
                    integersArray.Insert((integersArray.Count / 2), $"-{movesCount}a");
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }

            }

            if (command != "end")
            {
                Console.WriteLine($"You have won in {movesCount} turns!");
            }
            else
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(" ", integersArray).Trim());
            }
        }
    }
}
