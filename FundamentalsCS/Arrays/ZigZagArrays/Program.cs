using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int rowsCount = int.Parse(Console.ReadLine());
            int[] firstArray = new int[rowsCount];
            int[] secondArray = new int[rowsCount];

            for (int i = 0; i < rowsCount; i++)
            {

                int[] rowData = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                int firstNumber = rowData[0];
                int secondNumber = rowData[1];

                if (i % 2 == 0)
                {

                    firstArray[i] = firstNumber;
                    secondArray[i] = secondNumber;

                }
                else
                {

                    firstArray[i] = secondNumber;
                    secondArray[i] = firstNumber;

                }

            }

            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));

        }
    }
}
