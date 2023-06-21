using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    /// <summary>
    /// Representa una colección de instancias de tamaño variable de último en entrar, 
    /// primero en salir (LIFO) del mismo tipo especificado.
    /// </summary>
    public class Pila: Coleccionable
    {
        // Atributos

        private List<Comparable> pila;

        // Constructor 
        public Pila()
        {
            pila = new List<Comparable>();  
        }

        // Métodos de instancia

        /// <summary>
        /// Inserta un elemento en la parte superior de la pila.
        /// </summary>
        /// <param name="comparable">Elemento comparable</param>
        public void apilar(Comparable comparable)
        {
            pila.Add(comparable);
        }

        /// <summary>
        /// Quita un elemento de la parte superior de la pila.
        /// </summary>
        /// <returns>Elemento comparable</returns>
        public Comparable desapilar() 
        {
            Comparable desapilado = pila[pila.Count - 1];

            pila.Remove(desapilado);

            return desapilado;
        }

        /// <summary>
        /// Indica si la pila está vacía.
        /// </summary>
        /// <returns>Bool</returns>
        public bool estaVacia() 
        {
            return pila.Count == 0;  
        }

        /// <summary>
        /// Describe el tope de la pila, es decir, el último elemento.
        /// </summary>
        /// <returns>Elemento comparable</returns>
        public Comparable verTope()
        {
            return pila[pila.Count - 1];
        }

        // Métodos de la interface Coleccionable
        public void agregar(Comparable comparable)
        {
            throw new NotImplementedException();
        }

        public bool contiene(Comparable comparable)
        {
            throw new NotImplementedException();
        }

        public int cuantos()
        {
            throw new NotImplementedException();
        }

        public Comparable maximo()
        {
            throw new NotImplementedException();
        }

        public Comparable minimo()
        {
            throw new NotImplementedException();
        }
    }
}
