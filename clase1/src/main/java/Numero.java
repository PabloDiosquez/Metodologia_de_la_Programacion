import comparable.Comparable;

public class Numero implements Comparable{
    private int valor;

    public Numero(int valor){
        this.valor = valor;
    }

    public int getValor(){
        return valor;
    }
    @Override
    public boolean sosIgual(Comparable otro) {
        return this.getValor() == ((Numero)otro).getValor();
    }

    @Override
    public boolean sosMenor(Comparable otro) {
        return this.getValor() < ((Numero)otro).getValor();
    }

    @Override
    public boolean sosMayor(Comparable otro) {
        return this.getValor() > ((Numero)otro).getValor();
    }
}
