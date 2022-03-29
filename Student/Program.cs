using System;
namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Murad = new Student(5,"Murad" , "Abdullazade" , "Komputer Elmeri");
            Student Qezenfer = new Student(8,"Qezenfer" , "Qaqayev" , "Qaqaliq");
            Student Ibrahim = new Student(7,"Ibrahim" , "Isgenderov" , "Komputer Elmleri");
            Student Tosu = new Student(1,"Tosu" , "Zengilanli" , "Dahi");
            Group BP201 = new Group("BP201", 16, Murad , Qezenfer , Ibrahim);
            BP201.addStudent(Tosu);
            BP201.RemoveStudent(Qezenfer);
        }
    }
}