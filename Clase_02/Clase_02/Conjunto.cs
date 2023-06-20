using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    /// <summary>
    /// Modela un conjunto. Un conjunto es una colección que almacena elementos sin repetición.Es decir, si se intenta
    /// almacenar un elemento que ya está en el conjunto, éste elemento no se almacena ya que sino estaría repetido.
    /// </summary>
    public class Conjunto
    {
        // Atributos 

        List<Comparable> elementos;

        // Constructor 
        public Conjunto()
        {
            elementos = new List<Comparable>();
        }

        // Métodos de instancia 

        public List<Comparable> getElementos()
        {
            return elementos;
        }

        public void agregar(Comparable elemento)
        {
            if (!pertenece(elemento)) 
            {
                elementos.Add(elemento);
            }
        }

        public bool pertenece(Comparable comparable) 
        {
            foreach (Comparable elemento in getElementos())
            {
                if (elemento.sosIgual(comparable))
                {
                    return true;
                }
            }

            return false;
        }

    }
}
