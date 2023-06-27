using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    public interface IObservado
    {
        void agregar(IObservador observador);

        void quitar(IObservador observador);

        void notificar(double numero);
    }
}
