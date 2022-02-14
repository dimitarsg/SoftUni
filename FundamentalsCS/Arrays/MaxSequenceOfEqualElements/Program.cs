using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] initialArray = Console.ReadLine()
                .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sequenceCounter = 0;
            int longestSequenceCount = 0;
            string numbers = string.Empty;

            for (int i = 0; i < initialArray.Length - 1; i++)
            {

                if (initialArray[i] == initialArray[i + 1])
                {

                    sequenceCounter++;

                    if (sequenceCounter > longestSequenceCount)
                    {

                        longestSequenceCount = sequenceCounter;
                        numbers = initialArray[i].ToString();

                    }

                }
                else
                {

                    sequenceCounter = 0;

                }

            }

            for (int i = 0; i <= longestSequenceCount; i++)
            {

                Console.Write(numbers + " ");

            }

            Console.WriteLine();

        }
    }
}
