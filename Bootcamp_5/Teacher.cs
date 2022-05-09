using System;
using System.Collections.Generic;
using System.Text;

namespace Bootcamp_5
{
    class Teacher : Person
    {
        public Teacher()
        {
        }
        public Teacher(int x, string n)
        {
            Name = n;
            Age = x;
        }
        public void Teach()
        {
            Console.WriteLine($"{Name} is teaching...");
        }
    }
}
