using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    public class ComparacionPorDni : EstrategiaDeComparacion
    {
        public bool sosIgual(Comparable comparable1, Comparable comparable2)
        {
            return ((Alumno)comparable1).getDni() == ((Alumno)comparable2).getDni();
        }

        public bool sosMayor(Comparable comparable1, Comparable comparable2)
        {
            return ((Alumno)comparable1).getDni() > ((Alumno)comparable2).getDni();
        }

        public bool sosMenor(Comparable comparable1, Comparable comparable2)
        {
            return ((Alumno)comparable1).getDni() < ((Alumno)comparable2).getDni();
        }
    }
}
