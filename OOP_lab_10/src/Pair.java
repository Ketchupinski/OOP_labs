import java.util.Scanner;

public class Pair
{
    private int a;
    private int b;

    private final Scanner scan = new Scanner(System.in);

    public Pair()
    {
        this.a = 0;
        this.b = 0;
    }

    public Pair(int x, int y)
    {
        this.a = x;
        this.b = y;
    }

    public Pair(Pair r)
    {
        this.a = r.a;
        this.b = r.b;
    }

    public int GetA()
    {
        return this.a;
    }

    public int GetB()
    {
        return this.a;
    }

    public void SetA(int value)
    {
        this.a = value;
    }

    public void SetB(int value)
    {
        this.b = value;
    }

    public static Pair plus(Pair x, Pair y) {
        return new Pair(x.a + y.a, x.b + y.b);
    }

    public static Pair minus(Pair x, Pair y)
    {
        return new Pair(x.a - y.a, x.b - y.b);
    }

    public static Pair multiply(Pair x, Pair y)
    {
        return new Pair(x.a * y.a, x.b * y.b);
    }

    public static Pair multiplyOnNum(Pair x, int num)
    {
        return new Pair(x.a * num, x.b * num);
    }

    public void read()
    {
        System.out.println("a: ");
        String sA = scan.nextLine();
        this.a = Integer.parseInt(sA);
        System.out.println("b: ");
        String sB = scan.nextLine();
        this.b = Integer.parseInt(sB);
    }

    @Override
    public String toString() {
        return "Pair[" +
                "a: " + this.a +
                " b" + this.b +
                "]";
    }
}
