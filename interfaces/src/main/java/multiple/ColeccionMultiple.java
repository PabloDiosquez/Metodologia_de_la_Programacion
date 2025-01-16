package multiple;

import cola.Cola;
import coleccionable.Coleccionable;
import comparable.Comparable;
import pila.Pila;

public class ColeccionMultiple implements Coleccionable {
    private Pila pila;
    private Cola cola;

    public ColeccionMultiple(Pila pila, Cola cola) {
        this.pila = pila;
        this.cola = cola;
    }

    @Override
    public int cuantos() {
        return pila.cuantos() + cola.cuantos();
    }

    @Override
    public Comparable minimo() {
        Comparable p = pila.minimo();
        Comparable c = cola.minimo();
        return p.sosMenor(c) ? p: c;
    }

    @Override
    public Comparable maximo() {
        Comparable p = pila.maximo();
        Comparable c = cola.maximo();
        return p.sosMayor(c) ? p : c;
    }

    // NOTE: Este método no debe hacer nada.
    @Override
    public void agregar(Comparable comparable) {

    }

    @Override
    public Boolean contiene(Comparable comparable) {
        return pila.contiene(comparable) || cola.contiene(comparable);
    }
}
