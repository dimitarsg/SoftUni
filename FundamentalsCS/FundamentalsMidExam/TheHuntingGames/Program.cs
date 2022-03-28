using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHuntingGames
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfAdventure = int.Parse(Console.ReadLine());
            int playersCount = int.Parse(Console.ReadLine());
            double groupEnergy = double.Parse(Console.ReadLine());
            double waterPerDay = double.Parse(Console.ReadLine()) * playersCount * daysOfAdventure;
            double foodPerDay = double.Parse(Console.ReadLine()) * playersCount * daysOfAdventure;
            double leftEnergy = groupEnergy;

            for (int i = 1; i <= daysOfAdventure; i++)
            {
                double energyLoss = double.Parse(Console.ReadLine());

                leftEnergy -= energyLoss;

                if (leftEnergy <= 0)
                {
                    break;
                }

                if (i % 2 == 0)
                {
                    leftEnergy *= 1.05;
                    waterPerDay *= 0.7;
                }

                if (i % 3 == 0)
                {
                    leftEnergy *= 1.1;
                    foodPerDay -= foodPerDay / playersCount;
                }

                if (leftEnergy <= 0)
                {
                    break;
                }
            }

            if (leftEnergy >= 1)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {leftEnergy:f2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {foodPerDay:f2} food and {waterPerDay:f2} water.");
            }
        }
    }
}
