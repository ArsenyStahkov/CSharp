using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using LibVirtual;

public class Task3
{
    public static void Main()
    {
        LibVirtual.Student student = new LibVirtual.Student("Ivan", "Ivanov", 21);
        student.Init();

        LibVirtual.Teacher teacher = new LibVirtual.Teacher("Anna", "Savelieva", 42);
        teacher.Init();

        LibVirtual.Employee employee = new LibVirtual.Employee("Alexandr", "Alexandrov", 32);
        employee.Init();

        LibVirtual.Student student_2 = new LibVirtual.Student("Anastasia", "Cherepanova", 22);
        student.Init();

        Hashtable ht = new Hashtable();

        ht.Add(0, student);
        ht.Add(1, teacher);
        ht.Add(2, employee);
        ht.Add(3, student_2);
    }
}
