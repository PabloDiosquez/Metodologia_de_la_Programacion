package pila;

import comparable.Comparable;
import iterador.Iterador;
import nodo.Nodo;

public class IteradorPila implements Iterador {
    private PilaImpl pila;
    Nodo<Comparable> act;

    public IteradorPila(PilaImpl pila) {
        this.pila = pila;
        this.act = pila.getTope();
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
