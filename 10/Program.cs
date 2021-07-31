using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People(2000, "Tiraspol", 1, "Vedenchuk Andrew");
            People people1 = new People(2000, "Tiraspol", 2, "Shevchenko Vlad");
            People people2 = new People(2000, "Tiraspol", 3, "Koval Oleg");
            people.Equals(people1);
            people.Equals(people2);
        }
    }
}
