using System;

namespace Inheritance2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person andrew = new Person("andrew");
            Person igor = new Person("igor", 28);
            Person vasya = new Employee("vasya", 26, "journalist");
            Console.WriteLine("\n");
            Kek kek = new Kek("kek", 15, "hz", "lul");
        }
    }
}
