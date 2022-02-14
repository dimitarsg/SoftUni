using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {

            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            Console.WriteLine(CharactersRange(firstChar, secondChar));

        }

        static string CharactersRange(char firstChar, char secondChar)
        {

            if (firstChar > secondChar)
            {

                char firstCharTemp = firstChar;
                firstChar = secondChar;
                secondChar = firstCharTemp;

            }

            char[] chars = new char[secondChar - firstChar];
            string joinedChars = string.Empty;

            for (int i = 0; i < chars.Length - 1; i++)
            {

                chars[i] = Convert.ToChar(firstChar + i + 1);

            }

            joinedChars = string.Join(" ", chars);
            joinedChars = joinedChars.Remove(joinedChars.Length - 1);
            return joinedChars;

        }
    }
}
