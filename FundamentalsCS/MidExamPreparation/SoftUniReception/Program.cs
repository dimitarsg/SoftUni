using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thidrEmployee = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            int hoursNeeded = 0;
            int employeesCapacity = firstEmployee + secondEmployee + thidrEmployee;

            while (true)
            {
                if (studentsCount == 0)
                {
                    break;
                }

                hoursNeeded++;

                if (hoursNeeded % 4 == 0)
                {
                    hoursNeeded++;
                }

                if (studentsCount <= employeesCapacity)
                {
                    break;
                }

                studentsCount -= employeesCapacity;
            }

            Console.WriteLine($"Time needed: {hoursNeeded}h.");
        }
    }
}
