using System;

namespace Clase_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Pequeñas pruebas... 🖖🏼

            Alumno alumno1 = new Alumno(123456, "Alberto", 12, 7.2);

            Alumno alumno2 = new Alumno(123456, "Matías", 11, 8.9);

            ComparacionPorLegajo comparacionPorLegajo = new ComparacionPorLegajo();

            comparacionPorLegajo.sosIgual(alumno1, alumno2);
        }
    }
}
