using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    public class Vendedor : Persona, IObservado
    {
        // Atributos
        private double sueldoBasico;

        private double bonus;

        private List<IObservador> observadores;

        // Constructor
        public Vendedor(string nombre, int dni, double sueldoBasico) : base(nombre, dni)
        {
            this.sueldoBasico = sueldoBasico;

            bonus = 1;

            observadores = new List<IObservador>();
        }

        // Getters

        private double getBonus()
        {
            return bonus;
        }

        // Métodos de instancia

        /// <summary>
        /// 
        /// </summary>
        /// <param name="montoDeLaVenta"></param>
        public void venta(double monto)
        {   
            notificar(monto);

            Console.WriteLine($"Monto de la venta: {monto}");
        }

        /// <summary>
        /// 
        /// </summary>
        public void aumentaBonus()
        {
            bonus += 0.1;
        }

        public override string ToString()
        {
            return $"Nombre: {this.getNombre()} -- Bonus acumulado: {getBonus()}"; 
        }

        // Métodos de la interface IObservado
        public void agregar(IObservador observador)
        {
            observadores.Add(observador);
        }

        public void quitar(IObservador observador)
        {
            observadores.Remove(observador);    
        }

        public void notificar(double monto)
        {
            foreach (IObservador observador in observadores)
            {
                observador.actualizar(monto, this);
            }
        }
    }
}
