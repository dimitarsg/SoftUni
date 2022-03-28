using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> charsCount = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                int curentCharsCount = 0;

                if (currentChar != ' ')
                {
                    curentCharsCount = input.Count(c => c == currentChar);

                    if (!charsCount.ContainsKey(currentChar.ToString()))
                    {
                        charsCount.Add(currentChar.ToString(), curentCharsCount);
                    }
                }
            }

            foreach (var charItem in charsCount)
            {
                Console.WriteLine($"{charItem.Key} -> {charItem.Value}");
            }
        }
    }
}
