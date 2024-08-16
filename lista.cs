using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IbañezMarinBrandonRodrigo
{
    internal class Lista
    {
        public Nodo inicio;

        public Lista()
        {
            inicio = null;
        }
        public void insertarF(int item)
        {
            Nodo auxiliar = new Nodo();  
            auxiliar.dato = item; 
            auxiliar.siguiente = null; 
            if (inicio == null) 
            {
                inicio = auxiliar;
            }
            else
            {
                Nodo puntero; 
                puntero = inicio;
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente; 
                }
                puntero.siguiente = auxiliar;
            }
        }

        
        public void InsertarAlFinal(int item)
        {
            Nodo auxiliar = new Nodo();
            auxiliar.dato = item;
            auxiliar.siguiente = null;

            if (inicio == null)
            {
                inicio = auxiliar;
            }
            else
            {
                Nodo puntero = inicio;
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                }
                puntero.siguiente = auxiliar;
            }
        }

        
        public void InsertarAlInicio(int item)
        {
            Nodo auxiliar = new Nodo();
            auxiliar.dato = item;
            auxiliar.siguiente = inicio;
            inicio = auxiliar;
        }

        
        public void Mostrar()
        {
            if (inicio == null)
            {
                Console.WriteLine("La lista está vacía.");
            }
            else
            {
                Nodo puntero = inicio;
                while (puntero != null)
                {
                    Console.WriteLine(puntero.dato);
                    puntero = puntero.siguiente;
                }
            }
        }

        public void EliminarNodo(int item)
        {
            if (inicio == null)
            {
                Console.WriteLine("La lista está vacía. No se puede eliminar el nodo.");
                return;
            }

            if (inicio.dato == item)
            {
                inicio = inicio.siguiente;
                return;
            }

            Nodo puntero = inicio;
            while (puntero.siguiente != null && puntero.siguiente.dato != item)
            {
                puntero = puntero.siguiente;
            }

            if (puntero.siguiente == null)
            {
                Console.WriteLine("Nodo no encontrado.");
            }
            else
            {
                puntero.siguiente = puntero.siguiente.siguiente;
            }
        }

        
        public Nodo EncontrarNodoMedio()
        {
            if (inicio == null)
            {
                return null;
            }

            Nodo lento = inicio;
            Nodo rapido = inicio;

            while (rapido != null && rapido.siguiente != null)
            {
                lento = lento.siguiente;
                rapido = rapido.siguiente.siguiente;
            }

            return lento;
        }

        
        public void InvertirLista()
        {
            Nodo anterior = null;
            Nodo actual = inicio;
            Nodo siguiente = null;

            while (actual != null)
            {
                siguiente = actual.siguiente;
                actual.siguiente = anterior;
                anterior = actual;
                actual = siguiente;
            }

            inicio = anterior;
        }
    }

}
