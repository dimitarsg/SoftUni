using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputText = Console.ReadLine().ToLower();

            Console.WriteLine(VowelsCount(inputText));

        }

        static int VowelsCount(string text)
        {

            int vowelsCount = 0;

            for (int i = 0; i < text.Length; i++)
            {

                if (text[i] == 'a' || text[i] == 'o' || text[i] == 'u' || text[i] == 'e' || text[i] == 'i')
                {

                    vowelsCount++;

                }

            }

            return vowelsCount;

        }

    }
}
