using System;

namespace Anexo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pequeña calculadora 🤯

            double numero1, numero2;

            IOperacion operacion = null;    

            while (true)
            {
                Console.WriteLine("0: Salir -- 1: Suma -- 2: Resta -- 3: Multiplicación -- 4: División");

                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 0) break;

                Console.WriteLine("Primer número:");

                numero1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Segundo número:");

                numero2 = double.Parse(Console.ReadLine());    

                switch (opcion)
                {
                    case 1:
                        operacion = new Suma();
                        break;
                    case 2:
                        operacion = new Resta();
                        break;
                    case 3:
                        operacion = new Producto();
                        break;
                    case 4:
                        operacion = new Division();
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

                Console.WriteLine($"Resultado: {operacion.operacion(numero1, numero2)}");
            }
        }
    }
}
