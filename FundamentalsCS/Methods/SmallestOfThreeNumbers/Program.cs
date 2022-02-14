using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {

                numbers[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine(MinNumber(numbers));

        }

        static int MinNumber(int[] numbers)
        {

            int minNumber = numbers.Min();

            return minNumber;

        }
    }
}
