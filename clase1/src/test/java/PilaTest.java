import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;

public class PilaTest {

    @Test
    public void testEstaVacia() {
        Pila pila = new Pila();
        assertTrue(pila.estaVacia(), "La pila debería estar vacía.");

        pila.agregar(new Numero(5));
        assertFalse(pila.estaVacia(), "La pila no debería estar vacía después de agregar un elemento.");
    }

    @Test
    public void testVerTope() {
        Pila pila = new Pila();
        pila.agregar(new Numero(10));
        pila.agregar(new Numero(20));

        assertEquals(20, ((Numero)pila.verTope()).getValor(), "El tope de la pila debería ser 20.");
    }

    @Test
    public void testDesapilar() {
        Pila pila = new Pila();
        pila.agregar(new Numero(5));
        pila.agregar(new Numero(10));

        assertEquals(10, ((Numero)pila.desapilar()).getValor(), "El valor desapilado debería ser 10.");
        assertEquals(5, ((Numero)pila.desapilar()).getValor(), "Después de desapilar, el tope debería ser 5.");
    }

    @Test
    public void testMinimo() {
        Pila pila = new Pila();
        pila.agregar(new Numero(7));
        pila.agregar(new Numero(3));
        pila.agregar(new Numero(10));

        assertEquals(3, ((Numero)pila.minimo()).getValor(), "El mínimo de la pila debería ser 3.");
    }

    @Test
    public void testPertenece() {
        Pila pila = new Pila();
        pila.agregar(new Numero(5));
        pila.agregar(new Numero(10));
        pila.agregar(new Numero(15));

        assertTrue(pila.pertenece(new Numero(10)), "La pila debería contener el valor 10.");
        assertFalse(pila.pertenece(new Numero(20)), "La pila no debería contener el valor 20.");
    }
}
