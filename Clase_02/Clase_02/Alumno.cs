using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    // 3) Modificar el contexto.
    public class Alumno : Persona 
    {
        // Atributos

        private int dni;

        private string nombre;

        private int legajo;

        private double promedio;

        // Crear la composición. 
        private EstrategiaDeComparacion estrategiaDeComparacion;

        // Constructor 
        public Alumno(int dni, string nombre, int legajo, double promedio) : base(dni, nombre)
        {
            this.legajo = legajo;

            this.promedio = promedio;

            estrategiaDeComparacion = new ComparacionPorLegajo(); // Estrategia de comparación por defecto.
        }

        // Métodos de instancia
        public int getLegajo() 
        {
            return legajo;
        }

        // Mecanismo para cambiar de estrategia 🥨

        public void setEstrategiaDeComparacion(EstrategiaDeComparacion estrategia)
        {
            estrategiaDeComparacion = estrategia;
        }

        // Delegar la resposibilidad de las comparaciones a las estrategias 👽

        public new bool sosIgual(Comparable comparable)
        {
            return estrategiaDeComparacion.sosIgual(this, comparable);
        }

        public new bool sosMenor(Comparable comparable)
        {
            return estrategiaDeComparacion.sosMenor(this, comparable);
        }

        public new bool sosMayor(Comparable comparable)
        {
            return estrategiaDeComparacion.sosMayor(this, comparable);
        }

    }
}
