using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string ixtisas { get; set; }

        public Student(int id , string name , string surname , string ixtisas)
        {
          this.id = id;
          this.name = name;
          this.surname = surname;
          this.ixtisas = ixtisas;
        }
    }
}
