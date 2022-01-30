using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            string number = Console.ReadLine();
            long calculatedNumber = 0;

            for (int i = 0; i <= number.Length - 1; i++)
            {

                char currentChar = number[i];
                int charDigit = (int)currentChar - 48;

                long currentDigitFactorial = 1;
                for (int r = charDigit ; r > 1; r--)
                {

                    currentDigitFactorial *= r;

                }

                calculatedNumber += currentDigitFactorial;

            }

            if (int.Parse(number) == calculatedNumber)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
