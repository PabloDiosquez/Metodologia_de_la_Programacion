package cola;
import coleccionable.Coleccionable;
import comparable.Comparable;

public class ColaImpl implements Cola, Coleccionable {
    private Nodo prim;
    private Nodo ult;
    private int cant;

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
        return null;
    }

    @Override
    public Comparable maximo() {
        return null;
    }

    @Override
    public void agregar(Comparable comparable) {
        this.encolar(comparable);
    }
    @Override
    public boolean pertenece(Comparable comparable) {
        return false;
    }
}
