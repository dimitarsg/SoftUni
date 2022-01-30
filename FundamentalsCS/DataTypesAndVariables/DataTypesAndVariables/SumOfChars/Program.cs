using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {

            int charCount = int.Parse(Console.ReadLine());
            int charSum = 0;

            for (int i = 0; i < charCount; i++)
            {

                char inputChar = char.Parse(Console.ReadLine());
                int charNumber = (int)inputChar;

                charSum += charNumber;

            }

            Console.WriteLine($"The sum equals: {charSum}");

        }
    }
}
