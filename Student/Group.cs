using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Group
    {
        public string name { get; set; }
        public int MaxStuCount { get; set; }
        public Student[] Students { get; set; }
        public Student[] holder;
        public Student[] holder1;

        public Group(string name , int MaxStuCount ,params Student[] Students)
        {
            this.name = name;
            this.MaxStuCount = MaxStuCount;
            this.Students = Students;
            if (MaxStuCount<Students.Length)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Qrupda olan yerlerden cox student artirilib");
            }
        }

        public void addStudent(Student student)
        {
            if (MaxStuCount<Students.Length+1)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Artirmaga yer yoxdu!");
                return;
            }
            Student[] Students1 = new Student[Students.Length+1];
            Students1[Students1.Length-1] = student;
            for (int i = 0; i < Students.Length; i++)
            {
                Students1[i] = Students[i];

            }
            holder = Students1;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{student.name} add olundu : ");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in Students1)
            {
                Console.WriteLine(item.name);
            }
            if (MaxStuCount > Students.Length)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Qrup tam dolmayib!");
            }
            else if (MaxStuCount == Students.Length)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Qrup doldu!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Qrupda yer yoxdur!");
            }
            Console.WriteLine("\n");
        }

        public void RemoveStudent(Student student)
        {
            if (MaxStuCount <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Silmeli adam qalmadi!");
                return;
            }
            Student[] Students1 = new Student[Students.Length];
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{student.name} remove olundu : ");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < Students.Length; i++)
            {
                if (student == Students[i])
                {
                    continue;
                }
                else
                {
                    Students1[i] = Students[i];
                }

                Console.WriteLine(Students1[i].name);
            }
            Console.WriteLine("\n");

            holder1 = Students1;
        }
    }
}
