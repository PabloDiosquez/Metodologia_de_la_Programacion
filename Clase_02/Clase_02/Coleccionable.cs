using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    /// <summary>
    /// Representa objetos que almacenan comparables.
    /// </summary>
    public interface Coleccionable
    {
        int cuantos();

        Comparable minimo();

        Comparable maximo();

        bool contiene(Comparable comparable);

        void agregar(Comparable comparable);
    }
}
