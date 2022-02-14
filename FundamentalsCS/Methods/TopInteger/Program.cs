using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopInteger
{
    class Program
    {
        static void Main(string[] args)
        {

            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i <= inputNumber; i++)
            {

                bool isTopInt = IsTopInteger(i);

                if (isTopInt)
                {

                    Console.WriteLine(i);

                }

            }


        }
        static bool IsTopInteger(int number)
        {

            string numberString = number.ToString();
            bool hasOddDigit = false;
            int sumOfDigits = 0;
            char[] charNums = numberString.ToCharArray();
            int[] numbers = Array.ConvertAll(charNums, c => (int)Char.GetNumericValue(c));

            foreach (var item in numbers)
            {

                if (item % 2 != 0)
                {

                    hasOddDigit = true;
                    break;

                }

            }

            foreach (var item in numbers)
            {

                sumOfDigits += item;

            }

            if ((sumOfDigits % 8 == 0) && hasOddDigit)
            {

                return true;

            }

            return false;

        }

    }
}
