using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersArray = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string command = string.Empty;

            while (command != "End")
            {
                command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                List<string> commandList = command
                    .Split(' ')
                    .ToList();

                if (commandList.Count > 0)
                {
                    switch (commandList[0])
                    {
                        case "Add":
                            numbersArray.Add(int.Parse(commandList[1]));
                            break;

                        case "Insert":
                            if (int.Parse(commandList[2]) <= numbersArray.Count - 1)
                            {
                                numbersArray.Insert(int.Parse(commandList[2]), int.Parse(commandList[1]));
                            }
                            else
                            {
                                Console.WriteLine("Invalid index");
                            }
                            break;

                        case "Remove":
                            if (int.Parse(commandList[1]) <= numbersArray.Count - 1)
                            {
                                numbersArray.RemoveAt(int.Parse(commandList[1]));
                            }
                            else
                            {
                                Console.WriteLine("Invalid index");
                            }
                            break;

                        case "Shift":
                            int repeatsCount = int.Parse(commandList[2]);

                            if (commandList[1] == "left")
                            {
                                for (int i = 0; i < repeatsCount; i++)
                                {
                                    numbersArray.Add(numbersArray[0]);
                                    numbersArray.RemoveAt(0);
                                }
                            }

                            if (commandList[1] == "right")
                            {
                                for (int i = 0; i < repeatsCount; i++)
                                {
                                    numbersArray.Insert(0, numbersArray[numbersArray.Count - 1]);
                                    numbersArray.RemoveAt(numbersArray.Count - 1);
                                }
                            }
                            break;

                        default:
                            break;
                    }
                }

            }

            Console.WriteLine(string.Join(" ", numbersArray));

        }
    }
}
