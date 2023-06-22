using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    /// <summary>
    /// Representa una colección de objetos comparables de tipo primero en entrar, primero en salir.
    /// </summary>
    public class Cola : Coleccionable, Iterable
    {
        // Atributos

        List<Comparable> elementosEncolados;

        // Constructor
        public Cola()
        {
            elementosEncolados = new List<Comparable>();    
        }

        // Métodos de instancia 
        public void encolar(Comparable comparable) 
        {
            elementosEncolados.Add(comparable);
        }

        public Comparable desencolar()
        {
            Comparable desencolado = elementosEncolados[0];
            
            elementosEncolados.Remove(desencolado); 

            return desencolado;
        }

        public bool estaVacia()
        {
            return cuantos() == 0;
        }

        public Comparable verTope() 
        {
            return elementosEncolados[0];
        }

        // Métodos de interface Coleccionable
        public int cuantos()
        {
            Iterador iterador = crearIterador();

            int totalElementosAlMomento = 0;

            iterador.primero();

            while (!iterador.fin())
            {
                totalElementosAlMomento++;

                iterador.siguiente();
            }

            return totalElementosAlMomento;
        }

        public Comparable minimo()
        {
            Iterador iterador = crearIterador();

            iterador.primero();

            Comparable minimoAlMomento = iterador.actual();

            while (!iterador.fin())
            {
                minimoAlMomento = minimoEntre(iterador.actual(), minimoAlMomento);
            }

            return minimoAlMomento;
        }

        public Comparable minimoEntre(Comparable comparable1, Comparable comparable2) 
        {
            if (comparable1.sosMenor(comparable2))
            {
                return comparable1;
            }

            return comparable2;
        }

        public Comparable maximo()
        {
            Iterador iterador = crearIterador();

            iterador.primero();

            Comparable maximoAlMomento = iterador.actual();

            while (!iterador.fin())
            {
                maximoAlMomento = maximoEntre(iterador.actual(), maximoAlMomento);
            }

            return maximoAlMomento; 
        }

        public Comparable maximoEntre(Comparable comparable1, Comparable comparable2)
        {
            if (comparable1.sosMayor(comparable2))
            {
                return comparable1;
            }

            return comparable2;
        }

        public bool contiene(Comparable comparable)
        {
            Iterador iterador = crearIterador();

            iterador.primero();

            while (!iterador.fin() && !iterador.actual().sosIgual(comparable))
            {
                iterador.siguiente();
            }

            return !iterador.fin();
        }

        public void agregar(Comparable comparable)
        {
            encolar(comparable);
        }

        // Método de la interface Iterable
        public Iterador crearIterador()
        {
            return new IteradorDeListas(elementosEncolados);
        }
    }
}
