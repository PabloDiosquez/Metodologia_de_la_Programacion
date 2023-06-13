using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    // Implementar subclases. Cada subclase es una estrategia distinta.
    // Una subclase por cada manera de comparar dos alumnos.
    public class ComparacionPorLegajo : EstrategiaDeComparacion
    {
        public bool sosIgual(Comparable comparable1, Comparable comparable2)
        {
            return ((Alumno)comparable1).getLegajo() == ((Alumno)comparable2).getLegajo();
        }

        public bool sosMayor(Comparable comparable1, Comparable comparable2)
        {
            return ((Alumno)comparable1).getLegajo() > ((Alumno)comparable2).getLegajo();
        }

        public bool sosMenor(Comparable comparable1, Comparable comparable2)
        {
            return ((Alumno)comparable1).getLegajo() < ((Alumno)comparable2).getLegajo();
        }
    }
}
