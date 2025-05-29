using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ArbolBBP
    {
        private NodoP Raiz {  get; set; }
        public ArbolBBP()
        {
            Raiz = null;
        }
        public void Agrega(Persona persona)
        {
            Raiz = Insertar(Raiz,persona);
        }
        public void AgregaPersona(Persona persona)
        {

            Raiz = Insertar(Raiz,persona);

        }
        private NodoP Insertar(NodoP nodo,Persona persona)
        {
            if (nodo == null)
            {
                return new NodoP(persona);
            }
            if(persona.DNI < nodo.Dato.DNI)
            {
                nodo.Izq = Insertar(nodo.Izq, persona);
            }
            else
            {
                nodo.Der = Insertar(nodo.Der, persona);
            }
            return nodo;
        }
        public void ImprimePre()
        {
            PreoOrden(Raiz);
        }
        public void PreoOrden(NodoP nodo)
        {
            if (nodo == null) return;

            Console.WriteLine(nodo.Dato);
            PreoOrden(nodo.Izq);
            PreoOrden(nodo.Der);
        }

        public int CantidadMayores(int edad)
        {
            return ContarMayores(Raiz,edad);
        }

        public int ContarMayores(NodoP nodo,int edad)
        {
            if (nodo == null) return 0;
            int cuenta = nodo.Dato.EDAD > edad? 1 : 0;
            return cuenta + ContarMayores(nodo.Izq, edad) + ContarMayores(nodo.Der, edad);
        }

        public string Antepenultimo()
        {
            List<Persona> lista = new List<Persona>();
            InOrden(Raiz,lista);
            if(lista.Count > 3)
            {
                return "No hay suficientes personas";
            }
            return lista[lista.Count - 3].ToString();
        }
        public void InOrden(NodoP nodo, List<Persona> lista)
        {
            if (nodo == null) return ;

            InOrden(nodo.Izq,lista);
            lista.Add(nodo.Dato);
            InOrden(nodo.Der,lista);
        }

    }
}
