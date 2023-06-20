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

        EstrategiaDeComparacion estrategia;

        // Constructor
        public Alumno(int dni, string nombre, int legajo, double promedio) : base(dni, nombre)
        {
            this.legajo = legajo;

            this.promedio = promedio;

            estrategia = new ComparacionPorLegajo();
        }

        // Métodos de instancia

        public int getLegajo()
        {
            return legajo;
        }

        public double getPromedio()
        {
            return promedio;
        }

        // Método para modificar la estrategia de comparación

        public void setEstrategia(EstrategiaDeComparacion estrategia) 
        {
            this.estrategia = estrategia;
        }

        public new bool sosIgual(Comparable alumno)
        {
            return estrategia.sosIgual(this, alumno);
        }

        public new bool sosMenor(Comparable alumno)
        {
            return estrategia.sosMenor(this, alumno);
        }

        public new bool sosMayor(Comparable alumno)
        {
            return estrategia.sosMayor(this, alumno);   
        }
    }
}
