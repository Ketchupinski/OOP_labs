package com.university;

public class Main {

    public static void main(String[] args) {
        Student s1 = new Student();
        System.out.println("Student: " + Student.getCounter());
        System.out.println("Student::Man: " + Student.Man.getCounter());

        Student s2 = new Student("Valera", 25, "KN");
        System.out.println("Student local: " + Student.getCounter());
        System.out.println("Student::Man local: " + Student.Man.getCounter());
        System.out.println("s2: " + s2.ToString());
    }
}
