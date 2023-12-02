using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_HomeWork_13
{
    public class Student : Human
    {
        public int Grade { get; set; }

        public Student(string name, string surname, byte age, int grade) : base(name, surname, age)
        {
            Grade = grade;
        }

        public override string ToString()
        {
            return base.ToString()+$"Grade:{Grade}\n";
        }
    }
}
