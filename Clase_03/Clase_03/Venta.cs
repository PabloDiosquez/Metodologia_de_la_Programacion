using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    public class Venta
    {
        private double monto;

        private Vendedor vendedor;

        public Venta(Vendedor vendedor, double monto)
        {
            this.vendedor = vendedor;

            this.monto = monto;
        }

        // Getters y Setters

        public double getMonto() 
        {
            return monto;
        }

        public Vendedor getVendedor() 
        {
            return vendedor;
        }

        public void setMonto(double monto)
        {
            this.monto=monto;
        }

        public void setVendedor(Vendedor vendedor) 
        {
            this.vendedor=vendedor;
        }
    }
}
