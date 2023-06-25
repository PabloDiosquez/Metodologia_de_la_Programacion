using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    public class LectorDeDatos
    {
        /// <summary>
        /// Describe el número entero leído por teclado.
        /// </summary>
        /// <returns>Número entero</returns>
        public int numeroPorTeclado()
        {
            return int.Parse(Console.ReadLine());
        }

        /// <summary>
        /// Describe el string leído por teclado.
        /// </summary>
        /// <returns>String</returns>
        public string stringPorTeclado()
        {
            return Console.ReadLine();    
        }
    }
}
