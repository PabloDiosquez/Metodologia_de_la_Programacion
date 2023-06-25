using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    public class Numero : Comparable
    {
        // Atributos

        private int valor;

        // Constructor

        public Numero(int valor) 
        {
            this.valor = valor;
        }

        // Getter

        public int getValor()
        {
            return valor;
        }

        // Métodos de la interface
        public bool sosIgual(Comparable comparable)
        {
            return getValor() == ((Numero)comparable).getValor();
        }

        public bool sosMayor(Comparable comparable)
        {
            return (getValor() > ((Numero)comparable).getValor());
        }

        public bool sosMenor(Comparable comparable)
        {
            return ((getValor() < ((Numero)comparable).getValor()));
        }

        public override string ToString()
        {
            return getValor().ToString();
        }
    }
}
