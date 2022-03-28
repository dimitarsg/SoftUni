using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles
{

    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public string Edit(string content)
        {
            return this.Content = content;
        }

        public string ChangeAuthor(string author)
        {
            return this.Author = author;
        }

        public string Rename(string title)
        {
            return this.Title = title;
        }

        public override string ToString()
        {
            return this.Title + " - " + this.Content + ": " + this.Author;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> articleInput = Console.ReadLine()
                .Split(',', (char)StringSplitOptions.RemoveEmptyEntries)
                .Select(e => e.Trim())
                .ToList()
                .Where(e => !string.IsNullOrWhiteSpace(e))
                .ToList();

            Article article = new Article { Title = articleInput[0], Content = articleInput[1], Author = articleInput[2] };

            int comandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < comandsCount; i++)
            {
                string command = Console.ReadLine();

                if (command.Length > 0)
                {
                    List<string> commandArray = command
                        .Split(':', (char)StringSplitOptions.RemoveEmptyEntries)
                        .Select(e => e.Trim())
                        .ToList()
                        .Where(e => !string.IsNullOrWhiteSpace(e))
                        .ToList();

                    switch (commandArray[0])
                    {
                        case "Edit":

                            article.Edit(commandArray[1]);
                            break;

                        case "ChangeAuthor":

                            article.ChangeAuthor(commandArray[1]);
                            break;

                        case "Rename":

                            article.Rename(commandArray[1]);
                            break;

                        default:
                            break;
                    }
                }
            }

            Console.WriteLine(article);
        }
    }
}
