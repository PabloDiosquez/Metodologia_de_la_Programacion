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
    public class Conjunto : Coleccionable
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
        /// Agrega el elemento comparable dado al conjunto que reciba el mensaje, en caso de que el elemento no
        /// pertenezca a éste último.
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
        /// Indica si el elemento comparable dado pertenece al conjunto que recibe el mensaje.
        /// </summary>
        /// <param name="comparable">Elemento comparable</param>
        /// <returns>Bool</returns>
        public bool pertenece(Comparable comparable)
        {
            foreach (Comparable elemento in elementos)
            {
                if (elemento.sosIgual(comparable))
                {
                    return true;
                }
            }

            return false;
        }

        public List<Comparable> getElementos()
        {
            return elementos;
        }

        // Métodos de interfaz
        public bool contiene(Comparable comparable)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Describe la cantidad de elementos del conjunto dado.
        /// </summary>
        /// <returns>Int</returns>
        public int cuantos()
        {
            return elementos.Count;
        }

        /// <summary>
        /// Describe el elemento más grande del conjunto de elementos dado.
        /// Precondiciones:
        /// ◽ El conjunto dado no debe ser vacío.
        /// </summary>
        /// <returns>Comparable</returns>
        public Comparable maximo()
        {
            Comparable maximoAlMomento = elementos.First();

            foreach (Comparable elemento in elementos)
            {
                if (elemento.sosMayor(maximoAlMomento))
                {
                    maximoAlMomento = elemento;
                }
            }

            return maximoAlMomento;
        }

        /// <summary>
        /// Describe el elemento más chico del conjunto de elementos dado.
        /// Precondiciones:
        /// ◽ El conjunto dado no debe ser vacío.
        /// </summary>
        /// <returns>Comparable</returns>
        public Comparable minimo()
        {
            Comparable minimoAlMomento = elementos.First();

            foreach (Comparable elemento in elementos)
            {
                if (elemento.sosMenor(minimoAlMomento)) 
                {
                    minimoAlMomento = elemento;
                }
            }

            return minimoAlMomento;
        }

    }
}
