using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberOfRotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfRotations; i++)
            {

                int firstElement = array[0];

                for (int j = 0; j <= array.Length - 2; j++)
                {

                    array[j] = array[j + 1];

                }

                array[array.Length - 1] = firstElement;

            }

            Console.WriteLine(string.Join(" ", array));

        }
    }
}
