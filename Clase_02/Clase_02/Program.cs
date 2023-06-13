using System;

namespace Clase_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pequeñas pruebas... 🖖🏼

            Alumno alumno1 = new Alumno(123456, "Alberto", 12, 7.2);

            Alumno alumno2 = new Alumno(123789, "Matías", 12, 8.9);

            Console.WriteLine(alumno1.sosIgual(alumno2));

            
        }
    }
}
