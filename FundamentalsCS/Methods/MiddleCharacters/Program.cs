using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {

            string middleChar = MiddleCharacters(Console.ReadLine());
            Console.WriteLine(middleChar);

        }

        static string MiddleCharacters(string inputString)
        {

            string middleString;
            char[] charArray = inputString.ToCharArray();

            if (inputString.Length % 2 == 0)
            {

                middleString = string.Join("", charArray[(charArray.Length / 2) - 1], charArray[charArray.Length / 2]);

            }
            else
            {

                middleString = string.Join("" ,charArray[Math.Abs(charArray.Length / 2)]);

            }

            return middleString;

        }

    }
}
