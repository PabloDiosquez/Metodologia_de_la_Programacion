package coleccionable;

import comparable.Comparable;

/**
 * Interfaz que define las operaciones básicas para una colección de elementos comparables.
 */
public interface Coleccionable {

    /**
     * Devuelve la cantidad de elementos comparables en la colección.
     *
     * @return el número de elementos comparables en la colección
     */
    int cuantos();

    /**
     * Devuelve el elemento de menor valor en la colección.
     *
     * @return el elemento de menor valor
     */
    Comparable minimo();

    /**
     * Devuelve el elemento de mayor valor en la colección.
     *
     * @return el elemento de mayor valor
     */
    Comparable maximo();

    /**
     * Agrega el objeto comparable recibido como parámetro a la colección.
     *
     * @param comparable el objeto comparable que se va a agregar a la colección
     */
    void agregar(Comparable comparable);

    /**
     * Determina si el objeto comparable recibido como parámetro está incluido en la colección.
     *
     * @param comparable el objeto comparable que se verifica
     * @return {@code true} si el objeto está en la colección, {@code false} en caso contrario
     */
    boolean pertenece(Comparable comparable);
}
