using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    /// <summary>
    /// Modela un conjunto. Un conjunto es una colección que almacena elementos sin repetición.Es decir, si se intenta
    /// almacenar un elemento que ya está en el conjunto, éste elemento no se almacena ya que sino estaría repetido.
    /// </summary>
    public class Conjunto : Coleccionable, Iterable
    {
        // Atributos 

        private List<Comparable> elementos;

        // Constructor 
        public Conjunto()
        {
            elementos = new List<Comparable>();
        }

        // Métodos de instancia 

        /// <summary>
        /// Describe los elementos de tipo Comparable que contiene el conjunto.
        /// </summary>
        /// <returns>Lista de comparables</returns>
        public List<Comparable> getElementos()
        {
            return elementos;
        }

        /// <summary>
        /// Agrega al conjunto que recibe el mensaje el elemento dado, si éste no está repetido.
        /// </summary>
        /// <param name="elemento">Elemento comparable</param>
        public void agregar(Comparable elemento)
        {
            if (!pertenece(elemento)) 
            {
                elementos.Add(elemento);
            }
        }

        /// <summary>
        /// Indica si el elemento dado está contenido en el conjunto que recibe el mensaje.
        /// </summary>
        /// <param name="comparable">Elemento comparable</param>
        /// <returns>Bool</returns>
        public bool pertenece(Comparable comparable) 
        {
            foreach (Comparable elemento in getElementos())
            {
                if (elemento.sosIgual(comparable))
                {
                    return true;
                }
            }

            return false;
        }

        // Métodos de la interface Comparable

        /// <summary>
        /// Describe la cantidad de elementos del conjunto que recibe el mensaje.
        /// </summary>
        /// <returns>int</returns>
        public int cuantos()
        {
            return elementos.Count;
        }

        /// <summary>
        /// Describe el elemento más chico de todos los comparables del conjunto que recibe el mensaje.
        /// </summary>
        /// <returns>Elemento comparable</returns>
        public Comparable minimo()
        {
            Comparable minimoAlMomento = elementos[0];

            foreach (Comparable elemento in getElementos())
            {
                if (elemento.sosMenor(minimoAlMomento))
                {
                    minimoAlMomento = elemento;
                }
            }

            return minimoAlMomento;
        }

        /// <summary>
        /// Describe el elemento más grande de todos los comparables del conjunto que recibe el mensaje.
        /// </summary>
        /// <returns>Comparable</returns>
        public Comparable maximo()
        {
            Comparable maximoAlMomento = elementos[0];

            foreach (Comparable elemento in getElementos())
            {
                if (elemento.sosMayor(maximoAlMomento))
                {
                    maximoAlMomento = elemento;
                }
            }

            return maximoAlMomento;
        }

        /// <summary>
        /// Indica si el elemento comparable dado está contenido en el conjunto que recibe el mensaje.
        /// </summary>
        /// <param name="comparable">Elemento comparable</param>
        /// <returns>Bool</returns>
        public bool contiene(Comparable comparable)
        {
            return pertenece(comparable);
        }

        // Método interface Iterable
        public Iterador crearIterador()
        {
            return new IteradorDeListas(elementos);
        }
    }
}
