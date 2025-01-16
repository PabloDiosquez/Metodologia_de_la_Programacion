package util;

import coleccionable.Coleccionable;
import comparable.Comparable;
import numero.Numero;

import java.util.Random;

public class UtilColeccionable {

    public static void rellenar(Coleccionable coleccionable, int cant){
        for (int i = 0; i < cant; i++) {
            Comparable comparable = new Numero(new Random().nextInt(100));
            coleccionable.agregar(comparable);
        }
    }

    public static void informar(Coleccionable coleccionable){
        System.out.printf("Cantidad elementos: %d\n", coleccionable.cuantos());
        System.out.printf("Mínimo: %s\n", coleccionable.minimo());
        System.out.printf("Máximo: %s\n", coleccionable.maximo());
    }
}
