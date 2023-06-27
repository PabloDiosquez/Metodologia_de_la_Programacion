using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    public interface IObservador
    {
        void actualizar(double numero, IObservado observado);
    }
}
