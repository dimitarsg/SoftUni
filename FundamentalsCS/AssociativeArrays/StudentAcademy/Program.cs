using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < commandsCount; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (students.ContainsKey(studentName))
                {
                    students[studentName].Add(studentGrade);
                }
                else
                {
                    students.Add(studentName, new List<double> { studentGrade });
                }
            }

            Dictionary<string, double> leftStudents = students
                .Where(s => s.Value.Average() >= 4.5)
                .ToDictionary(k => k.Key, v => v.Value.Average());

            foreach (var student in leftStudents)
            {
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");
            }
        }
    }
}
