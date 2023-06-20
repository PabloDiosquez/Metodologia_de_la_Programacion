using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    /// <summary>
    /// Un Diccionario es una colección que almacena elementos, donde cada elemento tiene una clave asociada.
    /// Las claves no pueden repetirse.
    /// </summary>
    public class Diccionario
    {
        // Atributos

        private Conjunto paresClaveValor;

        // Constructor

        public Diccionario() 
        {
            paresClaveValor = new Conjunto();
        }

        // Métodos de instancia

        /// <summary>
        /// agrega la asociación clave-valor al diccionario si es que la clave no existe en el diccionario.Si la clave existe, 
        /// entonces reemplaza el valor asociado.
        /// </summary>
        /// <param name="clave">Elemento comparable</param>
        /// <param name="valor">Elemento comparable</param>
        public void agregar(Comparable clave, Comparable valor)
        {
            if (existeClave(clave))
            {
                parClaveValorDadaLaClave(clave).setValor(valor);
            }
            else 
            {
                paresClaveValor.agregar(new ClaveValor(clave, valor));
            }
        }

        /// <summary>
        /// Indica si la clave dada existe en el diccionario que recibe el mensaje.
        /// </summary>
        /// <param name="clave">Elemento comparable</param>
        /// <returns>Bool</returns>
        private bool existeClave(Comparable claveABuscar)
        {
            foreach (Comparable clave in getClaves())
            {
                if (clave.sosIgual(claveABuscar)) 
                {
                    return true;
                }
            }

            return false;
        }

        private ClaveValor parClaveValorDadaLaClave(Comparable claveDada)
        {
            foreach (ClaveValor parClaveValor in paresClaveValor.getElementos())
            {
                if (parClaveValor.getClave().sosIgual(claveDada))
                {
                    return parClaveValor;
                }
            }

            return null;
        }

        private List<Comparable> getClaves()
        {
            List<Comparable> claves = new List<Comparable>();

            foreach (ClaveValor claveValor in paresClaveValor.getElementos()) 
            {
                claves.Add(claveValor.getClave());
            }

            return claves;
        }
    }
}
