using System;

namespace Clase_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ¿Cómo usar un iterador? 🙊 

            Conjunto conjunto = new Conjunto();

            imprimir(conjunto);
        }

        public static void imprimir(Iterable iterable)
        {
            Iterador iterador = iterable.crearIterador();

            while (!iterador.fin())
            {
                Console.WriteLine(iterador.actual().ToString());

                iterador.siguiente();
            }
        }

    }
}
