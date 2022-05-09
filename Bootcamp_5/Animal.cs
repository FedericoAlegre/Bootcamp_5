using System;
using System.Collections.Generic;
using System.Text;

namespace Bootcamp_5
{
    abstract class Animal
    {
        protected string nombre;
        protected bool hambre;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public bool Hambre
        {
            get
            {
                return hambre;
            }
            set
            {
                hambre = value;
            }
        }

        abstract public void Comer();
    }
}
