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

            iterador.primero();

            while (!iterador.fin())
            {
                Console.WriteLine(iterador.actual().ToString());

                iterador.siguiente();
            }
        }

        // Ejercicio 9
        /// <summary>
        /// Recibe un coleccionable de alumnos y cambia la estrategia de comparación de los mismos por la estrategia dada.
        /// </summary>
        /// <param name="coleccionable">[Alumno]</param>
        /// <param name="estrategia">EstrategiaDeComparacion</param>
        public static void cambiarEstrategia(Coleccionable coleccionable, EstrategiaDeComparacion estrategia)
        {
            Iterador iterador = coleccionable.crearIterador();

            iterador.primero();

            while (!iterador.fin())
            {
                ((Alumno)iterador.actual()).setEstrategia(estrategia);

                iterador.siguiente();
            }
        }

    }
}
