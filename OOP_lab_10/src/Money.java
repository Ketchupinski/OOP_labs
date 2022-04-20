public class Money extends Pair
{
    public Money() {
        this.SetA(0);
        this.SetB(0);
    }

    public Money(int x, int y) {
        int a = x;
        int b = y;
        while (b > 99) {
            b -= 100;
            a++;
        }
        while (b < -99) {
            b += 100;
            a--;
        }
        SetA(a);
        SetB(b);
    }

    public Money(double z) {
        int a = (int) z;
        z -= a;
        z *= 100;
        int b = (int) z;
        while (b > 99) {
            b -= 100;
            a++;
        }
        while (b < -99) {
            b += 100;
            a--;
        }
        SetA(a);
        SetB(b);
    }

    public Money(Money r) {
        int a = r.GetA();
        int b = r.GetB();
        while (b > 99) {
            b -= 100;
            a++;
        }
        while (b < -99) {
            b += 100;
            a--;
        }
        SetA(a);
        SetB(b);
    }

    public static Money Plus(Money l, Money r)
    {
        Money t = new Money();
        int a = l.GetA() + r.GetA();
        int b = l.GetB() + r.GetB();
        while (b > 99) {
            b -= 100;
            a++;
        }
        t.SetA(a);
        t.SetB(b);
        return t;
    }

    public static Money Multiply(Money l, Money r)
    {
        Money t = new Money();
        int a = l.GetA() * r.GetA();
        int b = l.GetB() * r.GetB();
        while (b > 99) {
            b -= 100;
            a++;
        }
        t.SetA(a);
        t.SetB(b);
        return t;
    }

    public static Money multiplyOnNum(Money l, int k){
        Money t = new Money();
        int a = l.GetA() * k;
        int b = l.GetB() * k;
        while (b > 99) {
            b -= 100;
            a++;
        }
        t.SetA(a);
        t.SetB(b);
        return t;
    }

    public static Money Minus(Money l, Money r)
    {
        Money t = new Money();
        int a = l.GetA() - r.GetA();
        int b = l.GetB() - r.GetB();
        while (b > 99) {
            b -= 100;
            a++;
        }
        while (b < -99) {
            b += 100;
            a--;
        }
        t.SetA(a);
        t.SetB(b);
        return t;
    }

    public static double Divide(Money l, Money r)
    {
        double z1 = l.GetA() + 0.01 * l.GetB();
        double z2 = r.GetA() + 0.01 * r.GetB();
        return z1 / z2;
    }

    String Format(int b) {
        String ss = "";
        if (b < 10)
            ss += "0";
        ss += b;
        return ss;
    }

    @Override
    public String toString() {
        return GetA() + "," + Format(GetB()) + " hrn.";
    }
}