using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_04
{
    public class ComparacionPorCalificacion : EstrategiaDeComparacion
    {
        public bool sosIgual(Comparable comparable1, Comparable comparable2)
        {
            return ((Alumno)comparable1).getCalificacion() == ((Alumno)comparable2).getCalificacion();  
        }

        public bool sosMayor(Comparable comparable1, Comparable comparable2)
        {
            return ((Alumno)comparable1).getCalificacion() > ((Alumno)comparable2).getCalificacion();
        }

        public bool sosMenor(Comparable comparable1, Comparable comparable2)
        {
            return ((Alumno)comparable1).getCalificacion() < ((Alumno)comparable2).getCalificacion();   
        }
    }
}
