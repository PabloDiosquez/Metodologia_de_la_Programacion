using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    /// <summary>
    /// Representa un par clave - valor.
    /// </summary>
    public class ClaveValor : Comparable
    {
        // Atributos 

        private Comparable clave;

        private Comparable valor;

        // Constructor
        public ClaveValor(Comparable clave, Comparable valor)
        {
            this.clave = clave;

            this.valor = valor;
        }

        // Meétodo de instancia

        public Comparable getClave()
        {
            return clave;
        }
        public Comparable getValor()
        {
            return valor;
        }

        private void setValor(Comparable valor)
        {
            this.valor=valor;
        }

        public void setValor_DelParDeClave_(Comparable valor, Comparable clave)
        {
            if (getClave().sosIgual(clave))
            {
                setValor(valor);
            }
        }

        // Métodos de la interfaz
        public bool sosIgual(Comparable comparable)
        {
            return valor.sosIgual(comparable);
        }

        public bool sosMayor(Comparable comparable)
        {
            return valor.sosMayor(comparable);
        }

        public bool sosMenor(Comparable comparable)
        {
            return valor.sosMenor(comparable);  
        }
    }
}
