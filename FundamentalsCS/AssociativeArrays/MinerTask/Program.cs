using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourses = new Dictionary<string, int>();
            int index = 0;
            string resourseValue = string.Empty;

            while (true)
            {
                string inputCommand = Console.ReadLine();

                if (inputCommand.ToLower() == "stop")
                {
                    break;
                }

                index++;

                if (index % 2 == 0)
                {
                    resourses[resourseValue] += int.Parse(inputCommand);
                }
                else
                {
                    if (!resourses.ContainsKey(inputCommand))
                    {
                        resourses.Add(inputCommand, 0);
                    }

                    resourseValue = inputCommand;
                }
            }

            foreach (var item in resourses)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
