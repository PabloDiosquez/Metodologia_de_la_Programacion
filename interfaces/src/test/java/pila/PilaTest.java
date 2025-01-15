package pila;

import comparable.Comparable;
import nodo.Nodo;
import numero.Numero;

public class PilaTest {
    public static void main(String[] args) {
        // Crear una nueva pila
        PilaImpl pila = new PilaImpl();
        System.out.println("Pruebas para PilaImpl:");

        // Prueba inicial: la pila debe estar vacía
        assert pila.estaVacia() : "Error: La pila debería estar vacía al inicio.";
        assert pila.cuantos() == 0 : "Error: La cantidad inicial debería ser 0.";

        // Agregar elementos
        pila.agregar(new Numero(5));
        pila.agregar(new Numero(10));
        pila.agregar(new Numero(3));
        System.out.println("Prueba: agregar elementos pasada.");

        // Verificar la cantidad después de agregar
        assert pila.cuantos() == 3 : "Error: La cantidad debería ser 3.";
        System.out.println("Prueba: verificar cantidad después de agregar pasada.");

        // Verificar verTope
        assert pila.verTope().sosIgual(new Numero(3)) : "Error: El tope debería ser 3.";
        System.out.println("Prueba: verificar el tope pasada.");

        // Prueba de mínimo y máximo
        assert pila.minimo().sosIgual(new Numero(3)) : "Error: El mínimo debería ser 3.";
        assert pila.maximo().sosIgual(new Numero(10)) : "Error: El máximo debería ser 10.";
        System.out.println("Prueba: verificar mínimo y máximo pasada.");

        // Verificar contiene
        assert pila.contiene(new Numero(10)) : "Error: La pila debería contener 10.";
        assert !pila.contiene(new Numero(7)) : "Error: La pila no debería contener 7.";
        System.out.println("Prueba: verificar contiene pasada.");

        // Desapilar elementos
        assert pila.desapilar().sosIgual(new Numero(3)) : "Error: El elemento desapilado debería ser 3.";
        assert pila.cuantos() == 2 : "Error: La cantidad debería ser 2 después de desapilar.";
        assert pila.desapilar().sosIgual(new Numero(10)) : "Error: El elemento desapilado debería ser 10.";
        assert pila.desapilar().sosIgual(new Numero(5)) : "Error: El elemento desapilado debería ser 5.";
        assert pila.estaVacia() : "Error: La pila debería estar vacía después de desapilar todo.";
        System.out.println("Prueba: desapilar elementos pasada.");

        // Prueba de desapilar en una pila vacía
        assert pila.desapilar() == null : "Error: Desapilar una pila vacía debería devolver null.";
        System.out.println("Prueba: desapilar en una pila vacía pasada.");

        // Prueba de mínimo y máximo en una pila vacía
        assert pila.minimo() == null : "Error: El mínimo de una pila vacía debería ser null.";
        assert pila.maximo() == null : "Error: El máximo de una pila vacía debería ser null.";
        System.out.println("Prueba: mínimo y máximo en una pila vacía pasada.");

        // Prueba de verTope en una pila vacía
        assert pila.verTope() == null : "Error: verTope en una pila vacía debería devolver null.";
        System.out.println("Prueba: verTope en una pila vacía pasada.");

        System.out.println("¡Todas las pruebas pasaron correctamente!");
    }
}
