using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {

            string number = Console.ReadLine();
            int result = 0;

            for (int i = 0; i < number.Length; i++)
            {

                int numberDigit = (int)number[i] - 48;
                result += numberDigit;

            }

            Console.WriteLine($"{result}");

        }
    }
}
