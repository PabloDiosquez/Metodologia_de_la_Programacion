using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_01
{
    // EJERCICIO 4 🌳

    /// <summary>
    /// Representa una colección LIFO (el último en entrar es el primero en salir)
    /// de tamaño variable de instancias del tipo Comparable.
    /// </summary>
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
        /// Apila el elemento comparable dado en la pila que recibe el mensaje.
        /// </summary>
        /// <param name="comparable">Elemento comparable que se apila en la pila</param>
        public void apilar(Comparable comparable)
        {
            pila.Add(comparable);
        }

        /// <summary>
        /// Describe el comparable que resulta de desapilar el elemento en el tope de la pila que recibe el mensaje.
        /// </summary>
        /// <returns>Comparable</returns>
        public Comparable desapilar()
        {
            Comparable desapilado = pila[pila.Count - 1];

            pila.Remove(desapilado);

            return desapilado;
        }

        /// <summary>
        /// Describe el elemento comparable en el tope de la pila.
        /// </summary>
        /// <returns>Comparable</returns>
        public Comparable verTope() 
        {
            return pila[pila.Count - 1];
        }

        /// <summary>
        /// Indica si la pila de comparables está vacía.
        /// </summary>
        /// <returns>Bool</returns>
        public bool esVacia()
        {
            return pila.Count == 0;
        }
    }
}
