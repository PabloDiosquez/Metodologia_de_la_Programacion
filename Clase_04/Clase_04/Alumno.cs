using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_04
{
    public class Alumno : Persona
    {
        // Atributos

        private int legajo;

        private double promedio;

        private double calificacion;

        // Constructor

        public Alumno(int dni, string nombre, string apellido, int legajo) : base(dni, nombre, apellido) 
        {
            this.legajo = legajo;
        }

        // Métodos de instancia

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pregunta"></param>
        /// <returns></returns>
        public int responderPregunta(int pregunta)
        {
            return new Random().Next(1, 4);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string mostrarCalificacion()
        {
            return $"{base.ToString()} - Calificación: {calificacion}";
        }

        // Getters y Setters 

        public int getLegajo()
        {
            return legajo;
        }

        public void setLegajo(int legajo)
        {
            this.legajo = legajo;
        }

        public double getPromedio()
        {
            return promedio;
        }

        public void setPromedio(double promedio)
        {
            this.promedio = promedio;
        }

        public double getCalificacion()
        {
            return calificacion;
        }

        public void setCalificacion(double calificacion)
        {
            this.calificacion = calificacion;
        }
    }
}
