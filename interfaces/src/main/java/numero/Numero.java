package numero;

import comparable.Comparable;

public class Numero implements Comparable {
    private int valor;

    public Numero(int valor) {
        this.valor = valor;
    }

    public int getValor(){
        return valor;
    }

    @Override
    public Boolean sosIgual(Comparable comparable) {
        return this.getValor() == ((Numero)comparable).getValor();
    }

    @Override
    public Boolean sosMenor(Comparable comparable) {
        return this.getValor() < ((Numero)comparable).getValor();
    }

    @Override
    public Boolean sosMayor(Comparable comparable) {
        return this.getValor() > ((Numero)comparable).getValor();
    }

    @Override
    public String toString() {
        return String.format("%d", getValor());
    }
}
