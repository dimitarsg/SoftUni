using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();
            double totalPrice = 0;
            double tempPrice = 0;

            switch (groupType)
            {
                case "Students":

                    switch (dayOfTheWeek)
                    {
                        case "Friday":

                            totalPrice = peopleCount * 8.45F;

                            break;

                        case "Saturday":

                            totalPrice = peopleCount * 9.80F;

                            break;

                        case "Sunday":

                            totalPrice = peopleCount * 10.46F;

                            break;
                    }

                    if (peopleCount >= 30)
                    {
                        totalPrice = totalPrice * 0.85;
                    }

                    break;

                case "Business":

                    switch (dayOfTheWeek)
                    {
                        case "Friday":

                            tempPrice = 10.90F;

                            totalPrice = peopleCount * tempPrice;

                            break;

                        case "Saturday":

                            tempPrice = 15.60F;

                            totalPrice = peopleCount * tempPrice;

                            break;

                        case "Sunday":

                            tempPrice = 16.00F;

                            totalPrice = peopleCount * tempPrice;

                            break;
                    }

                    if (peopleCount >= 100)
                    {

                        totalPrice = totalPrice - (10 * tempPrice);

                    }

                    break;

                case "Regular":

                    switch (dayOfTheWeek)
                    {
                        case "Friday":

                            totalPrice = peopleCount * 15.00F;

                            break;

                        case "Saturday":

                            totalPrice = peopleCount * 20.00F;

                            break;

                        case "Sunday":

                            totalPrice = peopleCount * 22.50F;

                            break;



                    }

                    if (peopleCount >= 10 && peopleCount <= 20)

                    {

                        totalPrice = totalPrice * 0.95;

                    }

                    break;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");

        }
    }
}
