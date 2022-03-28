using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (true)
            {
                string inputCommand = Console.ReadLine();

                if (inputCommand.ToLower() == "end")
                {
                    break;
                }

                List<string> currentValues = inputCommand
                    .Split(new string[] { " : " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (!courses.ContainsKey(currentValues[0]))
                {
                    List<string> currentList = new List<string>();
                    currentList.Add(currentValues[1]);
                    courses.Add(currentValues[0], currentList);
                }
                else
                {
                    courses[currentValues[0]].Add(currentValues[1]);
                }
            }

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {string.Join("", student)}");
                }
            }
        }
    }
}
