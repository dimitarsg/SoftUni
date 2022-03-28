using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> booksList = Console.ReadLine()
                .Split('&', (char)StringSplitOptions.RemoveEmptyEntries)
                .Select(e => e.Trim())
                .ToList()
                .Where(e => !string.IsNullOrWhiteSpace(e))
                .ToList();


            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Done")
                {
                    break;
                }

                string[] commandArray = command
                    .Split('|', (char)StringSplitOptions.RemoveEmptyEntries)
                .Select(e => e.Trim())
                .ToArray()
                .Where(e => !string.IsNullOrWhiteSpace(e))
                .ToArray();

                switch (commandArray[0])
                {
                    case "Add Book":
                        if (!booksList.Contains(commandArray[1]))
                        {
                            booksList.Insert(0, commandArray[1]);
                        }
                        break;

                    case "Take Book":
                        if (booksList.Contains(commandArray[1]))
                        {
                            booksList.Remove(commandArray[1]);
                        }
                        break;

                    case "Swap Books":
                        if (booksList.Contains(commandArray[1]) && booksList.Contains(commandArray[2]))
                        {
                            int firstIndex = booksList.IndexOf(commandArray[1]);
                            int secondIndex = booksList.IndexOf(commandArray[2]);
                            string tempBook = booksList[firstIndex];
                            booksList[firstIndex] = booksList[secondIndex];
                            booksList[secondIndex] = tempBook;
                        }
                        break;

                    case "Insert Book":
                        if (!booksList.Contains(commandArray[1]))
                        {
                            booksList.Add(commandArray[1]);
                        }
                        break;

                    case "Check Book":
                        if (int.Parse(commandArray[1]) < booksList.Count)
                        {
                            Console.WriteLine(booksList[int.Parse(commandArray[1])]);
                        }
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", booksList).Trim(',').Trim(' '));
        }

    }
}

