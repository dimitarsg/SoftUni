using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {

            double coinsTotal = 0;
            string input = string.Empty;
            double coinsInserted = 0;
            double price = 0;


            while (input != "Start")
            {

                input = Console.ReadLine();

                if (input != "Start")
                {

                    coinsInserted = double.Parse(input);

                    if (coinsInserted == 0.1 || coinsInserted == 0.2 || coinsInserted == 0.5 || coinsInserted == 1 || coinsInserted == 2)
                    {

                        coinsTotal += coinsInserted;

                    }
                    else
                    {

                        Console.WriteLine($"Cannot accept {coinsInserted}");

                    }

                }
            }

            while (input != "End")
            {

                input = Console.ReadLine();

                switch (input)
                {
                    case "Nuts":

                        price = 2.0;

                        if (coinsTotal >= price)
                        {

                            Console.WriteLine("Purchased nuts");
                            coinsTotal -= price;

                        }
                        else
                        {

                            Console.WriteLine("Sorry, not enough money");

                        }

                        break;

                    case "Water":

                        price = 0.7;

                        if (coinsTotal >= price)
                        {

                            Console.WriteLine("Purchased water");
                            coinsTotal -= price;

                        }
                        else
                        {

                            Console.WriteLine("Sorry, not enough money");

                        }

                        break;

                    case "Crisps":

                        price = 1.5;

                        if (coinsTotal >= price)
                        {

                            Console.WriteLine("Purchased crisps");
                            coinsTotal -= price;

                        }
                        else
                        {

                            Console.WriteLine("Sorry, not enough money");

                        }

                        break;

                    case "Soda":

                        price = 0.8;

                        if (coinsTotal >= price)
                        {

                            Console.WriteLine("Purchased soda");
                            coinsTotal -= price;

                        }
                        else
                        {

                            Console.WriteLine("Sorry, not enough money");

                        }

                        break;

                    case "Coke":

                        price = 1.0;

                        if (coinsTotal >= price)
                        {

                            Console.WriteLine("Purchased coke");
                            coinsTotal -= price;

                        }
                        else
                        {

                            Console.WriteLine("Sorry, not enough money");

                        }

                        break;

                    default:

                        if (input != "End")
                        {

                            Console.WriteLine("Invalid product");

                        }

                        break;

                }

            }

            Console.WriteLine($"Change: {coinsTotal:f2}");

        }
    }
}

