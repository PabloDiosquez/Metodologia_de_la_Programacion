using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    public class Gerente : Persona, IObservador
    {
        private Coleccionable mejoresVendedores; //Es un Coleccionable con los mejores vendedores

        // Constructor
        public Gerente(string nombre, int dni) : base(nombre, dni)
        {
            
        }

        /// <summary>
        /// Se ejecuta al final del día. Debe informar por consola el nombre y apellido de los "mejores" vendedores de
        /// la jornada, junto con su bonus acumulado.
        /// </summary>
        public void cerrar() { }

        /// <summary>
        /// Recibe el "monto" facturado por una venta y el "vendedor" que la realizó.Si el "monto" es superior a 5000
        /// entonces se hacen dos cosas: 
        /// a) se agrega el „vendedor‟ a la colección "mejores" si es que no estaba en la colección; 
        /// b) se invoca al método aumentaBonus del vendedor.
        /// </summary>
        /// <param name="monto">Monto de la venta realizada</param>
        /// <param name="vendedor">Vendedor</param>
        public void venta(double montoVenta, IObservado vendedor)
        {
            double montoASuperar = 5000;

            if (montoVenta > montoASuperar)
            {
                mejoresVendedores.agregar((Vendedor)vendedor);

                ((Vendedor)vendedor).aumentaBonus();
            }
        }

        // Método de la interface IObservador

        public void actualizar(double monto, IObservado observado)
        {
            venta(monto, observado);
        }
    }
}
