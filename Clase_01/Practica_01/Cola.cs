using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_01
{
    // EJERCICIO 4 🥨

    /// <summary>
    /// Representa una colección de elementos comparables de tipo primero en entrar, primero en salir.
    /// </summary>
    public class Cola: Coleccionable
    {
        // Atributos
        private List<Comparable> elementos;

        // Constructor

        public Cola()
        {
            elementos = new List<Comparable>();
        }

        // Métodos de clase

        /// <summary>
        /// Agrega al final de la cola el elemento comparable dado. 
        /// </summary>
        /// <param name="comparable">Comparable</param>
        public void encolar(Comparable comparable)
        {
            elementos.Add(comparable);
        }

        /// <summary>
        /// Remueve el primer elemento (ie, el elemento más antiguo) de la cola que recibe el mensaje.
        /// </summary>
        /// <returns>Comparable</returns>
        public Comparable desencolar() 
        {
            //Comparable desencolado = elementos.FirstOrDefault(); 🙊

            Comparable desencolado = elementos[0];

            elementos.RemoveAt(0);

            return desencolado;
        }

        /// <summary>
        /// Describe el elemento comparable más antiguo de la cola que recibe el mensaje, pero no lo quita de la misma.
        /// </summary>
        /// <returns>Comparable</returns>
        public Comparable verTope()
        {
            return elementos[0];
        }

        /// <summary>
        /// Indica si la cola está vacía.
        /// </summary>
        /// <returns>Bool</returns>
        public bool esVacia() 
        {
            return elementos.Count == 0;
        }

        // Métodos de la interfaz
        public int cuantos()
        {
            return elementos.Count();
        }

        public Comparable minimo()
        {
            Comparable minimoAlMomento = elementos[0];

            foreach (Comparable comparable in elementos)
            {
                if (comparable.sosMenor(minimoAlMomento)) 
                {
                    minimoAlMomento = comparable;
                }
            }

            return minimoAlMomento;
        }

        public Comparable maximo()
        {
            Comparable maximoAlMomento = elementos[0];

            foreach (Comparable comparable in elementos)
            {
                if (comparable.sosMayor(maximoAlMomento))
                {
                    maximoAlMomento = comparable;
                }
            }

            return maximoAlMomento
        }

        public void agregar(Comparable comparable)
        {
            elementos.Add(comparable);
        }

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
