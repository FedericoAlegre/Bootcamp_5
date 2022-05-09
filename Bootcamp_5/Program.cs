using System;

namespace Bootcamp_5
{
    class Program
    {
        static int TryAndCatchInt(string msg)
        {
            bool f = false;
            int option = 0;
            do
            {
                Console.WriteLine(msg);
                string s = Console.ReadLine();
                try
                {
                    option = int.Parse(s);
                    f = true;

                }
                catch (Exception)
                {

                    EscribirError("Ingreso un dato invalido!!");
                }
            } while (f != true);
            return option;

        }

        static void EscribirError(string msg)
        {            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.Cyan;

        }

        static void Ejercicio1()
        {
            Person p = new Person();
            p.Greetings();
            Student s = new Student(19, "Julian");
            s.Greetings();
            s.GetAge();
            s.Study();
            Teacher t = new Teacher(34, "Roberto");
            t.Greetings();
            t.Teach();

        }

        static void Ejercicio2(int x)
        {
            Person[] p = new Person[x];

            for (int i = 0; i < x; i++)
            {
                if (i == x - 1)
                {
                    Console.WriteLine("Insert Teacher`s name: ");
                    string n = Console.ReadLine();
                    Teacher t = new Teacher(TryAndCatchInt("Age: "), n);
                    p[i] = t;
                }
                else
                {
                    Console.WriteLine("Insert Student`s name: ");
                    string n = Console.ReadLine();
                    Student s = new Student(TryAndCatchInt("Age: "), n);
                    p[i] = s;
                }
            }

            for (int i = 0; i < x; i++)
            {
                if (i == x - 1)
                {
                    Console.WriteLine($"Teacher: {p[i].Name}");
                    Teacher t = new Teacher(p[i].Age, p[i].Name);
                    t.Teach();
                }
                else
                {
                    Console.WriteLine($"Student: {p[i].Name}");
                    Student s = new Student(p[i].Age, p[i].Name);
                    s.Study();
                }
            }
        }

        static void Ejercicio5(Perro p, int h)
        {
            if (h<2) 
            {
                h++;
                p.Hambre = true;
                p.Comer();
            }
            else
            {
                h = 0;
                p.Hambre = false;
                p.Comer();
            }

        }

        static void Menu(int o, Perro p, int h)
        {
            if (o > 0)
            {
                switch (o)
                {
                    case 1:
                        {
                            Ejercicio1();                           
                            break;
                        }
                    case 2:
                        {
                            Ejercicio2(TryAndCatchInt("Ingrese la cantidad de alumnos")+1);
                            break;
                        }
                    case 5:
                        {
                            Ejercicio5(p, h);
                            h++;                            
                            break;
                        }
                    default:
                        {
                            EscribirError("NUMERO INVALIDO");
                            break;
                        }
                }
                Console.ReadKey();
                Console.Clear();
                Menu(TryAndCatchInt("Menu:\n0: Apagar\n1: Ejercicio 1\n2: Ejercicio 2"), p, h);
            }

        }

        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Cyan;
            int h = 0;
            Perro p = new Perro("firulais", true);
            Console.WriteLine("Bootcamp 5");
            Menu(TryAndCatchInt("Menu:\n0: Apagar\n1: Ejercicio 1\n2: Ejercicio 2"), p, h);   
            
        }
    }
}
