using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine()
                .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int sum = int.Parse(Console.ReadLine());
            string magicSumNumbers = string.Empty;

            for (int i = 0; i < array.Length; i++)
            {

                int currentNumber = array[i];
                int[] tempArray = array.Skip(i + 1).ToArray();

                for (int j = 0; j < tempArray.Length; j++)
                {

                    if (currentNumber + tempArray[j] == sum)
                    {

                        magicSumNumbers = currentNumber + " " + tempArray[j];
                        Console.WriteLine(magicSumNumbers);

                    }
                    else
                    {

                        magicSumNumbers = string.Empty;

                    }
                }

            }

        }
    }
}
