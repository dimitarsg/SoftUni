using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console
                .ReadLine();
            string result = string.Empty;
            int lastIndex = inputString.Length - 1;

            for (int i = 0; i < lastIndex; i++)
            {
                char currentChar = inputString[i];
                int nextIndex = i + 1;
                char nextChar = inputString[nextIndex];

                if (currentChar != nextChar)
                {
                    result += currentChar;
                }

                if (i == lastIndex - 1)
                {
                    result += nextChar;
                }
            }

            Console.WriteLine(result);
        }
    }
}
