using System;
using System.Collections.Generic;
using System.Text;

namespace Bootcamp_5
{
    class Person
    {
        private string name;
        private int age;

        public Person()
        {
            name = "Federico";
            age = 19;
        }

        public void Greetings()
        {
            Console.WriteLine("Hello... I`m " + name);
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        } 
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
