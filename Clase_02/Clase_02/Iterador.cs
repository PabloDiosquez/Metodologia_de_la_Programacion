using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    // Paso 1: Interface Iterador
    public interface Iterador
    {
        void primero();

        void siguiente();

        bool fin();

        Comparable actual();
    }
}
