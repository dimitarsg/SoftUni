using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int numberRead = int.Parse(Console.ReadLine());

            for (int i = 1; i < numberRead + 1; i++)
            {
                for (int j = 0; j < i; j++)
                {

                    Console.Write($"{i} ");

                }

                Console.WriteLine("");
            }

        }
    }
}
