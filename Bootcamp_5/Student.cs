using System;
using System.Collections.Generic;
using System.Text;

namespace Bootcamp_5
{
    class Student : Person
    {

        public Student(int x, string n)
        {
            Name = n;
            Age = x;
        }

        public void Study()
        {
            Console.WriteLine($"{Name} is studying...");
        }

        public void GetAge()
        {
            Console.WriteLine($"I am {Age} years old");
        }
    }
}
