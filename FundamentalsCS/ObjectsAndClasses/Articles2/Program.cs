using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles2
{
    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return this.Title + " - " + this.Content + ": " + this.Author;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int comandsCount = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article> { };

            for (int i = 0; i < comandsCount; i++)
            {
                List<string> articleInput = Console.ReadLine()
                .Split(',', (char)StringSplitOptions.RemoveEmptyEntries)
                .Select(e => e.Trim())
                .ToList()
                .Where(e => !string.IsNullOrWhiteSpace(e))
                .ToList();

                Article article = new Article { Title = articleInput[0], Content = articleInput[1], Author = articleInput[2] };

                articles.Add(article);
            }

            string secondCommand = Console.ReadLine();

            if (secondCommand == "title" || secondCommand == "content" || secondCommand == "author")
            {
                Console.WriteLine(string.Join("\n", articles));
            }
        }
    }
}
