using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    // Modela un diccionario. Un Diccionario es una colección que almacena elementos, donde cada elemento tiene una
    // clave asociada.Las claves no pueden repetirse.
    public class Diccionario
    {
        // Atributos

        private Conjunto elementos;

        // Constructor
        public Diccionario()
        {
            elementos = new Conjunto();
        }

        // Métodos de instancia

        /// <summary>
        /// Agregar el elemento de tipo ClaveValor al diccionario dado, formado por el la clave y el valor dados, siempre que
        /// la clave no esté en el diccionario.
        /// </summary>
        /// <param name="clave"></param>
        /// <param name="valor"></param>
        public void agregar(Comparable clave, Object valor)
        {
            ClaveValor claveValor = new ClaveValor(clave, valor);

            elementos.agregar(claveValor);
        }

        /// <summary>
        /// Describe el valor de **claveValor**.
        /// </summary>
        /// <param name="claveValor">ClaveValor</param>
        /// <returns>Object</returns>
        public Object valorDe(ClaveValor claveValor)
        {
            return claveValor.getValor();
        }
    }
}
