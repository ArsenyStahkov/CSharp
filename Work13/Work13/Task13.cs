using DoubleList;
using PersonClass;
using MyCollectionClass;
using MyNewCollectionClass;

class main
{
    static void Main()
    {
        Student student = new Student("Ivan", "Ivanov", 21);
        student.SetCourse(3);

        Teacher teacher = new Teacher("Anna", "Savelieva", 42);
        teacher.SetExperience(19);

        Employee employee = new Employee("Alexandr", "Alexandrov", 32);
        employee.SetSalary(50000);

        Student student_2 = new Student("Anastasia", "Cherepanova", 22);
        student_2.SetCourse(2);

        DoubleLinkedList<Person> linkedList = new DoubleLinkedList<Person>
        {
            student,
            teacher,
            employee,
            student_2
        };

        // Search and print
        foreach (Person person in linkedList)
            person.ToString();

        // Count of elements
        Console.WriteLine("\nCount of elements: " + MyCollection.Count());

        // Remove
        MyCollection.Remove(student);

        // Search and print (2)
        Console.WriteLine();
        foreach (Person person in linkedList)
            person.ToString();

        // Count of elements (2)
        Console.WriteLine("\nCount of elements: " + MyCollection.Count());

        // Using delegats and events
        Console.WriteLine("\nUsing delegats and events:\n");
        MyNewCollection.Remove(teacher);
        Console.WriteLine("Count of elements: " + MyNewCollection.Count());
        foreach (Person person in linkedList)
            person.ToString();

        Student student_3 = new Student("Anton", "Antonov", 23);
        student_3.SetCourse(4);

        Console.WriteLine();
        MyNewCollection.Add(ref linkedList, student_3);
        Console.WriteLine("Count of elements: " + MyNewCollection.Count());
        foreach (Person person in linkedList)
            person.ToString();
    }
}
