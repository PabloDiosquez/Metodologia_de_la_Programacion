using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    // Paso 2: Implementar el iterador (concreto) de listas.
    public class IteradorDeListas : Iterador
    {
        // Atributos 

        private List<Comparable> lista;

        private int indice;

        // Constructor

        public IteradorDeListas(List<Comparable> lista)
        {
            this.lista = lista;

            indice = 0;
        }
        public Comparable actual()
        {
            return lista[indice];
        }

        public bool fin()
        {
            return indice == lista.Count;    
        }

        public void primero()
        {
            indice = 0;
        }

        public void siguiente()
        {
            indice++;
        }
    }
}
