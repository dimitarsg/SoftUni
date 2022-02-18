using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initialArray = Console
                .ReadLine()
                .Split('|', (char)StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> formatedArray = new List<string>();

            foreach (var item in initialArray)
            {
                List<string> tempArray = item
                    .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
                    .Select(e => e.Trim())
                    .ToList()
                    .Where(e => !string.IsNullOrWhiteSpace(e))
                    .ToList();
                string currentElement = string.Join(" ", tempArray).Trim();
                formatedArray.Add(currentElement);
            }

            formatedArray.Reverse();
            Console.WriteLine(string.Join(" ", formatedArray).Trim());

        }
    }
}
