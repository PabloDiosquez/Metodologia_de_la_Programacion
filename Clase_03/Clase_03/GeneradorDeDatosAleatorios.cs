using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    public class GeneradorDeDatosAleatorios
    {
        /// <summary>
        /// Describe un número aleatorio entre 0 y la cota dada por parámetro.
        /// </summary>
        /// <param name="cotaSuperior">Número</param>
        /// <returns>Número</returns>
        public int numeroAleatorio(int cotaSuperior)
        {
            return new Random().Next(cotaSuperior);
        }

        /// <summary>
        /// Describe un string aleatorio de **cantidadDeCaracteres** caracteres.
        /// </summary>
        /// <param name="cantidadDeCaracteres">Número</param>
        /// <returns>String</returns>
        public string stringAleatorio(int cantidadDeCaracteres)
        {
            string aleatorio = string.Empty;

            for (int i = 0; i < cantidadDeCaracteres; i++)
            {
                aleatorio += caracterAleatorio();
            }
           
            return aleatorio;
        }

        private char caracterAleatorio() 
        {
            string bancoDeCaracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            return bancoDeCaracteres[new GeneradorDeDatosAleatorios().numeroAleatorio(bancoDeCaracteres.Length)];
        }
    }
}
