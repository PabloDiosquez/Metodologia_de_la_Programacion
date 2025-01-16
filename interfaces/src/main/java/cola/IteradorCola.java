package cola;

import comparable.Comparable;
import iterador.Iterador;
import nodo.Nodo;

public class IteradorCola implements Iterador {

    private ColaImpl cola;

    private Nodo<Comparable> act;

    public IteradorCola(ColaImpl cola) {
        this.cola = cola;
        this.act = cola.getPrim();
    }

    @Override
    public Boolean hayAlgoMasParaVer() {
        return act != null;
    }

    @Override
    public Comparable verActual() {
        return act.getDato();
    }

    @Override
    public void siguiente() {
        act = act.getProx();
    }
}
