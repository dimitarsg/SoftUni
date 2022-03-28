using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());
            char[] bigNumber = firstNumber
                .ToCharArray();
            List<string> result = new List<string>(firstNumber.Length);

            int tempNumber = 0;

            if (secondNumber > 0)
            {
                for (int i = bigNumber.Length - 1; i >= 0; i--)
                {
                    int currentNumber = int.Parse(bigNumber[i].ToString());
                    int currentResult = currentNumber * secondNumber;
                    currentResult += tempNumber;

                    if (currentResult > 9)
                    {
                        tempNumber = currentResult.ToString()[0] - 48;
                    }
                    else
                    {
                        tempNumber = 0;
                    }

                    if (i != 0)
                    {
                        currentResult = currentResult % 10;
                    }

                    result.Insert(0, currentResult.ToString());
                }
            }
            else
            {
                result.Add(tempNumber.ToString());
            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
