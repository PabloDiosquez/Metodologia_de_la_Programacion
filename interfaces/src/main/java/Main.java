import cola.Cola;
import cola.ColaImpl;
import pila.Pila;
import pila.PilaImpl;
import util.UtilColeccionable;

public class Main {
    public static void main(String[] args) {
        Pila pila = new PilaImpl();
        Cola cola = new ColaImpl();

        UtilColeccionable.rellenar(pila, 20);
        UtilColeccionable.rellenar(cola, 20);

        UtilColeccionable.informar(pila);
        UtilColeccionable.informar(cola);
    }
}
