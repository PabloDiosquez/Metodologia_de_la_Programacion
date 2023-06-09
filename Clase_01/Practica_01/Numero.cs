using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_01
{
    //EJERCICIO 2 🎉

    /// <summary>
    /// Representa un número. Un número tiene un valor.
    /// </summary>
    public class Numero : Comparable
    {
        // Atributos 
        private int valor;

        //Constructor 
        public Numero(int valor)
        {
            this.valor = valor;
        }

        /// <summary>
        /// Describe el valor del número que recibe el mensaje.
        /// </summary>
        /// <returns>int</returns>
        public int getValor()
        {
            return valor;
        }

        public override string ToString()
        {
            return $"{getValor()}"; // return getValor().ToString();
        }

        // Implementación de los métodos de la interfaz comparable.

        public bool sosIgual(Comparable valor)
        {
            return this.valor == ((Numero)valor).getValor();
        }

        public bool sosMenor(Comparable valor) 
        {
            return this.valor < ((Numero)valor).getValor();
        }

        public bool sosMayor(Comparable valor)
        {
            return this.valor > ((Numero)valor).getValor();
        }
    }
}
