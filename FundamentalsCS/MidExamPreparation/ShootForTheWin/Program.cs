using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integersArray = Console.ReadLine()
                .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command = string.Empty;
            int shootedTargets = 0;

            while (command != "End")
            {
                command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                int arrayIndex = int.Parse(command);
                if (arrayIndex <= integersArray.Count - 1)
                {
                    int shootedItem = integersArray[arrayIndex];
                    integersArray[arrayIndex] = -1;

                    for (int i = 0; i < integersArray.Count; i++)
                    {
                        int currentItem = integersArray[i];

                        if (currentItem > shootedItem && currentItem != -1)
                        {
                            integersArray[i] = currentItem - shootedItem;
                        }

                        if (currentItem <= shootedItem && currentItem != -1)
                        {
                            integersArray[i] = currentItem + shootedItem;
                        }
                    }
                }
            }

            shootedTargets = integersArray
                .Where(e => e == -1)
                .Count();
            Console.WriteLine($"Shot targets: {shootedTargets} -> {string.Join(" ", integersArray).Trim()}");
        }
    }
}
