using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {

            int sequencesCount = int.Parse(Console.ReadLine());
            int[] samplesArray = new int[sequencesCount];
            string[] sample = new string[] { };
            string dnaSequence = string.Empty;
            int bestStartIndex = 0;
            int bestSequenceSum = 0;
            int bestSequenceNumber = 0;
            string[] bestSample = new string[] { };
            int currentSum = 0;
            int currentIndex = 0;
            int sequenceNumber = 0;

            do
            {

                dnaSequence = Console.ReadLine();

                if (dnaSequence != "Clone them!")
                {

                    sample = dnaSequence.Split('!', (char)StringSplitOptions.RemoveEmptyEntries);
                    samplesArray = dnaSequence
                        .Split('!', (char)StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

                    currentIndex = 0;
                    currentSum = 0;
                    sequenceNumber++;

                    for (int i = 0; i < samplesArray.Length; i++)
                    {

                        if (samplesArray[i] == 1)
                        {

                            currentSum += samplesArray[i];

                        }

                    }

                    for (int i = 0; i < samplesArray.Length - 1; i++)
                    {

                        if (samplesArray[i] == samplesArray[i + 1] && samplesArray[i] == 1)
                        {

                            if (currentIndex == 0)
                            {

                                currentIndex = i;

                            }
                        }

                    }

                    if (currentSum > bestSequenceSum)
                    {

                        bestSequenceSum = currentSum;
                        bestStartIndex = currentIndex;
                        bestSequenceNumber = sequenceNumber;
                        bestSample = sample;

                    }

                    if (currentIndex < bestStartIndex)
                    {

                        bestSequenceSum = currentSum;
                        bestStartIndex = currentIndex;
                        bestSequenceNumber = sequenceNumber;
                        bestSample = sample;

                    }

                }

            } while (dnaSequence != "Clone them!");

            Console.WriteLine($"Best DNA sample {bestSequenceNumber} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(" ", bestSample));

        }

    }
}

