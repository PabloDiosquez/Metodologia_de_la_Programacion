using System;

namespace Practica_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pequeño ensayo ...

            Comparable primerNumero, segundoNumero;

            primerNumero = new Numero(2);

            segundoNumero = new Numero(6);

            Console.WriteLine(primerNumero.sosMenor(segundoNumero));

            // Una pequeña pila 📚

            // Pila pila = new Pila();

            //pila.apilar(primerNumero);

            //pila.apilar(segundoNumero);

            //// Código genérico 🖖🏼

            //Console.WriteLine("¡Probando la pila!");

            //Console.WriteLine(pila.cuantos());

            //Console.WriteLine(pila.minimo().ToString());

            //Console.WriteLine(pila.maximo().ToString());

            //Comparable tercerNumero = new Numero(2); // Compara por valor, no por referencia 👁

            //Console.WriteLine(pila.contiene(tercerNumero));

            // Probando las funciones ... 🥨

            // 🔴 EJERCICIO 7

            //Coleccionable pila = new Pila();

            //Coleccionable cola = new Cola();

            //llenar(pila);

            //llenar(cola);

            //informar(pila);

            //informar(cola);

            // 🔴 EJERCICIO 9

            Coleccionable pila = new Pila();

            Coleccionable cola = new Cola();

            Coleccionable coleccionMultiple = new ColeccionMultiple((Pila)pila, (Cola)cola);

            llenar(pila);

            llenar(cola);

            informar(pila);

            informar(cola);

            informar(coleccionMultiple);
        }

        // EJERCICIO 5 🛸

        /// <summary>
        /// Agrega 20 comparables elegidos al azar al coleccionable dado.
        /// </summary>
        /// <param name="coleccionable">Coleccionable</param>
        private static void llenar(Coleccionable coleccionable) 
        {
            Random rd = new Random();

            for (int i = 0; i < 20; i++)
            {
                coleccionable.agregar(new Numero(rd.Next(1, 100)));
            }
        }

        // EJERCICIO 6 🛸

        /// <summary>
        /// Imprime por consola la cantidad de elementos que tiene el coleccionable dado, el elemento 
        /// mínimo, el máximo y si contiene, o no, como elemento un valor leído por teclado.
        /// Precondiciones:
        /// ◽ El coleccionable dado no debe ser vacío.
        /// </summary>
        /// <param name="coleccionable">Coleccionable</param>
        private static void informar(Coleccionable coleccionable)
        {
            Console.WriteLine($"¿Cuántos? {coleccionable.cuantos()}");

            Console.WriteLine($"Máximo: {coleccionable.maximo()}");

            Console.WriteLine($"Mínimo: {coleccionable.minimo()}");

            Console.WriteLine("Ingrese un valor: ");

            Comparable nuevoComparable = new Numero(int.Parse(Console.ReadLine()));

            if (coleccionable.contiene(nuevoComparable))
            {
                Console.WriteLine("El elemento leído está en la colección");
            }
            else
            {
                Console.WriteLine("El elemento leído NO está en la colección");
            }
        }
    }
}
