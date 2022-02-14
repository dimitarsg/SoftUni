using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');

            foreach (var item2 in firstArray)
            {

                foreach (var item in secondArray)
                {

                    if (item == item2)
                    {

                        Console.Write($"{item} ");
                        
                    }

                }

            }

            Console.WriteLine("");

        }
    }
}
