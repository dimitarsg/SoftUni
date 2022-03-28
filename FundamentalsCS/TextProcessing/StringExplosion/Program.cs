using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            int explosionPower = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                if (currentChar == '>')
                {
                    int currentPower = int.Parse(input[i + 1].ToString());
                    result.Append(currentChar);
                    explosionPower += currentPower;
                }
                else
                {
                    if (explosionPower > 0)
                    {
                        explosionPower--;
                    }
                    else
                    {
                        result.Append(currentChar);
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
