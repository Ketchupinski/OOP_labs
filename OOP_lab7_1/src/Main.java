public class Main {
    public static void main(String[] args) {
        Matrix a = Matrix.Create();
        a.Fill();
        a.Display();

        Matrix b = Matrix.Create();
        b.Fill();
        b.Display();

        System.out.println("a - b: ");
        var z = Matrix.Minus(a, b);
        z.Display();

        System.out.println("\na == b: " + (a.equals(b)) + "\n");

        System.out.println("Matrix norm from matrix a: " + a.Norm());
    }
}