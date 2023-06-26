using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    public class Persona : Comparable
    {
        // Atributos

        private string nombre;

        private int dni;

        // Constructor 

        public Persona(string nombre, int dni) 
        {
            this.nombre = nombre;

            this.dni = dni; 
        }

        // Getters

        public string getNombre() 
        {
            return nombre;  
        }

        public int getDni()
        {
            return dni;
        }

        // Métodos de interface
        public bool sosIgual(Comparable comparable)
        {
            return getDni() == ((Persona)comparable).getDni();
        }

        public bool sosMayor(Comparable comparable)
        {
            return getDni() < ((Persona)comparable).getDni();
        }

        public bool sosMenor(Comparable comparable)
        {
            return getDni() > ((Persona)comparable).getDni();
        }
    }
}
