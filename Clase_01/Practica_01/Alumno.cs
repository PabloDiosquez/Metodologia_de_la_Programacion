using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_01
{
    public class Alumno: Persona
    {
        // Atributos

        private int legajo;

        private double promedio;

        // Constructor
        public Alumno(string nombre, int dni, int legajo, double promedio) : base(nombre, dni)
        {
            this.legajo = legajo;

            this.promedio = promedio;
        }

        // Métodos de instancia 🥐

        /// <summary>
        /// Describe el legajo del alumno que recibe el mensaje.
        /// </summary>
        /// <returns>int</returns>
        public int getLegajo()
        {
            return legajo;
        }

        /// <summary>
        /// Describe el promedio del alumno que recibe el mensaje.
        /// </summary>
        /// <returns>double</returns>
        public double getPromedio()
        {
            return promedio;
        }
    }
}
