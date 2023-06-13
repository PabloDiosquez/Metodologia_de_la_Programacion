using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    public class ClaveValor : Comparable
    {
        private Comparable clave;

        private Object valor;

        public ClaveValor(Comparable clave, Object valor)
        {
            this.clave = clave;

            this.valor = valor;
        }

        // Meétodo de instancia

        public Object getValor()
        {
            return valor;
        }

        public bool sosIgual(Comparable comparable)
        {
            return clave.sosIgual(comparable);
        }

        public bool sosMayor(Comparable comparable)
        {
            return clave.sosMayor(comparable);
        }

        public bool sosMenor(Comparable comparable)
        {
            return clave.sosMenor(comparable);  
        }
    }
}
