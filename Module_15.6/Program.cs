using System;
using System.Collections.Generic;
using System.Linq;

namespace Module_15._6
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
            };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            var allStudents = new List<string>();

            foreach (var students in classes)
            {
                var edit = students.Students.Select(s=>s).ToList();

                foreach (var student in edit)
                {
                    allStudents.Add(student);
                }
            }

            var result = allStudents.ToArray();

            return result;
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}
