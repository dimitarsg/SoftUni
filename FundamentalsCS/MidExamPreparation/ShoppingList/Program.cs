using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> groceriesList = Console.ReadLine()
                .Split('!', (char)StringSplitOptions.RemoveEmptyEntries)
                .Select(e => e.Trim())
                .ToList()
                .Where(e => !string.IsNullOrWhiteSpace(e))
                .ToList();


            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Go Shopping!")
                {
                    break;
                }

                string[] commandArray = command
                    .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
                .Select(e => e.Trim())
                .ToArray()
                .Where(e => !string.IsNullOrWhiteSpace(e))
                .ToArray();

                switch (commandArray[0])
                {
                    case "Urgent":
                        if (!groceriesList.Contains(commandArray[1]))
                        {
                            groceriesList.Insert(0, commandArray[1]);
                        }
                        break;

                    case "Unnecessary":
                        if (groceriesList.Contains(commandArray[1]))
                        {
                            groceriesList.Remove(commandArray[1]);
                        }
                        break;

                    case "Correct":
                        if (groceriesList.Contains(commandArray[1]))
                        {
                            groceriesList[groceriesList.IndexOf(commandArray[1])] = commandArray[2];
                        }
                        break;

                    case "Rearrange":
                        if (groceriesList.Contains(commandArray[1]))
                        {
                            string item = commandArray[1];
                            groceriesList.Remove(item);
                            groceriesList.Add(item);
                        }
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", groceriesList).Trim(',').Trim(' '));
        }
    }
}
