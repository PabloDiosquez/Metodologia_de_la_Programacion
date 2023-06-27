using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    public interface Iterador
    {
        void primero();

        void siguiente();

        Comparable actual();

        bool fin();
    }
}
