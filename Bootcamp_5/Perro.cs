using System;
using System.Collections.Generic;
using System.Text;

namespace Bootcamp_5
{
    class Perro : Animal
    {
        public Perro(string x, bool h)
        {
            Nombre = x;
            Hambre = h;
        }
        override public void Comer()
        {
            if(Hambre==true)
            {
                Console.WriteLine($"·El perro {Nombre} está comiendo·");
            }
            else Console.WriteLine($"·El perro {Nombre} ya está lleno·");
        }
    }
}
