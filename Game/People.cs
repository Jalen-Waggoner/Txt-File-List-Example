using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class People
    {
        public People()
        {
            int counter = 0;

            // Read the file and display it line by line.  
            foreach (string line in System.IO.File.ReadLines("C:\\Users\\jwagg\\source\\repos\\ConsoleApp1\\Game\\PersonList.txt"))
            {
                var l = line.Split(",");
                List.Add(new Person { ID = counter, FirstName = l[0], LastName = l[1].Trim() });

                counter++;
            }
        }

        public List<Person> List { get; set; } = new List<Person>();



    }
}
