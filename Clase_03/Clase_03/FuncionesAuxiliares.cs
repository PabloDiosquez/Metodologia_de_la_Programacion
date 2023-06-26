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
            for (int i = 0; i < 20; i++)
            {
                int opcion = new LectorDeDatos().numeroPorTeclado();

                coleccionable.agregar(FabricaDeComparables.crearProducto(opcion));
            }
        }

        public static void informar(Coleccionable coleccionable)
        {
            Console.WriteLine($"Cantidad de elementos: {coleccionable.cuantos()}");
            Console.WriteLine($"Mínimo: {coleccionable.minimo().ToString()}");
            Console.WriteLine($"Máximo: {coleccionable.maximo().ToString()}");

            Console.WriteLine("Número:");
            if (coleccionable.contiene(new Numero(int.Parse(Console.ReadLine()))))
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
