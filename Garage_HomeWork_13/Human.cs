using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_HomeWork_13
{
    public class Human
    {
        public Human(string name, string surname, byte age)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException();
            }

            Name = name;
            Surname = surname;
            Age = age;
        }

        public string? Name { get; set; }
        public string? Surname { get; set; }
        public byte Age { get; set; }

        public override string ToString()
        {
            return $"Name:{Name}\nSurname:{Surname}\nAge{Age}\n";
        }
    }
}
