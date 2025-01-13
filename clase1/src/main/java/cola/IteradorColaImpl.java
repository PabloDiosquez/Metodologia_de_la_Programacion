package cola;

import comparable.Comparable;

public class IteradorColaImpl implements IteradorCola{
    private ColaImpl cola;
    private Nodo actual;

    public IteradorColaImpl(Cola cola) {
        this.cola = (ColaImpl) cola;
        this.actual = ((ColaImpl) cola).getPrim();
    }

    @Override
    public boolean hayAlgoMasParaVer() {
        return !cola.estaVacia();
    }

    @Override
    public void siguiente() {
        actual = actual.getProx();
    }

    @Override
    public Comparable verActual() {
        return actual.getDato();
    }
}
