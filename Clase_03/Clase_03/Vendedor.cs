using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    public class Vendedor : Persona
    {
        // Atributos
        private double sueldoBasico;

        private double bonus;

        // Constructor
        public Vendedor(string nombre, int dni, double sueldoBasico) : base(nombre, dni)
        {
            this.sueldoBasico = sueldoBasico;

            bonus = 1;
        }

        // Métodos de instancia

        /// <summary>
        /// 
        /// </summary>
        /// <param name="montoDeLaVenta"></param>
        public void venta(double montoDeLaVenta)
        {
            Console.WriteLine($"Monto de la venta: {montoDeLaVenta}");
        }

        /// <summary>
        /// 
        /// </summary>
        public void aumentaBonus()
        {
            bonus += 0.1;
        }
    }
}
