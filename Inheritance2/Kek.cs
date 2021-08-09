using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Kek : Employee
    {
        private string secondName;
        public Kek(string name, int age, string company, string secondName) : base(name, age, company)
        {
            this.secondName = secondName;
            Console.WriteLine("Kek(string name, int age, string company, string secondName) : base(name, age, company)");
        }
    }
}
