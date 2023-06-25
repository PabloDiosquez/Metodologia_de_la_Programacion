using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_03
{
    public class Pila : Coleccionable
    {
        // Atributos
        List<Comparable> elementosApilados;

        // Constructor
        public Pila()
        {
            elementosApilados = new List<Comparable>();
        }

        // Métodos de instancia

        public void apilar(Comparable comparable)
        {
            elementosApilados.Add(comparable);
        }

        public Comparable desapilar()
        {
            Comparable desapilado = elementosApilados[elementosApilados.Count - 1];

            elementosApilados.Remove(desapilado);

            return desapilado;  
        }

        public bool estaVacia()
        {
            return elementosApilados.Count == 0;
        }

        public Comparable verTope()
        {
            return elementosApilados[elementosApilados.Count - 1];
        }


        // Métodos de interface Coleccionable
        public void agregar(Comparable comparable)
        {
            apilar(comparable); 
        }

        public bool contiene(Comparable comparable)
        {
            foreach (Comparable elemento in elementosApilados)
            {
                if (elemento.sosIgual(comparable))
                {
                    return true;
                }
            }

            return false;
        }

        public int cuantos()
        {
            return elementosApilados.Count;
        }

        public Comparable maximo()
        {
            Comparable maximoAlMomento = elementosApilados[elementosApilados.Count - 1];

            foreach (Comparable elemento in elementosApilados)
            {
                maximoAlMomento = maximoEntre(elemento, maximoAlMomento);
            }

            return maximoAlMomento;
        }

        public Comparable minimo()
        {
            Comparable minimoAlMomento = elementosApilados[elementosApilados.Count - 1];

            foreach (Comparable elemento in elementosApilados)
            {
                minimoAlMomento = minimoEntre(elemento, minimoAlMomento);
            }

            return minimoAlMomento;
        }


        // Funciones auxiliares 

        private Comparable maximoEntre(Comparable comparable1, Comparable comparable2)
        {
            if (comparable1.sosMayor(comparable2))
            {
                return comparable1;
            }

            return comparable2;
        }

        private Comparable minimoEntre(Comparable comparable1, Comparable comparable2)
        {
            if (comparable1.sosMenor(comparable2))
            {
                return comparable1;
            }

            return comparable2;
        }
    }
}
