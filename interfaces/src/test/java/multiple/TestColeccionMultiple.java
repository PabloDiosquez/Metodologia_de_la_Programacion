package multiple;

import cola.ColaImpl;
import comparable.Comparable;
import numero.Numero;
import pila.PilaImpl;

public class TestColeccionMultiple {
    public static void main(String[] args) {
        PilaImpl pila = new PilaImpl();
        ColaImpl cola = new ColaImpl();

        pila.agregar(new Numero(10));
        pila.agregar(new Numero(20));
        pila.agregar(new Numero(30));

        cola.agregar(new Numero(15));
        cola.agregar(new Numero(25));
        cola.agregar(new Numero(35));

        ColeccionMultiple coleccionMultiple = new ColeccionMultiple(pila, cola);

        assert coleccionMultiple.cuantos() == 6 : "Error en cuantos(): esperado 6";

        Comparable esperadoMinimo = new Numero(10);
        assert coleccionMultiple.minimo().equals(esperadoMinimo) :
                "Error en minimo(): esperado " + esperadoMinimo;

        Comparable esperadoMaximo = new Numero(35);
        assert coleccionMultiple.maximo().equals(esperadoMaximo) :
                "Error en maximo(): esperado " + esperadoMaximo;

        Comparable buscado = new Numero(20);
        assert coleccionMultiple.contiene(buscado) :
                "Error en contiene(): se esperaba encontrar " + buscado;

        Comparable noExistente = new Numero(50);
        assert !coleccionMultiple.contiene(noExistente) :
                "Error en contiene(): no se esperaba encontrar " + noExistente;

        coleccionMultiple.agregar(new Numero(50));
        assert coleccionMultiple.cuantos() == 6 :
                "Error en agregar(): la cantidad de elementos no debería cambiar";
    }
}