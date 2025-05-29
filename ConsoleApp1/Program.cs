using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArbolBBP arbolPersonas = new ArbolBBP();
            int opcion;
            do
            {
                Console.WriteLine("\nMENU:");
                Console.WriteLine("1. Agregar");
                Console.WriteLine("2. Listar");
                Console.WriteLine("3. Mayores de cierta edad");
                Console.WriteLine("4. Antepenultimp");
                Console.WriteLine("5. Fin");
                Console.Write("Elige una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese DNI: ");
                        int dni = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese Nombre: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese Edad: ");
                        int edad = int.Parse(Console.ReadLine());
                        arbolPersonas.Agrega(new Persona(dni,nombre,edad));
                        break;
                    case 2:
                        Console.WriteLine("Personas en PreOrden");
                        arbolPersonas.ImprimePre();
                        break;

                    case 3:
                        Console.Write("Ingrese la edad: ");
                        int e = int.Parse(Console.ReadLine());
                        int cant = arbolPersonas.CantidadMayores(e);
                        Console.WriteLine($"La cantidad de personas mayores a {e} es: {cant}");
                        break;

                    case 4:
                        Console.WriteLine("Antepenultima persona segun DNI");
                        Console.WriteLine(arbolPersonas.Antepenultimo());
                        break;

                    case 5:

                        break;
                }
            }while (opcion != 5) ;
        }
    }
}
