using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    // Modela un diccionario. Un Diccionario es una colección que almacena elementos, donde cada elemento tiene una
    // clave asociada.Las claves no pueden repetirse.
    public class Diccionario : Coleccionable    
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
        /// Agregar el elemento de tipo ClaveValor al diccionario dado, formado por el la clave y el valor dados, siempre que
        /// la clave no esté en el diccionario.
        /// </summary>
        /// <param name="clave"></param>
        /// <param name="valor"></param>
        public void agregar(Comparable clave, Comparable valor)
        {
            if (getClaves().pertenece(clave))
            {
                // TODO: Usar el método setValor_DelParDeClave_(Comparable valor, Comparable clave) para setear el valor de la clave.
            }
            else 
            {
                paresClaveValor.agregar(new ClaveValor(clave, valor));
            }
        }

        /// <summary>
        /// Describe el valor asociado a la clave recibida por parámetro, en caso de que ésta pertenezca al diccionario; en 
        /// caso contrario, describe null.
        /// </summary>
        /// <param name="claveValor">ClaveValor</param>
        /// <returns>Comparable</returns>
        public Comparable valorDe(Comparable clave)
        {
            foreach (ClaveValor claveValor in paresClaveValor.getElementos())
            {
                if (claveValor.getClave().sosIgual(clave))
                {
                    return claveValor.getValor();
                }
            }

            return null;
        }

        /// <summary>
        /// Describe el conjunto formado por todos los pares clave-valor del diccionario que recibe el mensaje.
        /// </summary>
        /// <returns>Conjunto</returns>
        private Conjunto getElementos()
        {
            return paresClaveValor;
        }

        /// <summary>
        /// Describe el conjunto formado por todas las claves del diccionario que recibe el mensaje.
        /// </summary>
        /// <returns>Conjunto de claves (tipo Comparable)</returns>
        private Conjunto getClaves()
        {
            Conjunto claves = new Conjunto();

            foreach (ClaveValor claveValor in paresClaveValor.getElementos())
            {
                claves.agregar(claveValor.getClave());
            }

            return claves;
        }

        // Métodos de interfaz
        public void agregar(Comparable comparable)
        {

        }

        /// <summary>
        /// Indica si el valor dado es valor de algún par clave-valor del diccionario que recibe el mensaje.
        /// </summary>
        /// <param name="valor">Valor - Tipo: Comparable</param>
        /// <returns>Bool</returns>
        public bool contiene(Comparable valor)
        {
            foreach (ClaveValor claveValor in paresClaveValor.getElementos())
            {
                if (claveValor.getValor().sosIgual(valor))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Describe la cantidad de elementos del diccionario dado.
        /// </summary>
        /// <returns>Int</returns>
        public int cuantos()
        {
            return paresClaveValor.cuantos();
        }

        /// <summary>
        /// Describe el valor más grande del diccionario dado.
        /// </summary>
        /// <returns>Co</returns>
        /// <exception cref="NotImplementedException"></exception>
        public Comparable maximo()
        {
            throw new NotImplementedException();
        }

        public Comparable minimo()
        {
            throw new NotImplementedException();
        }

    }
}
