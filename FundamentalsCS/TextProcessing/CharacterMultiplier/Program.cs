using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputStrings = Console.ReadLine()
                .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Console.WriteLine(SumChars(inputStrings[0], inputStrings[1]));
        }

        static int SumChars(string firstString, string secondString)
        {
            int firstStringLength = firstString.Length;
            int secondStringLength = secondString.Length;
            int shortestStringLength = Math.Min(firstStringLength, secondStringLength);
            int totalSum = 0;
            int index = 0;

            for (int i = 0; i < shortestStringLength; i++)
            {
                totalSum += firstString[i] * secondString[i];
                index++;
            }

            if (firstStringLength > secondStringLength)
            {
                for (int i = index; i < firstStringLength; i++)
                {
                    totalSum += firstString[i];
                }
            }
            else if (firstStringLength < secondStringLength)
            {
                for (int i = index; i < secondStringLength; i++)
                {
                    totalSum += secondString[i];
                }
            }

            return totalSum;
        }
    }
}
