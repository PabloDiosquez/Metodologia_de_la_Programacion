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

        // Ejercicio 2

        private static void llenarAlumnos(Coleccionable alumnos) 
        {
            Random rd = new Random();

            for (int i = 0; i < 20; i++)
            {
                alumnos.agregar(new Alumno(rd.Next(100,1000), "****", rd.Next(100), rd.NextDouble()*10));
            }
        }
    }
}
