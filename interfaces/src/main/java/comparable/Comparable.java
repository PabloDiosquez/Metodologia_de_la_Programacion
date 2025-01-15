package comparable;

/**
 * Interfaz que define un contrato para comparar objetos.
 */
public interface Comparable {

    /**
     * Determina si el objeto que recibe el mensaje es igual al objeto
     * especificado.
     *
     * @param comparable el objeto a comparar.
     * @return {@code true} si ambos objetos son iguales; {@code false} en caso contrario.
     */
    Boolean sosIgual(Comparable comparable);

    /**
     * Determina si el objeto que recibe el mensaje es menor que el objeto
     * especificado.
     *
     * @param comparable el objeto a comparar.
     * @return {@code true} si el objeto receptor es menor; {@code false} en caso contrario.
     */
    Boolean sosMenor(Comparable comparable);

    /**
     * Determina si el objeto que recibe el mensaje es mayor que el objeto
     * especificado.
     *
     * @param comparable el objeto a comparar.
     * @return {@code true} si el objeto receptor es mayor; {@code false} en caso contrario.
     */
    Boolean sosMayor(Comparable comparable);
}