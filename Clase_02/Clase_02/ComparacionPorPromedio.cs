using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    // Compara alumnos según su promedio.
    public class ComparacionPorPromedio : EstrategiaDeComparacion
    {
        public bool sosIgual(Comparable comparable1, Comparable comparable2)
        {
            return ((Alumno)comparable1).getPromedio() == ((Alumno)comparable2).getPromedio();  
        }

        public bool sosMayor(Comparable comparable1, Comparable comparable2)
        {
            return ((Alumno)comparable1).getPromedio() > ((Alumno)comparable2).getPromedio();
        }

        public bool sosMenor(Comparable comparable1, Comparable comparable2)
        {
            return ((Alumno)comparable1).getPromedio() < ((Alumno)comparable2).getPromedio();
        }
    }
}
