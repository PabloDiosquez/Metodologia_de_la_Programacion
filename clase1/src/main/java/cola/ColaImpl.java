package cola;
import coleccionable.Coleccionable;
import comparable.Comparable;

public class ColaImpl implements Cola, Coleccionable {
    private Nodo prim;
    private Nodo ult;
    private int cant;

    public Nodo getPrim() {
        return prim;
    }

    @Override
    public void encolar(Comparable comparable) {
        Nodo nuevo = new Nodo(comparable);
        if(this.prim == null){
            this.prim = nuevo;
        } else {
            this.ult.setProx(nuevo);
        }
        this.ult = nuevo;
        this.cant++;
    }

    @Override
    public Comparable desencolar() {
        assert this.prim != null;
        Comparable dato = this.prim.getDato();
        this.prim = this.prim.getProx();
        if(this.prim == null){
            this.ult = null;
        }
        this.cant--;
        return dato;
    }

    @Override
    public Comparable verPrimero() {
        assert this.prim != null;
        return this.prim.getDato();
    }

    @Override
    public boolean estaVacia() {
        return this.prim == null;
    }

    @Override
    public int cuantos() {
        return this.cant;
    }

    @Override
    public Comparable minimo() {
        if(this.estaVacia()){
            return null;
        }
        IteradorCola it = new IteradorColaImpl(this);
        Comparable minActual = this.verPrimero();
        while(it.hayAlgoMasParaVer()){
            if(it.verActual().sosMenor(minActual)){
                minActual = it.verActual();
            }
            it.siguiente();
        }
        return minActual;
    }

    @Override
    public Comparable maximo() {
        if(this.estaVacia()){
            return null;
        }
        IteradorCola it = new IteradorColaImpl(this);
        Comparable maxActual = this.verPrimero();
        while(it.hayAlgoMasParaVer()){
            if(it.verActual().sosMayor(maxActual)){
                maxActual = it.verActual();
            }
            it.siguiente();
        }
        return maxActual;
    }

    @Override
    public void agregar(Comparable comparable) {
        this.encolar(comparable);
    }
    @Override
    public boolean pertenece(Comparable comparable) {
        IteradorCola it = new IteradorColaImpl(this);
        while(it.hayAlgoMasParaVer()){
            if(it.verActual().sosIgual(comparable)){
                return true;
            }
            it.siguiente();
        }
        return false;
    }
}