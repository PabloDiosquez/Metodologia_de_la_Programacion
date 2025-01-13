package cola;

import comparable.Comparable;

/**
 * La interfaz {@code Cola} representa una estructura de datos de tipo cola (FIFO:
 * First In, First Out), en la cual los elementos se encolan al final y se desencolan
 * desde el principio.
 *
 * <p>Esta interfaz define las operaciones básicas para manejar una cola, como
 * agregar elementos, eliminar elementos y consultar el elemento al frente de la cola.</p>
 */
public interface Cola {

    /**
     * Agrega un elemento al final de la cola.
     *
     * @param elemento el elemento a agregar. Debe implementar {@link Comparable}.
     * @throws NullPointerException si el elemento es {@code null}.
     */
    void encolar(Comparable elemento);

    /**
     * Elimina y devuelve el elemento al frente de la cola.
     *
     * @return el elemento al frente de la cola.
     * @throws IllegalStateException si la cola está vacía.
     */
    Comparable desencolar();

    /**
     * Devuelve el elemento al frente de la cola sin eliminarlo.
     *
     * @return el elemento al frente de la cola.
     * @throws IllegalStateException si la cola está vacía.
     */
    Comparable verPrimero();

    /**
     * Verifica si la cola está vacía.
     *
     * @return {@code true} si la cola no contiene elementos; {@code false} en caso contrario.
     */
    boolean estaVacia();
}
