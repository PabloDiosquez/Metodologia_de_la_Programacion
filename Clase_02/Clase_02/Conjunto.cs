using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    // Ejercicio 3

    /// <summary>
    /// Modela un conjunto. Un conjunto es una colección de elementos sin ninguna repetición. Es decir, si se intenta 
    /// almacenar un elemento que ya está en el conjunto, éste elemento no se almacena ya que sino estaría repetido.
    /// </summary>
    public class Conjunto
    {
        // Atributos

        private List<Comparable> conjunto;

        // Constructor

        public Conjunto()
        {
            conjunto = new List<Comparable>();
        }

        // Métodos de instancia

        /// <summary>
        /// Agrega el elemento comparable dado al conjunto que reciba el mensaje, en caso de que el elemento no
        /// pertenezca a éste último.
        /// </summary>
        /// <param name="elemento">Elemento comparable</param>
        public void agregar(Comparable elemento)
        {
            if (!pertenece(elemento))
            {
                conjunto.Add(elemento);
            }
        }

        /// <summary>
        /// Indica si el elemento comparable dado pertenece al conjunto que recibe el mensaje.
        /// </summary>
        /// <param name="comparable">Elemento comparable</param>
        /// <returns>Bool</returns>
        public bool pertenece(Comparable comparable)
        {
            foreach (Comparable elemento in conjunto)       
            {                                               
                if (elemento.sosIgual(comparable))          
                {
                    return true;
                }
            }
            
            return false;
        }
    }
}
