import java.util.Objects;
import java.util.Scanner;

public class Workload  {
    private Teacher Teacher;
    private int Size; // максимальна кількість елементів масиву
    private int Count; // кількість елементів масиву
    private sDiscipline[] Disciplines; // масив дисциплін
    private double TotalAmount; // обсяг навантаження в годинах
    private double SalaryRate; // доля ставки зарплати
    private static double AvgAmount = 600.0; // середнє навантаження на ставку

    private final Scanner scan = new Scanner(System.in);

    public Workload()
    {
        Teacher = new Teacher();
        Size = 0;
        Count = 0;
        Disciplines = new sDiscipline[Size];
        TotalAmount = 0;
        SalaryRate = 0;
    }

    public Workload(Teacher t)
    {
        Teacher = t;
        Size = 0;
        Count = 0;
        Disciplines = new sDiscipline[Size];
        TotalAmount = 0;
        SalaryRate = 0;
    }

    public Workload(Workload w)
    {
        this.Teacher = w.Teacher;
        Size = w.Size;
        Count = w.Count;
        Disciplines = new sDiscipline[Size];
        for (int i = 0; i < Count; i++)
            Disciplines[i] = w.Disciplines[i];
        TotalAmount = w.TotalAmount;
        SalaryRate = w.SalaryRate;
    }

    public int GetSize()
    {
        return this.Size;
    }

    public int GetCount()
    {
        return this.Count;
    }

    public void SetSize(int value)
    {
        sDiscipline[] t = new sDiscipline[value];
        int minSize = Math.min(this.Size, value);
        if (minSize >= 0) System.arraycopy(this.Disciplines, 0, t, 0, minSize);
        this.Size = value;
        this.Disciplines = t;
    }

    public void Read()
    {
        Teacher.Read();
        sDiscipline sD = new sDiscipline();
        String c;
        do
        {
            System.out.println();
            sD.Read();
            this.AddDiscipline(sD);
            System.out.println("continue? (Y/N) ");
            c = scan.nextLine();
        } while (c.equals("y"));
    }

    public void AddDiscipline(sDiscipline d) // добавити дисципліну
    {
        if (this.Count == this.Size)
        {
            SetSize(this.Size + 1);
        }

        this.Disciplines[this.Count] = d;
        this.Count++;
        Summa();
        SalaryRating();
    }

    public sDiscipline DelDiscipline() // вилучити дисципліну
    {
        if (this.Count > 0)
        {
            sDiscipline t = this.Disciplines[this.Count - 1];
            this.Count--;
            Summa();
            SalaryRating();
            return t;
        }
        System.out.println("Index out of range!");
        return this.Disciplines[0];
    }

    public sDiscipline DelDiscipline(int index) // вилучити дисципліну по індексу
    {
        if (index >= 0 && index < this.Count)
        {
            sDiscipline t = this.Disciplines[index];
            if (this.Count - (index + 1) >= 0)
                System.arraycopy(this.Disciplines, index + 1, this.Disciplines,
                        index + 1 - 1, this.Count - (index + 1));
            this.Count--;
            Summa();
            SalaryRating();
            return t;
        }
        System.out.println("Index out of range!");
        return this.Disciplines[0];
    }

    public sDiscipline DelDiscipline(String name) // вилучити дисципліну по імені
    {
        int index = -1;
        for (int i = 0; i < this.Count; i++)
            if (Objects.equals(this.Disciplines[i].Discipline.getName(), name))
            {
                index = i;
                break;
            }
        return DelDiscipline(index);
    }

    sDiscipline DelDiscipline(sDiscipline d) // вилучити дисципліну по об'єкту дисципліни
    {
        int index = -1;
        for (int i = 0; i < this.Count; i++)
            if (this.Disciplines[i] == d)
            {
                index = i;
                break;
            }
        return DelDiscipline(index);
    }

    public void Summa() // сумарне навантаження в годинах
    {
        this.TotalAmount = 0;
        for (int i = 0; i < this.Count; i++)
            this.TotalAmount += this.Disciplines[i].Summa();
    }

    public void SalaryRating() // сумарне навантаження в ставках
    {
        this.SalaryRate = TotalAmount / AvgAmount;
    }

    public boolean CheckWorkload() // перевірка навантаження
    {
        return SalaryRate <= 1.5;
    }

    @Override
    public String toString() {
        StringBuilder s = new StringBuilder("Workload[" +
                Teacher.toString() +
                " disciplines: [");
        for (int i = 0; i < this.Count; i++)
        {
            s.append("discipline #").append(i).append(": ").append(this.Disciplines[i]);
        }

        s.append("] ]");
        return s.toString();
    }

    public void Increment() {
        for (int i = 0; i < this.Count; i++)
            this.Disciplines[i].Increment();
    }

    public void Decrement() {
        for (int i = 0; i < this.Count; i++)
            this.Disciplines[i].Decrement();
    }
}
