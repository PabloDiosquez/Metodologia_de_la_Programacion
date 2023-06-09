﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    public class ComparacionPorNombre : EstrategiaDeComparacion
    {
        public bool sosIgual(Comparable comparable1, Comparable comparable2)
        {
            return ((Alumno)comparable1).getNombre() == ((Alumno)comparable2).getNombre();  
        }

        public bool sosMayor(Comparable comparable1, Comparable comparable2)
        {
            return ((Alumno)comparable1).getNombre().CompareTo(((Alumno)comparable2).getNombre()) > 0;
        }

        public bool sosMenor(Comparable comparable1, Comparable comparable2)
        {
            return ((Alumno)comparable1).getNombre().CompareTo(((Alumno)comparable2).getNombre()) < 0;
        }
    }
}
