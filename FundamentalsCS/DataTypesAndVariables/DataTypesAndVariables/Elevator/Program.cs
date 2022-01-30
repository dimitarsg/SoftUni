using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {

            int personsCount = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());
            int coursesCount = 0;

            coursesCount = (int)Math.Ceiling((double)personsCount / elevatorCapacity);

            Console.WriteLine($"{coursesCount}");

        }
    }
}
