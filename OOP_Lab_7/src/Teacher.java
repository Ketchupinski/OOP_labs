import java.util.Scanner;

public class Teacher {
    private String Name;
    private String Date; // дата початку роботи

    private final Scanner scan = new Scanner(System.in);

    public Teacher()
    {
        this.Name = "";
        this.Date = "00.00.0000";
    }

    public Teacher(String name, String date)
    {
        this.Name = name;
        this.Date = date;
    }

    public String GetName()
    {
        return this.Name;
    }

    public String GetDate()
    {
        return this.Date;
    }

    public void SetName(String name)
    {
        this.Name = name;
    }

    public void SetDate(String date)
    {
        this.Date = date;
    }

    public void Read()
    {
        System.out.println("teacher name:");
        this.Name = scan.nextLine();

        System.out.println(" beginning work date : ");
        this.Date = scan.nextLine();
    }

    @Override
    public String toString() {
        return "Teacher[" +
                "Name: " + this.Name +
                " Start working date: " + this.Date +
                "] ";
    }
}
