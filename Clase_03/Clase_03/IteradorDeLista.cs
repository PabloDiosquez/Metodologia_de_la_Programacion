using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    public class IteradorDeLista : Iterador
    {
        private List<Comparable> elementosIterados;

        int indice = 0;

        public IteradorDeLista(List<Comparable> elementosIterados)
        {
            this.elementosIterados = elementosIterados;
        }

        public Comparable actual()
        {
            return elementosIterados[indice];
        }

        public bool fin()
        {
            return indice == elementosIterados.Count;
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
