using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {

            int kegsCount = int.Parse(Console.ReadLine());
            float biggestKegVolume = 0;
            string biggestKeg = string.Empty;

            for (int i = 0; i < kegsCount; i++)
            {

                string kegModel = Console.ReadLine();
                float kegRadius = float.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());
                float kegVolume = 0;

                kegVolume = (float)(Math.PI * Math.Pow(kegRadius, 2)) * kegHeight;

                if (kegVolume >= biggestKegVolume)
                {

                    biggestKegVolume = kegVolume;
                    biggestKeg = kegModel;

                }
            }

            Console.WriteLine($"{biggestKeg}");

        }
    }
}
