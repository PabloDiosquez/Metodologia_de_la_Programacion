package coleccionable;

import numero.Numero;
import comparable.Comparable;

import java.util.Random;

public class ServicioColeccionableImpl implements ServicioColeccionable {
    @Override
    public void rellenar(Coleccionable coleccionable, int cantidad) {
        for (int i = 0; i < cantidad; i++) {
            Comparable comparable = new Numero(new Random().nextInt(1000));
            coleccionable.agregar(comparable);
        }
    }

    @Override
    public void informar(Coleccionable coleccionable) {
        System.out.println(coleccionable.cuantos());
        System.out.println(coleccionable.maximo());
        System.out.println(coleccionable.minimo());
    }
}
