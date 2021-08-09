using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    class Employee : Person
    {
        private string company;
        public Employee(string name, int age, string company) : base(name, age)
        {
            this.company = company;
            Console.WriteLine("Employee(string name, int age, string company) : base(name, age)");
        }
    }
}
