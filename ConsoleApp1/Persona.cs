using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Persona
    {
        public int DNI { get; set; }
        public string NOMBRE { get; set; }
        public int EDAD { get; set; }

        public Persona(int dni, string nombre, int edad)
        {
            DNI = dni;
            NOMBRE = nombre;
            EDAD = edad;
        }
        public override string ToString()
        {
            return $"Dni: {DNI} Nombre: {NOMBRE} Edad: {EDAD}";
        }
    }
}
