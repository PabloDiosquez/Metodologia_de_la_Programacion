using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    /// <summary>
    /// 
    /// </summary>
    public class Cola
    {
        // Atributos

        List<Comparable> elementosEncolados;

        // Constructor
        public Cola()
        {
            elementosEncolados = new List<Comparable>();    
        }

        // Métodos de instancia 
        public void encolar(Comparable comparable) 
        {
            elementosEncolados.Add(comparable);
        }

        public Comparable desencolar()
        {
            Comparable desencolado = elementosEncolados[0];
            
            elementosEncolados.Remove(desencolado); 

            return desencolado;
        }

        public bool estaVacia()
        {
            return elementosEncolados.Count == 0;
        }

        public Comparable verTope() 
        {
            return elementosEncolados[0];
        }
    }
}
