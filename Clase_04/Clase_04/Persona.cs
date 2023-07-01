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

        // Constructor

        public Persona(int dni, string nombre)
        {
            this.dni = dni;

            this.nombre = nombre;
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

        // Métodos de la interface Comparable
        public bool sosIgual(Comparable comparable)
        {
            throw new NotImplementedException();
        }

        public bool sosMayor(Comparable comparable)
        {
            throw new NotImplementedException();
        }

        public bool sosMenor(Comparable comparable)
        {
            throw new NotImplementedException();
        }
    }
}
