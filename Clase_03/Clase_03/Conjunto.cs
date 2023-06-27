using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    public class Conjunto : Coleccionable, Iterable
    {
        // Atributo

        private List<Comparable> elementos;

        // Constructor 

        public Conjunto()
        {
            elementos = new List<Comparable>();
        }

        // Métodos de la interface Coleccionable
        public void agregar(Comparable comparable)
        {
            if (!contiene(comparable)) 
            {
                elementos.Add(comparable);  
            }
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

        public int cuantos()
        {
            Iterador iterador = crearIterador();

            int cantidadElementosAlMomento = 0;

            iterador.primero();

            while (!iterador.fin())
            {
                cantidadElementosAlMomento++;

                iterador.siguiente();
            }

            return cantidadElementosAlMomento;
        }

        public Comparable maximo()
        {
            Iterador iterador = crearIterador();

            iterador.primero();

            Comparable maximoAlMomento = iterador.actual();

            while (!iterador.fin())
            {
                maximoAlMomento = maximoEntre(iterador.actual(), maximoAlMomento);

                iterador.siguiente();
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

        public Comparable minimo()
        {
            Iterador iterador = crearIterador();

            iterador.primero();

            Comparable minimoAlMomento = iterador.actual();

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
            return new IteradorDeLista(elementos);
        }

    }
}
