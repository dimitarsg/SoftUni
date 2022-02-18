using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> arrayToChange = Console
                .ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<string> commandList = new List<string>();
            int number = 0;
            int index = 0;

            while (!commandList
                .Contains("end"))
            {

                if (!commandList
                    .Contains("end"))
                {

                    commandList = Console
                                        .ReadLine()
                                        .Split(' ')
                                        .ToList();

                    if (commandList
                        .Contains("Delete") && commandList.Count == 2)
                    {

                        number = int.Parse(commandList[1]);

                        arrayToChange.RemoveAll(item => item == number);

                    }

                    if (commandList
                        .Contains("Insert") && commandList.Count == 3)
                    {

                        number = int.Parse(commandList[1]);
                        index = int.Parse(commandList[2]);

                        if (arrayToChange.Count - 1 >= index)
                        {

                            arrayToChange.Insert(index, number);

                        }

                    }
                }

            }

            Console.WriteLine(string.Join(" ", arrayToChange));

        }
    }
}
