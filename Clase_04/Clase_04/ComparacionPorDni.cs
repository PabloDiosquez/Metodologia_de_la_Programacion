using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_04
{
    public class ComparacionPorDni : EstrategiaDeComparacion
    {
        public bool sosIgual(Comparable comparable1, Comparable comparable2)
        {
            return ((Persona)comparable1).getDni() == ((Persona)comparable2).getDni();
        }

        public bool sosMayor(Comparable comparable1, Comparable comparable2)
        {
            return ((Persona)comparable1).getDni() < ((Persona)comparable2).getDni();
        }

        public bool sosMenor(Comparable comparable1, Comparable comparable2)
        {
            return ((Persona)comparable1).getDni() > ((Persona)comparable2).getDni();
        }
    }
}
