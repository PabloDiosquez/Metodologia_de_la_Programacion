using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_04
{
    public interface Comparable
    {
        bool sosIgual(Comparable comparable);

        bool sosMenor(Comparable comparable);

        bool sosMayor(Comparable comparable);
    }
}
