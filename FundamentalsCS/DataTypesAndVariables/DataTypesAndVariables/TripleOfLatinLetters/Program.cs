using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {

            int charCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < charCount; i++)
            {

                for (int j = 0; j < charCount; j++)
                {

                    for (int k = 0; k < charCount; k++)
                    {

                        char firstChar = (char)('a' + i);
                        char secondChar = (char)('a' + j);
                        char thirdChar = (char)('a' + k);

                        Console.WriteLine($"{firstChar}" + $"{secondChar}" + $"{thirdChar}");

                    }

                }

            }

        }
    }
}
