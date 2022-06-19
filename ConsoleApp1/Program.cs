using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();


            var tom = new Person();

            tom.ID = 1;
            tom.FirstName = "Tom";
            tom.LastName = "Smith";

            var tim = new Person { ID = 2, FirstName = "Tim", LastName = "Smith" };

            people.Add(tom);
            people.Add(tim);

           







            Console.WriteLine($"My name is {tom.FullName}");
            Console.ReadKey();

        }
    }
}
