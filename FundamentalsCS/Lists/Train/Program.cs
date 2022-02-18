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

            List<int> wagonsArray = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int maxWagonCapacity = int.Parse(Console.ReadLine());
            string commands = string.Empty;
            
            while (commands != "end")
            {

                commands = Console.ReadLine();
                
                if (commands != "end")
                {

                    if (commands.Contains("Add"))
                    {

                        AddWagons(wagonsArray, commands, maxWagonCapacity);

                    }

                    if (!commands.Contains("Add"))
                    {

                        AddPassangers(wagonsArray, commands, maxWagonCapacity);

                    }

                }

            }

            Console.WriteLine(string.Join(" ", wagonsArray));

        }

        static List<int> AddWagons(List<int> wagonsArray, string wagonsAndPass, int maxCapacity)
        {

            List<string> passangersCount = wagonsAndPass.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries).ToList();

            if (int.Parse(passangersCount[1]) <= maxCapacity)
            {

                wagonsArray.Add(int.Parse(passangersCount[1]));

            }

            return wagonsArray;

        }

        static List<int> AddPassangers(List<int> wagonsArray, string passangersCount, int maxCapacity)
        {

            int wagonLeftCapacity = 0;
            int passangersToAdd = int.Parse(passangersCount);

            for (int i = 0; i < wagonsArray.Count; i++)
            {

                wagonLeftCapacity = maxCapacity - wagonsArray[i];

                if (passangersToAdd <= wagonLeftCapacity)
                {

                    wagonsArray[i] += passangersToAdd;
                    break;

                }

            }

            return wagonsArray;

        }

    }
}
