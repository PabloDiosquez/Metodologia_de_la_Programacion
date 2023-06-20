using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    public interface EstrategiaDeComparacion
    {
        bool sosIgual(Comparable comparable1, Comparable comparable2);

        bool sosMayor(Comparable comparable1, Comparable comparable2);

        bool sosMenor(Comparable comparable1, Comparable comparable2);
    }
}
