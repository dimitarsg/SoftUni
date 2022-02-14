using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] pasangersCount = new int[int.Parse(Console.ReadLine())];
            int sumOfPassangers = 0;

            for (int i = 0; i < pasangersCount.Length; i++)
            {

                pasangersCount[i] = int.Parse(Console.ReadLine());
                sumOfPassangers += pasangersCount[i];

            }

            Console.WriteLine(string.Join(" ", pasangersCount));
            Console.WriteLine(sumOfPassangers);

        }
    }
}
