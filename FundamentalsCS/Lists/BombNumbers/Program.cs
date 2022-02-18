using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersArray = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> bombList = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> specialNumberIndexes = new List<int>();

            while (true)
            {
                int bombIndex = numbersArray.IndexOf(bombList[0]);

                if (bombIndex == -1)
                {
                    break;
                }

                Detonator(numbersArray, bombList);
            }

            Console.WriteLine(numbersArray.Sum());
        }

        static List<int> Detonator(List<int> numbersArray, List<int> bombList)
        {
            int indexOfTheBomb = numbersArray.IndexOf(bombList[0]);
            int leftIndexCount = indexOfTheBomb - bombList[1];
            int rightIndexCount = indexOfTheBomb + bombList[1];

            if (leftIndexCount <= 0)
            {
                leftIndexCount = 0;
            }

            if (rightIndexCount >= numbersArray.Count)
            {
                rightIndexCount = numbersArray.Count;
            }

            for (int i = indexOfTheBomb; i < rightIndexCount; i++)
            {
                numbersArray.RemoveAt(indexOfTheBomb);
            }

            for (int i = leftIndexCount; i <= indexOfTheBomb; i++)
            {
                numbersArray.RemoveAt(leftIndexCount);
            }

            return numbersArray;
        }
    }
}
