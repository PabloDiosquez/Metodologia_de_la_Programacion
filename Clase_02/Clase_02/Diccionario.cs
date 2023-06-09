﻿using System;
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
    public class Diccionario : Coleccionable, Iterable
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
        /// Describe el valor asociado a la clave recibida por parámetro o null si la clave no existe.
        /// </summary>
        /// <param name="clave">Elemento comparable</param>
        /// <returns>Comparable</returns>
        public Comparable valorDe(Comparable clave)
        {
            return parClaveValorDadaLaClave(clave).getValor();
        }


        // Métodos auxiliares 🖖🏼

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

        private List<Comparable> getValores()
        {
            List<Comparable> valores = new List<Comparable>();

            foreach (ClaveValor claveValor in paresClaveValor.getElementos())
            {
                valores.Add(claveValor.getValor());
            }

            return valores;
        }

        // Métodos de interface
        public int cuantos()
        {
            return paresClaveValor.cuantos();
        }

        /// <summary>
        /// Describe el valor más chico de los pares clave-valor del diccionario que recibe el mensaje.
        /// Precondición: 
        /// ◽ El diccionario no debe ser vacío.
        /// </summary>
        /// <returns>Elemento comparable</returns>
        public Comparable minimo()
        {
            Comparable minimoAlMomento = paresClaveValor.getElementos()[0];

            foreach (Comparable valor in getValores())
            {
                if (valor.sosMenor(minimoAlMomento)) 
                {
                    minimoAlMomento = valor;
                }
            }

            return minimoAlMomento;
        }

        /// <summary>
        /// Describe el valor más grande de los pares clave-valor del diccionario que recibe el mensaje.
        /// Precondición: 
        /// ◽ El diccionario no debe ser vacío.
        /// </summary>
        /// <returns>Elemento comparable</returns>
        public Comparable maximo()
        {
            Comparable maximoAlMomento = paresClaveValor.getElementos()[0];

            foreach (Comparable valor in getValores())
            {
                if (valor.sosMayor(maximoAlMomento))
                {
                    maximoAlMomento = valor;
                }
            }

            return maximoAlMomento;
        }

        /// <summary>
        /// Indica si el elemento comparable dado es uno de los valores de los pares clave-valor del diccionario que recibe el mensaje.
        /// </summary>
        /// <param name="comparable">Valor comparable</param>
        /// <returns>Bool</returns>
        public bool contiene(Comparable valorDado)
        {
            foreach (Comparable valor in getValores())
            {
                if (valor.sosIgual(valorDado))
                {
                    return true;    
                }
            }

            return false;
        }

        public void agregar(Comparable comparable)
        {
            throw new NotImplementedException();
        }

        // Método de la interface iterable
        public Iterador crearIterador()
        {
            return new IteradorDeListas(getValores());
        }
    }
}
