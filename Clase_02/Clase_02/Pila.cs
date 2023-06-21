using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    /// <summary>
    /// Representa una colección de instancias de tamaño variable de último en entrar, 
    /// primero en salir (LIFO) del mismo tipo especificado.
    /// </summary>
    public class Pila: Coleccionable, Iterable
    {
        // Atributos

        private List<Comparable> pila;

        // Constructor 
        public Pila()
        {
            pila = new List<Comparable>();  
        }

        // Métodos de instancia

        /// <summary>
        /// Inserta un elemento en la parte superior de la pila.
        /// </summary>
        /// <param name="comparable">Elemento comparable</param>
        public void apilar(Comparable comparable)
        {
            pila.Add(comparable);
        }

        /// <summary>
        /// Quita un elemento de la parte superior de la pila.
        /// </summary>
        /// <returns>Elemento comparable</returns>
        public Comparable desapilar() 
        {
            Comparable desapilado = pila[pila.Count - 1];

            pila.Remove(desapilado);

            return desapilado;
        }

        /// <summary>
        /// Indica si la pila está vacía.
        /// </summary>
        /// <returns>Bool</returns>
        public bool estaVacia() 
        {
            return cuantos() == 0;  
        }

        /// <summary>
        /// Describe el tope de la pila, es decir, el último elemento.
        /// </summary>
        /// <returns>Elemento comparable</returns>
        public Comparable verTope()
        {
            return pila[pila.Count - 1];
        }

        // Métodos de la interface Coleccionable
        public void agregar(Comparable comparable)
        {
            apilar(comparable);
        }

        public bool contiene(Comparable comparable)
        {
            Iterador iteradorDePila = crearIterador();

            iteradorDePila.primero();

            while (!iteradorDePila.fin() && !iteradorDePila.actual().sosIgual(comparable))
            {
                iteradorDePila.siguiente();
            }

            return !iteradorDePila.fin();
        }

        public int cuantos()
        {
            //return pila.Count;

            Iterador iterador = crearIterador();

            int cantidadDeElementosVistos = 0;

            iterador.primero(); 

            while (!iterador.fin())
            {
                cantidadDeElementosVistos++;

                iterador.siguiente();
            }

            return cantidadDeElementosVistos;
        }

        /// <summary>
        /// ...
        /// Precondición:
        /// ◽ La pila no debe ser vacía.
        /// </summary>
        /// <returns>Elemento comparable</returns>
        public Comparable maximo()
        {
            Iterador iteradorDePila = crearIterador();

            Comparable maximoAlMomento = iteradorDePila.actual();

            iteradorDePila.primero();

            while (!iteradorDePila.fin())
            {
                maximoAlMomento = maximoEntre(iteradorDePila.actual(), maximoAlMomento);

                iteradorDePila.siguiente();
            }

            return maximoAlMomento;
        }

        private Comparable maximoEntre(Comparable comparable1, Comparable comparable2) 
        {
            if (comparable1.sosMayor(comparable2)) 
            {
                return comparable1;
            }

            return comparable2;
        }

        /// <summary>
        /// ...
        /// Precondición:
        /// ◽ La pila no debe ser vacía.
        /// </summary>
        /// <returns>Elemento comparable</returns>
        public Comparable minimo()
        {
            Iterador iterador = crearIterador();

            Comparable minimoAlMomento = iterador.actual();

            iterador.primero();

            while (!iterador.fin())
            {
                minimoAlMomento = minimoEntre(iterador.actual(), minimoAlMomento);

                iterador.siguiente();
            }

            return minimoAlMomento;
        }

        private Comparable minimoEntre(Comparable comparable1, Comparable comparable2)
        {
            if (comparable1.sosMenor(comparable2))
            {
                return comparable1;
            }

            return comparable2;
        }

        // Método de la interface Iterable
        public Iterador crearIterador()
        {
            return new IteradorDeListas(pila);
        }
    }
}
