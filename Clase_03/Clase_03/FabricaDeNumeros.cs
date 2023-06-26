using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    public class FabricaDeNumeros : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            return new Numero(new GeneradorDeDatosAleatorios().numeroAleatorio(1000));
        }

        public override Comparable crearPorTeclado()
        {
            return new Numero(new LectorDeDatos().numeroPorTeclado());
        }
    }
}
