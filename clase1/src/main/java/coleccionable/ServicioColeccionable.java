package coleccionable;

import coleccionable.Coleccionable;
public interface ServicioColeccionable {
    void rellenar(Coleccionable coleccionable, int cantidad);

    void informar(Coleccionable coleccionable);
}
