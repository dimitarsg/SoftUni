﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = startNumber; i < endNumber + 1; i++)
            {
                Console.Write($"{i} ");
                sum = sum + i;

            }

            Console.WriteLine("");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
