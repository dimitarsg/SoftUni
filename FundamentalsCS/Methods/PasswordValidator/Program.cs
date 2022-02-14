using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputPass = Console.ReadLine();

            bool charLength = CheckCharactersLength(inputPass);
            bool charType = CheckCharactersType(inputPass);
            bool digitsCount = CheckDigitsCount(inputPass);

            if (charLength == false)
            {

                Console.WriteLine("Password must be between 6 and 10 characters");

            }

            if (charType == false)
            {

                Console.WriteLine("Password must consist only of letters and digits");

            }

            if (digitsCount == false)
            {

                Console.WriteLine("Password must have at least 2 digits");

            }

            if (charLength == true && charType == true && digitsCount == true)
            {

                Console.WriteLine("Password is valid");

            }

        }

        static bool CheckCharactersLength(string inputPass)
        {

            if (inputPass.Length >= 6 && inputPass.Length <= 10)
            {

                return true;

            }

            return false;

        }

        static bool CheckCharactersType(string inputPass)
        {

            bool validCharType = false;
            bool[] validChars = new bool[inputPass.Length];

            for (int i = 0; i < inputPass.Length; i++)
            {

                int currentChar = inputPass[i];

                if ((currentChar >= 48 && currentChar <= 57) || (currentChar >= 65 && currentChar <= 90) || (currentChar >= 97 && currentChar <= 122))
                {

                    validChars[i] = true;

                }
                else
                {

                    validChars[i] = false;

                }

            }

            if (validChars.Contains(false))
            {

                return validCharType;

            }
            else
            {

                validCharType = true;
                return validCharType;

            }

        }
        static bool CheckDigitsCount(string inputPass)
        {

            int digitsCount = 0;

            for (int i = 0; i < inputPass.Length; i++)
            {

                int currentChar = inputPass[i];

                if (currentChar >= 48 && currentChar <= 57)
                {

                    digitsCount++;

                }

            }

            if (digitsCount >= 2)
            {

                return true;

            }

            return false;

        }

    }
}
