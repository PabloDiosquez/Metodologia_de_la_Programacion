package cola;

/**
 * La interfaz {@code Cola} representa una estructura de datos de tipo cola (FIFO:
 * First In, First Out), en la cual los elementos se encolan al final y se desencolan
 * desde el principio.
 *
 * @param <T> el tipo de elementos que serán almacenados en la cola. Los elementos
 *            deben implementar la interfaz {@link Comparable}.
 */
public interface Cola<T extends Comparable<T>> {

    /**
     * Agrega un elemento al final de la cola.
     *
     * @param elemento el elemento a agregar. Debe implementar {@link Comparable}.
     * @throws NullPointerException si el elemento es {@code null}.
     */
    void encolar(T elemento);

    /**
     * Elimina y devuelve el elemento al frente de la cola.
     *
     * @return el elemento al frente de la cola.
     * @throws IllegalStateException si la cola está vacía.
     */
    T desencolar();

    /**
     * Devuelve el elemento al frente de la cola sin eliminarlo.
     *
     * @return el elemento al frente de la cola.
     * @throws IllegalStateException si la cola está vacía.
     */
    T verPrimero();

    /**
     * Verifica si la cola está vacía.
     *
     * @return {@code true} si la cola no contiene elementos; {@code false} en caso contrario.
     */
    boolean estaVacia();
}