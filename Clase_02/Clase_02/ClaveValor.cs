using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    public class ClaveValor : Comparable
    {
        // Atributos
        private Comparable clave;

        private Comparable valor;

        private EstrategiaDeComparacion estrategia;

        // Constructor

        public ClaveValor(Comparable clave, Comparable valor)
        {
            this.clave = clave;

            this.valor = valor;

            estrategia = new ComparacionPorClave();
        }

        // Métodos de instancia
        public Comparable getClave() 
        {
            return clave;
        }
        public Comparable getValor()
        {
            return valor;
        }

        public void setValor(Comparable valor)
        {
            this.valor=valor;
        }

        // Método para modificar la estrategia de comparación

        public void setEstrategia(EstrategiaDeComparacion estrategia)
        {
            this.estrategia=estrategia; 
        }

        public bool sosIgual(Comparable claveValor)
        {
            return estrategia.sosIgual(this, claveValor);
        }

        public bool sosMayor(Comparable claveValor)
        {
            return estrategia.sosMayor(this, claveValor);
        }

        public bool sosMenor(Comparable claveValor)
        {
            return estrategia.sosMenor(this, claveValor);
        }
    }
}
