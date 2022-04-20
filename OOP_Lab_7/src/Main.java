import java.util.Scanner;

public class Main {
    private static final Scanner scan = new Scanner(System.in);

    public static void main(String[] args) {
        Workload a = new Workload();
        sDiscipline sd = new sDiscipline();
        Teacher[] teachers = new Teacher[0];
        int no;
        int i;
        do {
            switch (i = Menu())
            {
                case 1:
                    a.Read();
                    break;
                case 2:
                    System.out.println(a);
                    break;
                case 3:
                    System.out.println("Enter discipline to add:");
                    sd.Read();
                    a.AddDiscipline(sd);
                    break;
                case 4:
                    System.out.println("Enter # discipline to delete");
                    String sNo = scan.nextLine();
                    no = Integer.parseInt(sNo);
                    a.DelDiscipline(no);
                    break;
                case 5:
                    System.out.println("Input number of teachers you want to input: ");
                    String sSize = scan.nextLine();
                    System.out.println("Line: " + sSize);
                    int size = Integer.parseInt(sSize);
                    teachers = new Teacher[size];
                    for (int x = 0; x < size; x++)
                    {
                        System.out.println("Input teacher #" + (x + 1) + " name:");
                        String name = scan.nextLine();
                        System.out.println("Input teacher #" + (x + 1) + " beginning work date: ");
                        String date = scan.nextLine();
                        teachers[x] = new Teacher(name, date);
                    }
                    break;
                case 6:
                    for (int x = 0; x < teachers.length; x++)
                    {
                        System.out.println("Teacher #" + (x + 1) + ": " +
                                "Name: " + teachers[x].GetName() +
                                " Beginning work date: " + teachers[x].GetDate());
                    }
                    break;
                case 0:
                    break;
                default:
                    System.out.println("Incorrect value!");
                    break;
            }
        } while (i != 0);
    }

    public static int Menu()
    {
        System.out.println("Enter your choise:");
        System.out.println(" 1 - input data");
        System.out.println(" 2 - print data");
        System.out.println(" 3 - add discipline");
        System.out.println(" 4 - delete discipline");
        System.out.println(" 5 - create teachers list");
        System.out.println(" 6 - print teachers list");
        System.out.println(" 0 - exit");
        String ScanI = scan.nextLine();
        return Integer.parseInt(ScanI);
    }
}