using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    /// <summary>
    /// Representa objetos que almacenan comparables.
    /// </summary>
    public interface Coleccionable : Iterable
    {
        /// <summary>
        /// Describe la cantidad de elementos que contiene el coleccionable.
        /// </summary>
        /// <returns>Int</returns>
        int cuantos();

        /// <summary>
        /// Describe el elemento más chico del coleccionable que recibe el mensaje.
        /// Precondiciones:
        /// ◽ El coleccionable no debe ser vacío.
        /// </summary>
        /// <returns>Elemento comparable</returns>
        Comparable minimo();

        /// <summary>
        /// Describe el elemento más grande del coleccionable que recibe el mensaje.
        /// Precondiciones:
        /// ◽ El coleccionable no debe ser vacío.
        /// </summary>
        /// <returns>Elemento comparable</returns>
        Comparable maximo();

        /// <summary>
        /// Indica si el coleccionable contiene al elemento comparable dado.
        /// </summary>
        /// <param name="comparable">Elemento comparable</param>
        /// <returns>Booleano</returns>
        bool contiene(Comparable comparable);

        /// <summary>
        /// Agrega al coleccionable el elemento comparable dado.
        /// </summary>
        /// <param name="comparable">Elemento comparable</param>
        void agregar(Comparable comparable);
    }
}
