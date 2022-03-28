using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:f2}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int comandsCount = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student> { };

            for (int i = 0; i < comandsCount; i++)
            {
                List<string> studentInput = Console.ReadLine()
                .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
                .Select(e => e.Trim())
                .ToList()
                .Where(e => !string.IsNullOrWhiteSpace(e))
                .ToList();

                Student student = new Student { FirstName = studentInput[0], LastName = studentInput[1], Grade = double.Parse(studentInput[2]) };

                students.Add(student);
            }

            List<Student> orderedStudents = students
                .OrderByDescending(s => s.Grade)
                .ToList();

            Console.WriteLine(string.Join("\n", orderedStudents));
        }
    }
}
