using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anexo
{
    public class Resta : IOperacion
    {
        public double operacion(double numero1, double numero2)
        {
            return numero1 - numero2;   
        }
    }
}
