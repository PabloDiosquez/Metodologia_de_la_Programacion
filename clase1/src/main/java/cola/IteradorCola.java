package cola;

import comparable.Comparable;

/**
 * La interfaz {@code IteradorCola} proporciona un iterador para recorrer
 * una cola de elementos que implementan {@link Comparable}.
 */
public interface IteradorCola {

    /**
     * Indica si hay más elementos disponibles en la cola para iterar.
     */
    boolean hayAlgoMasParaVer();

    /**
     * Avanza al siguiente elemento en la cola.
     */
    void siguiente();

    /**
     * Devuelve el elemento actual en la iteración sin avanzar al siguiente.
     */
    Comparable verActual();
}
