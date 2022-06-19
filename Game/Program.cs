using System;
using System.Linq;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new People().List.Where(p => p.FirstName == "Tim").ToList();

            

            foreach (var person in p)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}");
            }

            Console.ReadLine();
        }
    }
}
