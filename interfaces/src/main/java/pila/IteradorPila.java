package pila;

import comparable.Comparable;
import iterador.Iterador;

public class IteradorPila implements Iterador {
    private PilaImpl pila;

    public IteradorPila(PilaImpl pila) {
        this.pila = pila;
    }

    @Override
    public Boolean hayAlgoMasParaVer() {
        return true;
    }

    @Override
    public Comparable verActual() {
        return null;
    }

    @Override
    public void siguiente() {

    }
}
