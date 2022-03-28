using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] separator = { ", " };
            string[] inputString = Console.ReadLine()
                .Split(separator, StringSplitOptions.RemoveEmptyEntries);
            bool isValid = false;

            for (int i = 0; i < inputString.Length; i++)
            {
                string currentString = inputString[i];

                if (currentString.Length >= 3 && currentString.Length <= 16)
                {
                    foreach (var character in currentString)
                    {
                        if (char.IsLetterOrDigit(character) || character == '_' || character == '-')
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }
                }

                if (isValid)
                {
                    Console.WriteLine(currentString);
                    isValid = false;
                }
            }
        }
    }
}
