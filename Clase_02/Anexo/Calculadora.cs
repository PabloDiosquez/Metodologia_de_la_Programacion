using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anexo
{
    public class Calculadora
    {
        IOperacion operacion;

        public Calculadora()
        {
            operacion = null;
        }

        public void calcular() 
        {
            double numero1, numero2;

            while (true)
            {
                Console.WriteLine(menu());

                int opcion = validarOpcion();

                if (opcion == 0) break;

                if (!(opcion >= 0 && opcion <= 4)) continue;

                numero1 = validarNumero();

                numero2 = validarNumero();

                operacion = asignarOperacion(opcion);

                Console.WriteLine($"Resultado: {operacion.operacion(numero1, numero2)}");
            }
        }

        private string menu() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("*********** Opciones ***********");
            sb.AppendLine("********************************");
            sb.AppendLine("0: Salir -- 1: Suma -- 2: Resta -- 3: Multiplicación -- 4: División");
            sb.AppendLine("*********************************");
            
            return sb.ToString();
        }

        private int validarOpcion()
        {
            int opcion;

            while (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("La opción elegida no es válida. Intente de nuevo.");
            }

            return opcion;  
        }

        private double validarNumero()
        {
            double numero;

            Console.WriteLine("Número:");

            while (!double.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Asegúrese de ingresar un número. Intente de nuevo.");
            } 

            return numero; 
        }

        private IOperacion asignarOperacion(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    operacion = new Suma();
                    break;
                case 2:
                    operacion = new Resta();
                    break;
                case 3:
                    operacion = new Producto();
                    break;
                case 4:
                    operacion = new Division();
                    break;
                default:
                    Console.WriteLine("Opción elegida no es válida. Intente de nuevo.\n");
                    break;
            }

            return operacion;
        }
    }
}
