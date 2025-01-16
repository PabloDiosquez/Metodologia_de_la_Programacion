package cola;

import comparable.Comparable;
import numero.Numero;

public class ColaTest {
    public static void main(String[] args) {
        Cola cola = new ColaImpl();

        // Prueba: Cola vacía
        assert cola.estaVacia() : "La cola debería estar vacía al inicio";
        assert cola.cuantos() == 0 : "Cantidad debería ser 0";

        // Prueba: Agregar elementos
        cola.agregar(new Numero(10));
        cola.agregar(new Numero(20));
        cola.agregar(new Numero(5));

        assert !cola.estaVacia() : "La cola no debería estar vacía";
        assert cola.cuantos() == 3 : "Cantidad debería ser 3";
        assert cola.verPrimero().sosIgual(new Numero(10)) : "El primer elemento debería ser 10";

        // Prueba: Quitar elemento
        Comparable primero = cola.quitar();
        assert primero.sosIgual(new Numero(10)) : "El elemento quitado debería ser 10";
        assert cola.cuantos() == 2 : "Cantidad debería ser 2";
        assert cola.verPrimero().sosIgual(new Numero(20)) : "El primer elemento ahora debería ser 20";

        // Prueba: Mínimo y máximo
        assert cola.minimo().sosIgual(new Numero(5)) : "El mínimo debería ser 5";
        assert cola.maximo().sosIgual(new Numero(20)) : "El máximo debería ser 20";

        // Prueba: Contiene
        assert cola.contiene(new Numero(20)) : "La cola debería contener 20";
        assert !cola.contiene(new Numero(30)) : "La cola no debería contener 30";

        // Prueba: Vaciar la cola
        cola.quitar();
        cola.quitar();
        assert cola.estaVacia() : "La cola debería estar vacía después de quitar todos los elementos";

        System.out.println("Todas las pruebas pasaron correctamente.");
    }
}
