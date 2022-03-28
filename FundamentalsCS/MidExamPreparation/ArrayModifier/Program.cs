using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputArray = Console.ReadLine()
                .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
                .Select(e => e.Trim())
                .ToList()
                .Where(e => !string.IsNullOrWhiteSpace(e))
                .Select(int.Parse)
                .ToList();


            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
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
                    case "swap":
                        int firstIndex = int.Parse(commandArray[1]);
                        int secondIndex = int.Parse(commandArray[2]);
                        int firstNumber = inputArray[firstIndex];
                        int secondNumber = inputArray[secondIndex];
                        inputArray[firstIndex] = secondNumber;
                        inputArray[secondIndex] = firstNumber;
                        break;

                    case "multiply":
                        firstIndex = int.Parse(commandArray[1]);
                        secondIndex = int.Parse(commandArray[2]);
                        firstNumber = inputArray[firstIndex];
                        secondNumber = inputArray[secondIndex];
                        int result = firstNumber * secondNumber;
                        inputArray[firstIndex] = result;
                        break;

                    case "decrease":
                        for (int i = 0; i < inputArray.Count; i++)
                        {
                            inputArray[i]--;
                        }
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", inputArray).Trim(',').Trim(' '));
        }

    }
}

