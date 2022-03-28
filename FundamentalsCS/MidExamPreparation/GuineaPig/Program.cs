using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuineaPig
{
    class Program
    {
        static void Main(string[] args)
        {
            double foodQty = double.Parse(Console.ReadLine()) * 1000;
            double hayQty = double.Parse(Console.ReadLine()) * 1000;
            double coverQty = double.Parse(Console.ReadLine()) * 1000;
            double puppyWeight = double.Parse(Console.ReadLine()) * 1000;

            for (int i = 1; i <= 30; i++)
            {
                foodQty -= 300;

                if (i % 2 == 0)
                {
                    hayQty -= foodQty * 0.05;
                }

                if (i % 3 == 0)
                {
                    coverQty -= puppyWeight / 3;
                }

                if (foodQty <= 0 || hayQty <= 0 || coverQty <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
            }

            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {foodQty / 1000:f2}, Hay: {hayQty / 1000:f2}, Cover: {coverQty / 1000:f2}.");
        }
    }
}
