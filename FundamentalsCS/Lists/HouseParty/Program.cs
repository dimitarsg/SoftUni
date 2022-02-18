using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int guestsCount = int.Parse(Console.ReadLine());
            List<string> guestCommand = new List<string>();
            List<string> guestsList = new List<string>();

            for (int i = 0; i < guestsCount; i++)
            {
                guestCommand = Console.ReadLine().Split(' ').ToList();

                if (guestCommand.Count > 0)
                {
                    string guestName = guestCommand[0];

                    if (guestCommand.Contains("is") && guestCommand.Contains("going!") && !guestCommand.Contains("not"))
                    {
                        if (guestsList.Contains(guestName))
                        {
                            Console.WriteLine($"{guestName} is already in the list!");
                        }
                        else
                        {
                            guestsList.Add(guestName);
                        }
                    }

                    if (guestCommand.Contains("is") && guestCommand.Contains("going!") && guestCommand.Contains("not"))
                    {
                        if (!guestsList.Contains(guestName))
                        {
                            Console.WriteLine($"{guestName} is not in the list!");
                        }
                        else
                        {
                            guestsList.Remove(guestName);
                        }
                    }
                }
            }

            for (int i = 0; i < guestsList.Count; i++)
            {
                Console.WriteLine(guestsList[i]);
            }
        }
    }
}
