using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_01
{
    public class ColeccionMultiple: Coleccionable
    {
        // Atributos 

        private Pila pila;

        private Cola cola;

        // Constructor
        public ColeccionMultiple(Pila pila, Cola cola)
        {
            this.pila = pila;

            this.cola = cola;
        }

        public void agregar(Comparable comparable)
        {
            
        }

        /// <summary>
        /// Indica si el elemento comparable dado está en alguna de los coleccionables (pila, cola) o en ambas.
        /// </summary>
        /// <param name="comparable">Comparable</param>
        /// <returns>Bool</returns>
        public bool contiene(Comparable comparable)
        {
            return pila.contiene(comparable) || cola.contiene(comparable);
        }

        /// <summary>
        /// Describe el total de elementos comparables que tienen ambos coleccionables.
        /// </summary>
        /// <returns>int</returns>
        public int cuantos()
        {
            return pila.cuantos() + cola.cuantos();
        }

        /// <summary>
        /// Describe el valor más grande de todos los elementos comparables de ambos coleccionables.
        /// Precondiciones:
        /// ◽ Ambos coleccionables deben ser no vacíos.
        /// </summary>
        /// <returns>Comparable</returns>
        public Comparable maximo()
        {
            if (pila.maximo().sosMayor(cola.maximo()))
            {
                return pila.maximo();   
            }

            return cola.maximo();
        }

        /// <summary>
        /// Describe el valor más chico de todos los elementos comparables de ambos coleccionables.
        /// Precondiciones:
        /// ◽ Ambos coleccionables deben ser no vacíos.
        /// </summary>
        /// <returns>Comparable</returns>
        public Comparable minimo()
        {
            if (pila.minimo().sosMenor(cola.minimo()))
            {
                return pila.minimo();
            }

            return cola.minimo();
        }
    }
}
