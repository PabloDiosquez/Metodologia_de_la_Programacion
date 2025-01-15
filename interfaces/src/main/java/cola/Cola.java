package cola;

import coleccionable.Coleccionable;
import comparable.Comparable;

/**
 * La interfaz {@code Cola} define el comportamiento básico de una cola,
 * una estructura de datos que opera bajo el principio FIFO (First In, First Out).
 * Extiende la interfaz {@link Coleccionable} para incorporar funcionalidades
 * relacionadas con la colección de elementos comparables.
 *
 */
public interface Cola extends Coleccionable {

    /**
     * Verifica si la cola está vacía.
     *
     * @return {@code true} si la cola no contiene elementos;
     *         {@code false} en caso contrario.
     */
    boolean estaVacia();

    /**
     * Elimina y retorna el elemento que está al frente de la cola.
     *
     * @return El elemento {@link Comparable} al frente de la cola,
     *         o {@code null} si la cola está vacía.
     */
    Comparable quitar();

    /**
     * Retorna el elemento que está al frente de la cola sin eliminarlo.
     *
     * @return El elemento {@link Comparable} al frente de la cola,
     *         o {@code null} si la cola está vacía.
     */
    Comparable verPrimero();
}
