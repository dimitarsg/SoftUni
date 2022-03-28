using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> productsPrices = new Dictionary<string, double>();
            Dictionary<string, int> productsQty = new Dictionary<string, int>();
            Dictionary<string, double> productsTotals = new Dictionary<string, double>();
            string inputProduct = string.Empty;

            while (true)
            {
                inputProduct = Console.ReadLine();

                if (inputProduct == "buy")
                {
                    break;
                }

                string[] inputProductData = inputProduct
                    .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string currentProductName = inputProductData[0];
                double currentProductPrice = double.Parse(inputProductData[1]);
                int currentProductQty = int.Parse(inputProductData[2]);

                if (!productsPrices.ContainsKey(currentProductName))
                {
                    productsPrices.Add(currentProductName, currentProductPrice);
                    productsQty.Add(currentProductName, currentProductQty);
                }
                else
                {
                    productsPrices[currentProductName] = currentProductPrice;
                    productsQty[currentProductName] += currentProductQty;
                }
            }

            foreach (var product in productsPrices)
            {
                productsTotals.Add(product.Key, product.Value * productsQty[product.Key]);
            }

            foreach (var product in productsTotals)
            {
                Console.WriteLine($"{product.Key} -> {product.Value:f2}");
            }  
        }
    }
}
