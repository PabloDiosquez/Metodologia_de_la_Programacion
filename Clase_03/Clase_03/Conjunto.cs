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
            throw new NotImplementedException();
        }

        public bool contiene(Comparable comparable)
        {
            throw new NotImplementedException();
        }

        public int cuantos()
        {
            throw new NotImplementedException();
        }

        public Comparable maximo()
        {
            throw new NotImplementedException();
        }

        public Comparable minimo()
        {
            throw new NotImplementedException();
        }

        // Método de la interface Iterable

        public Iterador crearIterador()
        {
            return new IteradorDeLista(elementos);
        }

    }
}
