using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    public class Alumno : Persona 
    {
        // Atributos

        private int dni;

        private string nombre;

        private int legajo;

        private double promedio;

        // Constructor 
        public Alumno(int dni, string nombre, int legajo, double promedio) : base(dni, nombre)
        {
            this.legajo = legajo;

            this.promedio = promedio;
        }

        // Métodos de instancia
        public int getLegajo() 
        {
            return legajo;
        }

        public new bool sosIgual(Comparable comparable) 
        {
            return getLegajo() == ((Alumno)comparable).getLegajo();
        }
    }
}
