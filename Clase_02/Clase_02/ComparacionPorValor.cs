using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    public class ComparacionPorValor : EstrategiaDeComparacion
    {
        public bool sosIgual(Comparable comparable1, Comparable comparable2)
        {
            return ((ClaveValor)comparable1).getValor().sosIgual(((ClaveValor)comparable2).getValor());
        }

        public bool sosMayor(Comparable comparable1, Comparable comparable2)
        {
            return ((ClaveValor)comparable1).getValor().sosMayor(((ClaveValor)comparable2).getValor());
        }

        public bool sosMenor(Comparable comparable1, Comparable comparable2)
        {
            return ((ClaveValor)comparable1).getValor().sosMenor(((ClaveValor)comparable2).getValor()); 
        }
    }
}
