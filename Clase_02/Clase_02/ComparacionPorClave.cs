using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    public class ComparacionPorClave : EstrategiaDeComparacion
    {
        public bool sosIgual(Comparable comparable1, Comparable comparable2)
        {
            return ((ClaveValor)comparable1).getClave().sosIgual(((ClaveValor)comparable2).getClave());
        }

        public bool sosMayor(Comparable comparable1, Comparable comparable2)
        {
            return ((ClaveValor)comparable1).getClave().sosMayor(((ClaveValor)comparable2).getClave()); 
        }

        public bool sosMenor(Comparable comparable1, Comparable comparable2)
        {
            return ((ClaveValor)comparable1).getClave().sosMenor(((ClaveValor)comparable2).getClave());
        }
    }
}
