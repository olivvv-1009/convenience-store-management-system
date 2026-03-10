using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAP08
{
    public class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Human() { }

        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
