using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] intArray = Console.ReadLine().Split(' ', (char)StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string[] finalArray = new string[] { };

            for (int i = 0; i < intArray.Length - 1; i++)
            {

                bool isGreater = false;

                for (int j = i + 1; j < intArray.Length; j++)
                {

                    if (intArray[i] > intArray[j])
                    {

                        isGreater = true;

                    }
                    else
                    {

                        isGreater = false;

                    }

                }

                if (isGreater)
                {

                    Console.Write(intArray[i] + " ");

                }
            }

            Console.Write(intArray[intArray.Length - 1]);
            Console.WriteLine();

        }
    }
}
