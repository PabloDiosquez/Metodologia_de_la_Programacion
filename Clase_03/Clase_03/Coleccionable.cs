using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    public interface Coleccionable
    {
        int cuantos();

        void agregar(Comparable comparable);

        bool contiene(Comparable comparable);

        Comparable maximo();

        Comparable minimo();
    }
}
