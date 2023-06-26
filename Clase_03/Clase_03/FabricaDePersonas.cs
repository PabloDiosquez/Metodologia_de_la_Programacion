using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    internal class FabricaDePersonas : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            GeneradorDeDatosAleatorios generador = new GeneradorDeDatosAleatorios();

            return new Persona(generador.stringAleatorio(10), generador.numeroAleatorio(1000));
        }

        public override Comparable crearPorTeclado()
        {
            LectorDeDatos lector = new LectorDeDatos(); 

            return new Persona(lector.stringPorTeclado(), lector.numeroPorTeclado());
        }
    }
}
