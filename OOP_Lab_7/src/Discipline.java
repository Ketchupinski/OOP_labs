import java.util.Objects;
import java.util.Scanner;

public class Discipline
{
    private String Name; // назва
    private int NoSem; // № семестру
    private int KStud; // к-ть студентів
    private int Lec; // годин лекцій
    private int Prac; // годин практичних
    private boolean Exam; // форма контролю (екзамен = true)

    private final Scanner scan = new Scanner(System.in);

    public Discipline()
    {
        Name = ""; // назва
        NoSem = 0; // № семестру
        KStud = 0; // к-ть студентів
        Lec = 0; // годин лекцій
        Prac = 0; // годин практичних
        Exam = false; // форма контролю (екзамен = true)
    }

    public Discipline(String name,
                      int noSem,
                      int kStud,
                      int lec,
                      int prac,
                      boolean exam)
    {
        this.Name = name; // назва
        this.NoSem = noSem; // № семестру
        this.KStud = kStud; // к-ть студентів
        this.Lec = lec; // годин лекцій
        this.Prac = prac; // годин практичних
        this.Exam = exam; // форма контролю (екзамен = true)
    }

    public Discipline(Discipline d)
    {
        this.Name = d.Name; // назва
        this.NoSem = d.NoSem; // № семестру
        this.KStud = d.KStud; // к-ть студентів
        this.Lec = d.Lec; // годин лекцій
        this.Prac = d.Prac; // годин практичних
        this.Exam = d.Exam; // форма контролю (екзамен = true)
    }

    public boolean isExam()
    {
        return Exam;
    }

    public String getName()
    {
        return Name;
    }

    public int getNoSem()
    {
        return NoSem;
    }

    public int getKStud()
    {
        return KStud;
    }

    public int getLec()
    {
        return Lec;
    }

    public int getPrac()
    {
        return Prac;
    }

    public void setNoSem(int value)
    {
        NoSem = value;
    }

    public void setKStud(int value)
    {
        KStud = value;
    }

    public int Summa()
    {
        return this.Lec + this.Prac;
    }

    public void Read()
    {
        System.out.println(" name: ");
        this.Name = scan.nextLine();
        System.out.println(" noSem: ");
        String sNoSem = scan.nextLine();
        this.NoSem = Integer.parseInt(sNoSem);
        System.out.println(" kStud: ");
        String sKStud = scan.nextLine();
        this.KStud = Integer.parseInt(sKStud);
        System.out.println(" lek: ");
        String sLec = scan.nextLine();
        this.Lec = Integer.parseInt(sLec);
        System.out.println(" prak: ");
        String sPrac = scan.nextLine();
        this.Prac = Integer.parseInt(sPrac);
        System.out.println(" exam (true/false): ");
        String sExam = scan.nextLine();
        this.Exam = Boolean.parseBoolean(sExam);
    }

    public void Increment() {
        this.KStud++;
    }

    public void Decrement() {
        this.KStud--;
    }

    @Override
    public String toString() {
        return "Discipline[" +
                "Name: " + this.Name +
                " NoSem: " + this.NoSem +
                " KStud: " + this.KStud +
                " Lec: " + this.Lec +
                " Prac: " + this.Prac +
                " Exam: " + this.Exam +
                "] ";
    }

    @Override
    public boolean equals(Object obj) {
        Discipline d = (Discipline) obj;
        return Objects.equals(this.Name, d.getName());
    }
}
