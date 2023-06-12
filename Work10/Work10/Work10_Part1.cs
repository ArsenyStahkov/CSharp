using System;
using System.Collections;

internal class main
{
    static void Main()
    {
        Console.WriteLine("No virtual methods:");
        SetNoVirtual();
        Console.WriteLine("Virtual methods:");
        SetVirtual();
    }
    static void SetNoVirtual()
    {
        LibNoVirtual.Student student = new LibNoVirtual.Student();
        student.Init("Ivan", "Ivanov", 21, 3);

        LibNoVirtual.Teacher teacher = new LibNoVirtual.Teacher();
        teacher.Init("Anna", "Savelieva",42, 15);

        LibNoVirtual.Employee employee = new LibNoVirtual.Employee();
        employee.Init("Alexandr", "Alexandrov", 32, 35000);

        LibNoVirtual.Person[] people = new LibNoVirtual.Person[3];
        people[0] = student;
        people[1] = teacher;
        people[2] = employee;
        foreach (LibNoVirtual.Person person in people)
            person.Show();
    }

    static void SetVirtual()
    {
        LibVirtual.Student student = new LibVirtual.Student("Ivan", "Ivanov", 21);
        student.Init();

        LibVirtual.Teacher teacher = new LibVirtual.Teacher("Anna", "Savelieva", 42);
        teacher.Init();

        LibVirtual.Employee employee = new LibVirtual.Employee("Alexandr", "Alexandrov", 32);
        employee.Init();

        LibVirtual.Person[] people = new LibVirtual.Person[3];
        people[0] = student;
        people[1] = teacher;
        people[2] = employee;
        foreach (LibVirtual.Person person in people)
            person.Show();
    }
}

