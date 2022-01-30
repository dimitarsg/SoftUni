using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {

            int inputsCount = int.Parse(Console.ReadLine());
            int tankCapacity = 255;
            int filledLitres = 0;
            int enteredLitres = 0;

            for (int i = 0; i < inputsCount; i++)
            {

                enteredLitres = int.Parse(Console.ReadLine());
                filledLitres += enteredLitres;

                if (filledLitres >= tankCapacity)
                {

                    Console.WriteLine("Insufficient capacity!");
                    filledLitres -= enteredLitres;

                }

                if (i == inputsCount - 1)
                {

                    Console.WriteLine($"{filledLitres}");

                }
            }

        }
    }
}
