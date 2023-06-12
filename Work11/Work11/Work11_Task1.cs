using LibVirtual;
using System;

class Task1
{
    static void Main()
    {
        WorkWithQueue();
    }
    static public void WorkWithQueue()
    {
        LibVirtual.Student student = new LibVirtual.Student("Ivan", "Ivanov", 21);
        student.Init();

        LibVirtual.Teacher teacher = new LibVirtual.Teacher("Anna", "Savelieva", 42);
        teacher.Init();

        LibVirtual.Employee employee = new LibVirtual.Employee("Alexandr", "Alexandrov", 32);
        employee.Init();

        Queue<LibVirtual.Person> people = new Queue<LibVirtual.Person>();
        people.Enqueue(student);
        people.Enqueue(teacher);
        people.Enqueue(employee);

        string menu
            =   "1. Check queue\n" +
                "2. Add person\n" +
                "3. Remove object\n" +
                "0. Exit\n";
        Console.WriteLine(menu);

        int num = -1;
        while (num != 0)
        {
            num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    PrintQueue(ref people);
                    break;
                case 2:
                    AddObject(ref people);
                    break;
                case 3:
                    RemoveObject(ref people);
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Try again:");
                    break;
            }
        }
    }

    static public void AddObject(ref Queue<LibVirtual.Person> people)
    {
        string name, surname;
        Console.Write("Name: ");
        name = Console.ReadLine();
        Console.Write("Surname: ");
        surname = Console.ReadLine();

        string menu
            =   "1. Student\n" +
                "2. Teacher\n" +
                "3. Employee\n" +
                "0. Exit\n";
        Console.WriteLine(menu);

        int num = -1;
        int n = 0;

        num = int.Parse(Console.ReadLine());
        switch (num)
        {
            case 1:
                Console.Write("Course: ");
                n = int.Parse(Console.ReadLine());
                if (n < 0 || 5 < n)
                    return;
                LibVirtual.Student person = new LibVirtual.Student(name, surname, n);
                person.Init();
                people.Enqueue(person);
                return;
            case 2:
                Console.Write("Experience: ");
                n = int.Parse(Console.ReadLine());
                if (n < 1 || 70 < n)
                    return;
                LibVirtual.Teacher teacher = new LibVirtual.Teacher(name, surname, n);
                teacher.Init();
                people.Enqueue(teacher);
                return;
            case 3:
                Console.Write("Salary: ");
                n = int.Parse(Console.ReadLine());
                if (n < 15000 || 200000 < n)
                    return;
                LibVirtual.Employee employee = new LibVirtual.Employee(name, surname, n);
                employee.Init();
                people.Enqueue(employee);
                return;
        }
    }

    static public void RemoveObject(ref Queue<LibVirtual.Person> people)
    {
        if (people.Count == 0)
            return;
        people.Dequeue();
    }

    static public void PrintQueue(ref Queue<LibVirtual.Person> people)
    {
        foreach (LibVirtual.Person person in people)
        {
            Console.Write(person.GetName() + ' ');
            Console.Write(person.GetSurname() + ", ");
            Console.WriteLine(person.GetAge());
        }
    }
}