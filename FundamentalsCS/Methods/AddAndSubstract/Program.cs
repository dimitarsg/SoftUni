using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());
            int thirdInt = int.Parse(Console.ReadLine());

            Console.WriteLine(SumIntegers(firstInt, secondInt, thirdInt));

        }

        static int SumIntegers(int firstInt, int secondInt, int thirdInt)
        {

            int sum = firstInt + secondInt;
            int total = SubtractIntegers(sum, thirdInt);

            return total;

        }

        static int SubtractIntegers(int intSum, int thirdInt)
        {

            int total = intSum - thirdInt;

            return total;

        }

    }
}
