using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_01
{
    public class Numero : Comparable
    {
        private int valor;

        public Numero(int valor)
        {
            this.valor = valor;
        }

        public int getValor()
        {
            return valor;
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
