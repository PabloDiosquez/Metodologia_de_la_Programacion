using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_01
{
    // EJERCICIO 1 🐸
    //Nota: Asumiremos que el elemento que recibe el mensaje y el objeto recibido por parámetro
    //son del “mismo tipo”.

    /// <summary>
    /// Representa cualquier objeto que sabe comparase con otro objeto de su “mismo tipo”.
    /// </summary>
    public interface Comparable
    {
        /// <summary>
        /// Describe true si el objeto que recibe el mensaje es el mismo que el “comparable” recibido por parámetro, 
        /// describe false en caso contrario.
        /// </summary>
        /// <returns>Bool</returns>
        bool sosIgual(Comparable comparable);

        /// <summary>
        /// Describe true si el objeto que recibe el mensaje es más chico que el “comparable” recibido por parámetro; 
        /// describe false en caso contrario.
        /// </summary>
        /// <returns>Bool</returns>
        bool sosMenor(Comparable comparable);

        /// <summary>
        /// Describe true si el objeto que recibe el mensaje es más chico que el "comparable" recibido por parámetro;
        /// describe false en caso contrario.
        /// </summary>
        /// <returns>Bool</returns>
        bool sosMayor(Comparable comparable);

    }
}
