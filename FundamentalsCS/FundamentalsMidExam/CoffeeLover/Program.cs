using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeLover
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> coffeeList = Console.ReadLine()
                .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
                .Select(e => e.Trim())
                .ToList()
                .Where(e => !string.IsNullOrWhiteSpace(e))
                .ToList();
            string commandsCount = Console.ReadLine();
            double commandsCountDouble = 0;
            int commandsCountInt = 0;
            bool isCommandNumber = double.TryParse(commandsCount, out commandsCountDouble);

            if (isCommandNumber)
            {
                commandsCountInt = Convert.ToInt32(commandsCountDouble);

                for (int i = 1; i <= commandsCountInt; i++)
                {
                    string command = Console.ReadLine();
                    int intIndexResultFirst = 0;
                    int intIndexResultSecond = 0;

                    if (command.Length > 0)
                    {
                        List<string> commandArray = command
                            .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
                        .Select(e => e.Trim())
                        .ToList()
                        .Where(e => !string.IsNullOrWhiteSpace(e))
                        .ToList();

                        switch (commandArray[0])
                        {
                            case "Include":
                                if (commandArray.Count != 2)
                                {
                                    break;
                                }

                                coffeeList.Add(commandArray[1]);
                                break;

                            case "Remove":
                                if (commandArray.Count != 3)
                                {
                                    break;
                                }

                                double indexResult = 0;
                                bool result = double.TryParse(commandArray[2], out indexResult);
                                if (!result)
                                {
                                    break;
                                }
                                else
                                {
                                    intIndexResultFirst = Convert.ToInt32(indexResult);
                                }

                                if (coffeeList.Count < intIndexResultFirst || intIndexResultFirst < 0 || intIndexResultFirst > coffeeList.Count - 1)
                                {
                                    break;
                                }

                                if (commandArray[1] == "first")
                                {
                                    coffeeList.RemoveRange(0, intIndexResultFirst);
                                }

                                if (commandArray[1] == "last")
                                {
                                    if (intIndexResultFirst == 1)
                                    {
                                        coffeeList.RemoveAt(coffeeList.Count - 1);
                                    }

                                    if (intIndexResultFirst > 1)
                                    {
                                        coffeeList.RemoveRange(coffeeList.Count - intIndexResultFirst, coffeeList.Count - 1);
                                    }
                                }
                                break;

                            case "Reverse":
                                if (commandArray.Count != 1)
                                {
                                    break;
                                }
                                coffeeList.Reverse();
                                break;

                            case "Prefer":
                                if (commandArray.Count != 3)
                                {
                                    break;
                                }

                                double indexResultFirst = 0;
                                double indexResultSecond = 0;
                                bool resultFirstIndex = double.TryParse(commandArray[1], out indexResultFirst);
                                bool resultSecondIndex = double.TryParse(commandArray[2], out indexResultSecond);

                                if (!resultFirstIndex || !resultSecondIndex)
                                {
                                    break;
                                }
                                else
                                {
                                    intIndexResultFirst = Convert.ToInt32(indexResultFirst);
                                    intIndexResultSecond = Convert.ToInt32(indexResultSecond);
                                }

                                if (coffeeList.Count < intIndexResultFirst || intIndexResultFirst < 0 || intIndexResultFirst > coffeeList.Count - 1 || coffeeList.Count < intIndexResultSecond || intIndexResultSecond < 0 || intIndexResultSecond > coffeeList.Count - 1)
                                {
                                    break;
                                }

                                int firstIndex = intIndexResultFirst;
                                int secondIndex = intIndexResultSecond;
                                int biggestIndex = Math.Max(firstIndex, secondIndex);

                                if (coffeeList.Count - 1 >= biggestIndex)
                                {
                                    string tempValue = coffeeList[firstIndex];
                                    coffeeList[firstIndex] = coffeeList[secondIndex];
                                    coffeeList[secondIndex] = tempValue;
                                }
                                break;

                            default:
                                break;
                        }
                    }
                }
            }

            Console.WriteLine("Coffees:");
            Console.WriteLine(string.Join(" ", coffeeList).Trim(' '));
        }
    }
}

