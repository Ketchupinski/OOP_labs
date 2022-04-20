public class Main {
    public static void main(String[] args) {
        Money x = new Money(1, 2);
        Money z = new Money();
        z.read();
        Money y = Money.Plus(x, z);
        System.out.println("y: " + y.toString());
        Pair k = Money.Multiply(x, z);
        System.out.println("\nk: " + k.toString());
        double l = Money.Divide(x, z);
        System.out.println("\nl: " + l);
    }
}