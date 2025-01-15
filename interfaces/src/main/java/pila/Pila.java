package pila;

import coleccionable.Coleccionable;
import comparable.Comparable;

/**
 * Interfaz que define el comportamiento de una estructura de datos tipo Pila (LIFO: Last In, First Out).
 * Extiende la interfaz {@link Coleccionable}, heredando sus métodos para trabajar con elementos comparables.
 * Proporciona operaciones específicas para apilar, desapilar y examinar elementos en el tope de la pila.
 */
public interface Pila extends Coleccionable {

    /**
     * Elimina y devuelve el elemento ubicado en el tope de la pila.
     *
     * @return el elemento que estaba en el tope de la pila, o {@code null} si la pila está vacía.
     */
    Comparable desapilar();

    /**
     * Verifica si la pila está vacía.
     *
     * @return {@code true} si la pila no contiene elementos; {@code false} en caso contrario.
     */
    Boolean estaVacia();

    /**
     * Devuelve el elemento ubicado en el tope de la pila sin eliminarlo.
     *
     * @return el elemento en el tope de la pila, o {@code null} si la pila está vacía.
     */
    Comparable verTope();
}