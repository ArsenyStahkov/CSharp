using LibVirtual;
using System;

class Task2
{
    static void Main()
    {
        WorkWithDictionary();
    }
    static public void WorkWithDictionary()
    {
        LibVirtual.Student student = new LibVirtual.Student("Ivan", "Ivanov", 21);
        student.Init();

        LibVirtual.Teacher teacher = new LibVirtual.Teacher("Anna", "Savelieva", 42);
        teacher.Init();

        LibVirtual.Employee employee = new LibVirtual.Employee("Alexandr", "Alexandrov", 32);
        employee.Init();

        Dictionary<int, LibVirtual.Person> people = new Dictionary<int, LibVirtual.Person>()
        {
            { 0, student },
            { 1, teacher },
            { 2, employee }
        };

        string menu
            = "1. Check dictionary\n" +
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
                    PrintDictionary(ref people);
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

    static public void AddObject(ref Dictionary<int, LibVirtual.Person> people)
    {
        string name, surname;
        Console.Write("Name: ");
        name = Console.ReadLine();
        Console.Write("Surname: ");
        surname = Console.ReadLine();

        string menu
            = "1. Student\n" +
                "2. Teacher\n" +
                "3. Employee\n" +
                "0. Exit\n";
        Console.WriteLine(menu);

        int num = -1;
        int n = 0;
        int keyCounter = 2;

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
                ++keyCounter;
                people.Add(keyCounter, person);
                return;
            case 2:
                Console.Write("Experience: ");
                n = int.Parse(Console.ReadLine());
                if (n < 1 || 70 < n)
                    return;
                LibVirtual.Teacher teacher = new LibVirtual.Teacher(name, surname, n);
                teacher.Init();
                ++keyCounter;
                people.Add(keyCounter, teacher);
                return;
            case 3:
                Console.Write("Salary: ");
                n = int.Parse(Console.ReadLine());
                if (n < 15000 || 200000 < n)
                    return;
                LibVirtual.Employee employee = new LibVirtual.Employee(name, surname, n);
                employee.Init();
                ++keyCounter;
                people.Add(keyCounter, employee);
                return;
        }
    }

    static public void RemoveObject(ref Dictionary<int, LibVirtual.Person> people)
    {
        Console.Write("Type the key: ");
        int key = int.Parse(Console.ReadLine());

        if (people.Count == 0)
            return;
        if (key < 0 || key > people.Count - 1)
            return;
        people.Remove(key);
    }

    static public void PrintDictionary(ref Dictionary<int, LibVirtual.Person> people)
    {
        foreach (var person in people)
        {
            Console.WriteLine(person);
        }
    }
}