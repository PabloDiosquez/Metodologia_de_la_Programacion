package cola;

import comparable.Comparable;
import nodo.Nodo;

public class ColaImpl implements Cola{
    private Nodo<Comparable> prim;
    private Nodo<Comparable> ult;
    private int cant;

    public ColaImpl() {
        this.prim = null;
        this.ult = null;
        this.cant = 0;
    }

    public Nodo<Comparable> getPrim() {
        return prim;
    }

    @Override
    public boolean estaVacia() {
        return prim == null;
    }

    @Override
    public Comparable quitar() {
        assert prim != null;
        Comparable dato = prim.getDato();
        prim = prim.getProx();
        if(prim == null){
            ult = null;
        }
        cant--;
        return dato;
    }

    @Override
    public Comparable verPrimero() {
        assert prim != null;
        return prim.getDato();
    }

    @Override
    public int cuantos() {
        return cant;
    }

    @Override
    public Comparable minimo() {
        IteradorCola it = new IteradorCola(this);
        Comparable min = this.verPrimero();
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
        IteradorCola it = new IteradorCola(this);
        Comparable max = this.verPrimero();
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
        Nodo<Comparable> nuevo = new Nodo<>(comparable);
        if(prim == null){
            prim = nuevo;
        } else {
            ult.setProx(nuevo);
        }
        ult = nuevo;
        cant++;
    }

    @Override
    public Boolean contiene(Comparable comparable) {
        IteradorCola it = new IteradorCola(this);
        while(it.hayAlgoMasParaVer()){
            if(it.verActual().sosIgual(comparable)){
                return true;
            }
            it.siguiente();
        }
        return false;
    }
}
