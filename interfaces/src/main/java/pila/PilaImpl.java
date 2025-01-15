package pila;

import comparable.Comparable;
import nodo.Nodo;

public class PilaImpl implements Pila{
    private Nodo<Comparable> tope;
    private int cantidad;
    public PilaImpl() {
        this.tope = null;
        this.cantidad = 0;
    }

    @Override
    public int cuantos() {
        return cantidad;
    }

    @Override
    public Comparable minimo() {
        if(estaVacia()){
            return null;
        }
        Comparable min = verTope();
        IteradorPila it = new IteradorPila(this);
        while(it.hayAlgoMasParaVer()){
            if(it.verActual().sosMenor(min)){
                min = it.verActual();
            }
            it.siguiente();
        }
        return min;
    }

    @Override
    public Comparable maximo() {
        if(estaVacia()){
            return null;
        }
        Comparable max = verTope();
        IteradorPila it = new IteradorPila(this);
        while(it.hayAlgoMasParaVer()){
            if(it.verActual().sosMayor(max)){
                max = it.verActual();
            }
            it.siguiente();
        }
        return max;
    }

    @Override
    public void agregar(Comparable comparable) {
        tope = new Nodo<>(comparable, tope);
        cantidad++;
    }

    @Override
    public Boolean contiene(Comparable comparable) {
        IteradorPila it = new IteradorPila(this);
        while(it.hayAlgoMasParaVer()){
            if(it.verActual().sosIgual(comparable)){
                return true;
            }
            it.siguiente();
        }
        return false;
    }

    @Override
    public Comparable desapilar() {
        if(estaVacia()){
            return null;
        }
        Comparable dato = tope.getDato();
        tope = tope.getProx();
        cantidad--;
        return dato;
    }

    @Override
    public Boolean estaVacia() {
        return tope == null;
    }

    @Override
    public Comparable verTope() {
        if(estaVacia()){
            return null;
        }
        return tope.getDato();
    }
}
