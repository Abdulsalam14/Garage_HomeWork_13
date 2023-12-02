using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_HomeWork_13
{
    public class Employe : Human
    {
        public string Position { get; set; }
        public Employe(string name, string surname, byte age, string position) : base(name, surname, age)
        {
            if(string.IsNullOrEmpty(position)) throw new ArgumentNullException("position");
            Position = position;
        }

        public override string ToString()
        {
            return base.ToString() + $"Position:{Position}\n";
        }
    }
}
