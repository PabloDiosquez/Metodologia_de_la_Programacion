import comparable.Comparable;

public class Nodo {
    private Comparable dato;
    private Nodo prox;

    public Nodo(Comparable dato, Nodo prox){
        this.dato = dato;
        this.prox = prox;
    }

    public Nodo(Comparable dato){
        this(dato, null);
    }

    public Comparable getDato(){
        return dato;
    }

    public Nodo getProx(){
        return prox;
    }
}
