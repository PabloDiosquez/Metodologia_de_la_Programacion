using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    public abstract class FabricaDeComparables : IFabricaDeComparables
    {
        // Método de clase 
        public static Comparable crearProductoAleatorio(int idProducto)
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

            return fabricaDeComparables.crearAleatorio();
        }

        public static Comparable crearProductoPorTeclado(int idProducto)
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
                case 3:
                    fabricaDeComparables = new FabricaDeVendedores();
                    break;
            }

            return fabricaDeComparables.crearPorTeclado();
        }

        public abstract Comparable crearAleatorio();

        public abstract Comparable crearPorTeclado();
    }
}
