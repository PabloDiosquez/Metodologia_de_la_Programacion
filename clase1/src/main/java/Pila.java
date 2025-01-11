public class Pila implements Coleccionable{

    private Nodo tope = null;

    public Pila(){
    }

    public boolean estaVacia(){
        return this.tope == null;
    }

    // PRE: La pila debe tener al menos un elemento.
    public Comparable verTope(){
        assert this.tope != null;
        return this.tope.getDato();
    }

    // PRE: La pila debe tener al menos un elemento.
    public Comparable desapilar(){
        assert this.tope != null;
        Comparable dato = this.tope.getDato();
        this.tope = this.tope.getProx();
        return dato;
    }
    @Override
    public int cuantos() {
        if(this.tope == null){
          return 0;
        }
        Comparable tope = this.desapilar();
        int cantAct = this.cuantos();
        this.agregar(tope);
        return 1 + cantAct;
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
        this.tope = new Nodo(comparable, this.tope);
    }

    @Override
    public boolean pertenece(Comparable comparable) {
        if(this.tope == null){
            return false;
        }
        Comparable tope = this.desapilar();
        boolean esta = this.pertenece(comparable);
        this.agregar(tope);
        return tope.sosIgual(comparable) || esta;
    }
}
