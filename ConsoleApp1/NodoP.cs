using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class NodoP
    {
        public NodoP Izq { get; set; }
        public NodoP Der { get; set; }
        public Persona Dato { get; set; }

        public NodoP(Persona persona)
        {
            Dato = persona;
            Izq = null;
            Der = null;
        }
        public NodoP()
        {

        }
    }
}
