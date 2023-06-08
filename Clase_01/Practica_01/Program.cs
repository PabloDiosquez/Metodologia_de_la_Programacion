using System;

namespace Practica_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pequeño ensayo ...

            Numero primerNumero = new Numero(2);

            Numero segundoNumero = new Numero(6);

            Console.WriteLine(primerNumero.sosMenor(segundoNumero));
        }
    }
}
