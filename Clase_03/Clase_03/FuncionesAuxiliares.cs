using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    public static class FuncionesAuxiliares
    {
        public static void llenar(Coleccionable coleccionable)
        {
            Console.WriteLine("Id Producto:");

            int opcion = new LectorDeDatos().numeroPorTeclado();

            for (int i = 0; i < 20; i++)
            {
                coleccionable.agregar(FabricaDeComparables.crearProductoAleatorio(opcion));
            }
        }

        public static void informar(Coleccionable coleccionable)
        {
            Console.WriteLine($"Cantidad de elementos: {coleccionable.cuantos()}");
            Console.WriteLine($"Mínimo: {coleccionable.minimo().ToString()}");
            Console.WriteLine($"Máximo: {coleccionable.maximo().ToString()}");

            Console.WriteLine("Id Producto:");
            int opcion = new LectorDeDatos().numeroPorTeclado();
            if (coleccionable.contiene(FabricaDeComparables.crearProductoPorTeclado(opcion)))
            {
                Console.WriteLine("El comparable está contenido en el coleccionable.");
            }
            else
            {
                Console.WriteLine("El comparable NO está contenido en el coleccionable.");
            }
        }
    }
}
