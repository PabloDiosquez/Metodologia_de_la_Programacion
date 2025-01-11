/**
 * Clase que representa una pila, una estructura de datos LIFO (Last In, First Out).
 * Implementa la interfaz {Coleccionable} para operar sobre elementos {Comparable}.
 */
public class Pila implements Coleccionable {

    private Nodo tope = null;

    /**
     * Crea una pila vacía.
     */
    public Pila() {
    }

    /**
     * Verifica si la pila está vacía.
     *
     * @return {@code true} si la pila está vacía, {@code false} si contiene elementos
     */
    public boolean estaVacia() {
        return this.tope == null;
    }

    /**
     * Devuelve el elemento en la cima de la pila sin eliminarlo.
     *
     * @return El dato en la cima de la pila
     * @throws AssertionError Si la pila está vacía
     */
    public Comparable verTope() {
        assert this.tope != null;
        return this.tope.getDato();
    }

    /**
     * Elimina y retorna el elemento en la cima de la pila.
     *
     * @return El dato en la cima de la pila
     * @throws AssertionError Si la pila está vacía
     */
    public Comparable desapilar() {
        assert this.tope != null;
        Comparable dato = this.tope.getDato();
        this.tope = this.tope.getProx();
        return dato;
    }

    /**
     * Cuenta la cantidad de elementos en la pila.
     *
     * @return El número de elementos en la pila
     */
    @Override
    public int cuantos() {
        if (this.tope == null) {
            return 0;
        }
        Comparable tope = this.desapilar();
        int cantAct = this.cuantos();
        this.agregar(tope);
        return 1 + cantAct;
    }

    /**
     * Devuelve el elemento de menor valor en la pila.
     *
     * @return El elemento de menor valor en la pila
     */
    @Override
    public Comparable minimo() {
        Pila aux = new Pila();
        Comparable minAct = this.tope.getDato();
        while (this.tope != null) {
            Comparable tope = this.desapilar();
            if (tope.sosMenor(minAct)) {
                minAct = tope;
            }
            aux.agregar(tope);
        }
        while (aux.tope != null) {
            this.agregar(aux.desapilar());
        }
        return minAct;
    }

    /**
     * Devuelve el elemento de mayor valor en la pila.
     *
     * @return El elemento de mayor valor en la pila
     */
    @Override
    public Comparable maximo() {
        Pila aux = new Pila();
        Comparable maxAct = this.tope.getDato();
        while (this.tope != null) {
            Comparable tope = this.desapilar();
            if (tope.sosMayor(maxAct)) {
                maxAct = tope;
            }
            aux.agregar(tope);
        }
        while (aux.tope != null) {
            this.agregar(aux.desapilar());
        }
        return maxAct;
    }

    /**
     * Agrega un elemento a la cima de la pila.
     *
     * @param comparable El elemento a agregar
     */
    @Override
    public void agregar(Comparable comparable) {
        this.tope = new Nodo(comparable, this.tope);
    }

    /**
     * Verifica si un elemento pertenece a la pila.
     *
     * @param comparable El elemento a buscar
     * @return {@code true} si el elemento está en la pila, {@code false} en caso contrario
     */
    @Override
    public boolean pertenece(Comparable comparable) {
        if (this.tope == null) {
            return false;
        }
        Comparable tope = this.desapilar();
        boolean esta = tope.sosIgual(comparable);
        if (!esta) {
            esta = this.pertenece(comparable);
        }
        this.agregar(tope);
        return esta;
    }
}
