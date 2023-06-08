using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_01
{
    //EJERCICIO 3 ☂

    /// <summary>
    /// Representa objetos que almacenan elementos comparables.
    /// </summary>
    public interface Coleccionable
    {
        /// <summary>
        /// Describe la cantidad de elementos comparables que tiene el coleccionable.
        /// </summary>
        /// <returns>int</returns>
        int cuantos();

        /// <summary>
        /// Describe el elemento comparable más chico del coleccionable.
        /// </summary>
        /// <returns>Coleccionable</returns>
        Comparable minimo();

        /// <summary>
        /// Describe el elemento comparable más grande del coleccionable.
        /// </summary>
        /// <returns>Comparable</returns>
        Comparable maximo();

        /// <summary>
        /// Agrega el elemento comparable dado al coleccionable.
        /// </summary>
        /// <param name="comparable"></param>
        void agregar(Comparable comparable);

        /// <summary>
        /// Indica si el coleccionable contiene al elemento comparable dado.
        /// </summary>
        /// <param name="comparable">Elemento comparable según el cual se describe true o false.</param>
        /// <returns>Bool</returns>
        bool contiene(Comparable comparable);
    }
}
