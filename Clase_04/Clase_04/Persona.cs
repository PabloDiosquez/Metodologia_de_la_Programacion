using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_04
{
    public class Persona : Comparable
    {
        // Atributos 

        private int dni;

        private string nombre;

        private string apellido;

        EstrategiaDeComparacion estrategia;

        // Constructor

        public Persona(int dni, string nombre, string apellido)
        {
            this.dni = dni;

            this.nombre = nombre;

            this.apellido = apellido;   

            estrategia = new ComparacionPorDni();
        }

        // Getters y Setters

        public int getDni()
        {
            return dni;
        }

        public void setDni(int dni)
        {
            this.dni = dni;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        // Moficación de la estrategia de comparación

        public void setEstrategia(EstrategiaDeComparacion estrategia) 
        {
            this.estrategia = estrategia;
        }

        // Métodos de la interface Comparable
        public bool sosIgual(Comparable comparable)
        {
            return estrategia.sosIgual(this, comparable);
        }

        public bool sosMayor(Comparable comparable)
        {
            return estrategia.sosMayor(this, comparable);   
        }

        public bool sosMenor(Comparable comparable)
        {
            return estrategia.sosMenor(this, comparable);   
        }

        // ToString()

        public override string ToString()
        {
            return $"{nombre} {apellido}";
        }
    }
}
