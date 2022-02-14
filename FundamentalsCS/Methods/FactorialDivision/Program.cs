using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {

            float firstNumber = int.Parse(Console.ReadLine());
            float secondNumber = int.Parse(Console.ReadLine());

            float firstNumFactorial = CalculateFactorial(firstNumber);
            float secondNumFactorial = CalculateFactorial(secondNumber);
            float total = firstNumFactorial / secondNumFactorial;

            Console.WriteLine($"{total:f2}");

        }

        static float CalculateFactorial(float number)
        {

            float factorialCalc = 1;

            for (int i = 1; i <= number; i++)
            {

                factorialCalc *= i;

            }

            return factorialCalc;

        }

    }
}
