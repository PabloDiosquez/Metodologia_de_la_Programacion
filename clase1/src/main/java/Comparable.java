/**
 * Interfaz que define un contrato para comparar objetos.
 */
public interface Comparable {

    /**
     * Determina si el objeto actual es igual al objeto especificado.
     *
     * @param otro el objeto con el que se compara el objeto actual
     * @return {@code true} si el objeto actual es igual a {@code otro}, {@code false} en caso contrario
     */
    boolean sosIgual(Comparable otro);

    /**
     * Determina si el objeto actual es menor que el objeto especificado.
     *
     * @param otro el objeto con el que se compara el objeto actual
     * @return {@code true} si el objeto actual es menor que {@code otro}, {@code false} en caso contrario
     */
    boolean sosMenor(Comparable otro);

    /**
     * Determina si el objeto actual es mayor que el objeto especificado.
     *
     * @param otro el objeto con el que se compara el objeto actual
     * @return {@code true} si el objeto actual es mayor que {@code otro}, {@code false} en caso contrario
     */
    boolean sosMayor(Comparable otro);
}
