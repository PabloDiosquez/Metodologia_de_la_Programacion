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
    public class Pila: Coleccionable
    {
        // Atributos 

        List<Comparable> elementos;

        // Constructor
        public Pila()
        {
            elementos = new List<Comparable>();
        }

        // Métodos de la clase 

        /// <summary>
        /// Apila el elemento comparable dado en la pila que recibe el mensaje.
        /// </summary>
        /// <param name="comparable">Elemento comparable que se apila en la pila</param>
        public void apilar(Comparable comparable)
        {
            elementos.Add(comparable);
        }

        /// <summary>
        /// Describe el comparable que resulta de desapilar el elemento en el tope de la pila que recibe el mensaje.
        /// Precondición:
        /// ◽ La pila que recibe el mensaje debe ser no vacía.
        /// </summary>
        /// <returns>Comparable</returns>
        public Comparable desapilar()
        {
            Comparable desapilado = elementos[elementos.Count - 1];

            elementos.RemoveAt(elementos.Count - 1);

            return desapilado;
        }

        /// <summary>
        /// Describe el elemento comparable en el tope de la pila.
        /// </summary>
        /// <returns>Comparable</returns>
        public Comparable verTope() 
        {
            return elementos[elementos.Count - 1];
        }

        /// <summary>
        /// Indica si la pila de comparables está vacía.
        /// </summary>
        /// <returns>Bool</returns>
        public bool esVacia()
        {
            return elementos.Count == 0;
        }

        // Métodos de la interfaz

        /// <summary>
        /// Describe la cantidad de elementos comparables que tiene el coleccionable que recibe el mensaje.
        /// </summary>
        /// <returns></returns>
        public int cuantos()
        {
            return elementos.Count;
        }

        /// <summary>
        /// Describe el elemento más grande de la pila de elementos comparables dada.
        /// Precondiciones: 
        /// ◽ La pila que recibe el mensaje no debe ser vacía.
        /// </summary>
        /// <returns>Comparable</returns>
        public Comparable maximo()
        {
            Comparable maximoAlMomento = verTope();

            foreach (Comparable comparable in elementos)
            {
                if (comparable.sosMayor(maximoAlMomento))
                {
                    maximoAlMomento = comparable;
                }
            }

            return maximoAlMomento;
        }

        /// <summary>
        /// Describe el elemento más chico de la pila de elementos comparables dada.
        /// Precondiciones: 
        /// ◽ La pila que recibe el mensaje no debe ser vacía.
        /// </summary>
        /// <returns>Comparable</returns>
        public Comparable minimo()
        {
            Comparable minimoAlMomento = verTope();

            foreach (Comparable comparable in elementos)
            {
                if (comparable.sosMenor(minimoAlMomento))
                {
                    minimoAlMomento = comparable;
                }
            }

            return minimoAlMomento;
        }

        /// <summary>
        /// Agrega el elemento comparable dado a la pila de comparables que recibe el mensaje.
        /// </summary>
        /// <param name="comparable">Comparable</param>
        public void agregar(Comparable comparable)
        {
            apilar(comparable);
        }

        /// <summary>
        /// Indica si la pila contiene al elemento comparable dado.
        /// </summary>
        /// <param name="comparableDado">Comparable</param>
        /// <returns>Bool</returns>
        public bool contiene(Comparable comparableDado)
        {
            foreach (Comparable comparable in elementos)
            {
                if (comparable.sosIgual(comparableDado))
                {
                    return true;
                }
            }
            
            return false;
        }
    }
}
