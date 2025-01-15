package coleccionable;

import comparable.Comparable;

/**
 * Interfaz que define una colección de elementos comparables.
 * Proporciona métodos para realizar operaciones básicas sobre la colección,
 * como agregar elementos, determinar la cantidad de elementos, y obtener
 * el mínimo y el máximo según el criterio de comparación.
 */
public interface Coleccionable {

    /**
     * Devuelve la cantidad de elementos en la colección.
     *
     * @return el número de elementos presentes en la colección.
     */
    int cuantos();

    /**
     * Devuelve el elemento mínimo de la colección según el criterio de comparación.
     *
     * @return el elemento de valor mínimo en la colección, o {@code null} si la colección está vacía.
     */
    Comparable minimo();

    /**
     * Devuelve el elemento máximo de la colección según el criterio de comparación.
     *
     * @return el elemento de valor máximo en la colección, o {@code null} si la colección está vacía.
     */
    Comparable maximo();

    /**
     * Agrega un elemento a la colección.
     *
     * @param comparable el elemento que se desea agregar.
     */
    void agregar(Comparable comparable);

    /**
     * Verifica si un elemento específico está presente en la colección.
     *
     * @param comparable el elemento a buscar en la colección.
     * @return {@code true} si el elemento está presente en la colección; {@code false} en caso contrario.
     */
    Boolean contiene(Comparable comparable);
}