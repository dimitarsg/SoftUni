using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string commands = string.Empty;
            double totalPrice = 0;
            double taxes = 0;
            double priceNoDiscount = 0;

            while (commands != "regular" && commands != "special")
            {
                commands = Console.ReadLine();

                if (commands != "regular" && commands != "special")
                {
                     double currentPrice = double.Parse(commands);

                    if (currentPrice > 0)
                    {
                        taxes += currentPrice * 0.2;
                        currentPrice = currentPrice * 1.2;
                        priceNoDiscount += currentPrice;
                    }
                    else
                    {
                        Console.WriteLine("Invalid price!");
                    }
                }
            }

            if (priceNoDiscount <= 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                if (commands == "special")
                {
                    totalPrice = priceNoDiscount * 0.9;
                }
                else
                {
                    totalPrice = priceNoDiscount;
                }

                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {priceNoDiscount - taxes:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrice:f2}$");

            }
        }
    }
}
