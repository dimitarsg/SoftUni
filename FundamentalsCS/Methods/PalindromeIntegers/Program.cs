using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputNumber = string.Empty;

            while (inputNumber != "END")
            {

                inputNumber = Console.ReadLine();

                if (inputNumber == "END")
                {
                    break;
                }

                Console.WriteLine(IsPalindromeNumber(inputNumber));

            }

        }

        static bool IsPalindromeNumber(string input)
        {

            char[] numberChars = input.ToCharArray();
            int[] numbers = Array.ConvertAll(numberChars, c => (int)Char.GetNumericValue(c));

            if (numbers[0] == numbers[numbers.Length - 1])
            {

                return true;

            }

            return false;

        }

    }
}
