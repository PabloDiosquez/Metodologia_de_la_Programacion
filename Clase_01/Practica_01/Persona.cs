using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_01
{
    // EJERCICIO 11 ☂ 

    /// <summary>
    /// Modela a una persona. Una persona tiene un nombre y un DNI.
    /// Invariantes de representación:
    /// ◽ El atributo nombre no debe ser vacío.
    /// ◽ El atributo dni debe ser >= 0.
    /// </summary>
    public class Persona: Comparable
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

        // Métodos de instancia 

        /// <summary>
        /// Describe el nombre de la persona que recibe el mensaje.
        /// </summary>
        /// <returns>string</returns>
        public string getNombre() 
        {
            return nombre;
        }

        /// <summary>
        /// Describe el DNI de la persona que recibe el mensaje.
        /// </summary>
        /// <returns>int</returns>
        public int getDni() 
        {
            return dni;
        }

        public bool sosIgual(Comparable comparable)
        {
            return getDni() == ((Persona)comparable).getDni();
        }

        public bool sosMenor(Comparable comparable)
        {
            return getDni() < ((Persona)comparable).getDni();
        }

        public bool sosMayor(Comparable comparable)
        {
            return getDni() > ((Persona)comparable).getDni();
        }
    }
}
