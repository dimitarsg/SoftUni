using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPath = Console.ReadLine();
            string[] fileInfo = inputPath
                .Substring(inputPath.LastIndexOf('\\') + 1)
                .ToString()
                .Split('.', (char)StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Console.WriteLine($"File name: {fileInfo[0]}");
            Console.WriteLine($"File extension: {fileInfo[1]}");
        }
    }
}
