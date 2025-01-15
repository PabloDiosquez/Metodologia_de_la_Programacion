package iterador;

import comparable.Comparable;

/**
 * Interfaz que define el comportamiento de un iterador para recorrer elementos de una colección.
 */
public interface Iterador {

    /**
     * Verifica si existen más elementos por recorrer en la colección.
     *
     * @return {@code true} si hay más elementos disponibles para iterar;
     *         {@code false} en caso contrario.
     */
    Boolean hayAlgoMasParaVer();

    /**
     * Devuelve el elemento actual en la iteración sin avanzar al siguiente.
     *
     * @return el elemento actual de la iteración, o {@code null} si no hay más elementos.
     */
    Comparable verActual();

    /**
     * Avanza al siguiente elemento en la iteración.
     * Pre: Debe haber un siguiente.
     */
    void siguiente();
}
