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

            Pila pila = new Pila();

            pila.apilar(primerNumero);

            pila.apilar(segundoNumero);

            // Código genérico 🖖🏼

            Console.WriteLine("¡Probando la pila!");

            Console.WriteLine(pila.cuantos());

            Console.WriteLine(pila.minimo().ToString());

            Console.WriteLine(pila.maximo().ToString());

            Comparable tercerNumero = new Numero(2); // Compara por valor, no por referencia 👁

            Console.WriteLine(pila.contiene(tercerNumero));
        }

        // EJERCICIO 5 🛸

        

    }
}
