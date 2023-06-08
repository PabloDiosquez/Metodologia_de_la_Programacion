using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_01
{
    public class Pila
    {
        // Atributos 

        List<Comparable> pila;

        // Constructor
        public Pila()
        {
            pila = new List<Comparable>();
        }

        // Métodos de la clase 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="comparable"></param>
        public void apilar(Comparable comparable)
        {
            pila.Add(comparable);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Comparable desapilar()
        {
            Comparable desapilado = pila[pila.Count - 1];

            pila.Remove(desapilado);

            return desapilado;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Comparable verTope() 
        {
            return pila[pila.Count - 1];
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool esVacia()
        {
            return pila.Count == 0;
        }
    }
}
