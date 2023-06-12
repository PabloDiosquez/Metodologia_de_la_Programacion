using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    // Clase documentada en la clase anterior.
    public class Persona : Comparable
    {
        // Atributos
        private int dni;

        private string nombre;

        // Constructor
        public Persona(int dni, string nombre)
        {
            this.dni = dni;

            this.nombre = nombre;
        }

        // Métodos de instancia
        public int getDni()
        {
            return dni;
        }

        public string getNombre()
        {
            return nombre;
        }

        // Métodos de la interfaz
        public bool sosIgual(Comparable comparable)
        {
            return getDni() == ((Persona)comparable).getDni();
        }

        public bool sosMayor(Comparable comparable)
        {
            return getDni() > ((Persona)comparable).getDni();
        }

        public bool sosMenor(Comparable comparable)
        {
            return getDni() < ((Persona)comparable).getDni();
        }
    }
}
