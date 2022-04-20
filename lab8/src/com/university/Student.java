package com.university;

import java.util.Scanner;

public class Student
{
    private Man man;
    String spec;
    static int counter;

    public class Man
    {
        private String name;
        private int age;
        private static int counter = 0;

        public Man()
        {
            name = "";
            age = 0;
            counter++;
        }

        public Man(String name, int age)
        {
            this.name = name;
            this.age = age;
            counter++;
        }

        public Man(Man m)
        {
            this.name = m.name;
            this.age = m.age;
            counter++;
        }

        public int getAge()
        {
            return this.age;
        }

        public String getName()
        {
            return this.name;
        }

        public static int getCounter()
        {
            return counter;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public boolean Init(String name, int age)
        {
            if (age > 0 && age < 100)
            {
                setName(name);
                setAge(age);
                return true;
            }

            return false;
        }

        public void Display() {
            System.out.println("Name: " + name + ", " + "age: " + age);
        }

        public void Read()
        {
            Scanner scan = new Scanner("System.in");
            String n;
            int a;
            do {
                System.out.println("Name: ");
                n = scan.nextLine();
                System.out.println("Age: ");
                a = scan.nextInt();
            } while (!Init(n, a));
        }

        public String ToString() {
        return "Man: [name: " + this.name + ", "
                + "age: " + this.age +
                "]";
        }
    }

    public Student()
    {
        this.man = new Man();
        this.spec = "";
        counter++;
    }

    public Student(Man man, String spec)
    {
        this.man = man;
        this.spec = spec;
        counter++;
    }

    public Student(Student student)
    {
        this.man = student.man;
        this.spec = student.spec;
        counter++;
    }

    public Student(String name, int age, String spec)
    {
        this.spec = spec;
        this.man = new Man(name, age);
        counter++;
    }

    public Man getMan()
    {
        return this.man;
    }

    public String getSpec()
    {
        return this.spec;
    }

    public static int getCounter()
    {
        return counter;
    }

    public void setMan(Man man)
    {
        this.man = man;
    }

    public void setSpec(String spec)
    {
        this.spec = spec;
    }

    public void Display()
    {
        System.out.println("Spec: " + this.spec);
        this.man.Display();
    }

    public void Read()
    {
        Scanner scan = new Scanner("System.in");
        String sp, name;
        int age;
        do
        {
            System.out.println("Name: ");
            name = scan.nextLine();
            System.out.println("Age: ");
            age = scan.nextInt();
            System.out.println("Spec: ");
            sp = scan.nextLine();
        } while (!this.man.Init(name, age));
        this.spec = sp;
    }

    public String ToString() {
    return "Student: [" + this.man.ToString() + ", "
            + "spec: " + this.spec +
            "]";
    }
}