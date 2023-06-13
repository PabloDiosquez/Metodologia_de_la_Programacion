using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    // Clase documentada en el archivo Clase_01
    public interface Coleccionable
    {
        int cuantos();

        Comparable minimo();

        Comparable maximo();

        void agregar(Comparable comparable);

        bool contiene(Comparable comparable);
    }
}
