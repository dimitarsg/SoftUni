using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine().Split(' ', (char)StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            int magicNumberIndex = 0;
            bool indexFound = false;

            for (int i = 1; i < array.Length; i++)
            {

                for (int j = i + 1; j < array.Length; j++)
                {

                    rightSum += array[j];

                }

                for (int k = i - 1; k >= 0; k--)
                {

                    leftSum += array[k];

                }

                if (leftSum == rightSum)
                {

                    indexFound = true;
                    magicNumberIndex = i;

                }
                else
                {

                    leftSum = 0;
                    rightSum = 0;

                }

            }

            if (indexFound)
            {

                Console.WriteLine(magicNumberIndex);

            }
            else if (array.Length == 1)
            {

                Console.WriteLine(0);

            }
            else
            {

                Console.WriteLine("no");

            }

        }
    }
}
