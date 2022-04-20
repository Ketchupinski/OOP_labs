public class sDiscipline { // Будемо вважати, що структура - це клас з відкритими полями
    public Discipline Discipline;
    public double ExamTime;
    public double Amount;

    public sDiscipline()
    {
        ExamTime = 0;
        Amount = 0;
        Discipline = new Discipline();
    }

    public sDiscipline(Discipline d)
    {
        this.Discipline = d;
        this.ExamTime = d.isExam()
                ? d.getKStud() * 0.3
                : d.getKStud() * 0.2;
        this.Amount = this.ExamTime + this.Discipline.getLec() + this.Discipline.getPrac();
    }

    public sDiscipline(sDiscipline sD)
    {
        this.Discipline = sD.Discipline;
        this.ExamTime = sD.ExamTime;
        this.Amount = sD.Amount;
    }

    public void Increment() {
        this.Discipline.Increment();
    }

    public void Decrement() {
        this.Discipline.Decrement();
    }

    public void Read()
    {
        System.out.println("discipline:");
        this.Discipline.Read();
    }

    @Override
    public boolean equals(Object obj) {
        Discipline d = (Discipline) obj;
        return d.equals(this.Discipline);
    }

    @Override
    public String toString() {
        return "sDiscipline[" +
                "ExamTime: " + this.ExamTime +
                " Amount: " + this.Amount +
                " Discipline: " + this.Discipline.toString() +
                "] ";
    }

    public double Summa()
    {
        this.ExamTime = this.Discipline.isExam()
                ? Discipline.getKStud() * 0.3
                : Discipline.getKStud() * 0.2;
        this.Amount = this.ExamTime + this.Discipline.getLec() + this.Discipline.getPrac();
        return this.Amount;
    }
}
