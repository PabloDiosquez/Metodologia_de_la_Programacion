using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    public abstract class FabricaDeComparables
    {
        // Método de clase 
        public static Comparable crearProducto(int idProducto)
        {
            FabricaDeComparables fabricaDeComparables = null;

            switch (idProducto)
            {
                case 1:
                    fabricaDeComparables = new FabricaDeNumeros();
                    break;
                case 2:
                    fabricaDeComparables = new FabricaDePersonas();
                    break;
            }

            return fabricaDeComparables.crearProducto();
        }

        // Método de instancia
        public abstract Comparable crearProducto();
    }
}
