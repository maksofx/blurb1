using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blurb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] student =
            {
                new Student("Ivan", 14),
                new Student("Spencer", 19),
                new Student("Petka", 25),
                new Student("Silvena", 16)
            };
            foreach (var students in student)
            {
                Console.WriteLine(students);
            }
            Sort(student);
            Console.WriteLine();

            foreach (var students in student)
            {
                Console.WriteLine(students);
            }
            Console.ReadKey();
        }
        static void Sort( Student[]student)
        {
            int n = student.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (student[j].Age > student[j + 1].Age)
                    {
                        (student[j], student[j + 1]) = (student[j + 1], student[j]);
                    }
                }
            }
        }
        
        
    }
}
