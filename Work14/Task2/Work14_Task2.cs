using LibVirtual;
using System;
using System.Linq;
using System.Runtime.ConstrainedExecution;

class Work14_Task2
{
    static void Main()
    {
        LibVirtual.Student student_1 = new LibVirtual.Student("Ivan", "Ivanov", 21);
        student_1.SetCourse(4);

        LibVirtual.Student student_2 = new LibVirtual.Student("Alexey", "Alexeev", 23);
        student_2.SetCourse(3);

        LibVirtual.Student student_3 = new LibVirtual.Student("Anastasya", "Stolyarova", 21);
        student_3.SetCourse(3);

        LibVirtual.Teacher teacher_1 = new LibVirtual.Teacher("Anna", "Savelieva", 42);
        teacher_1.SetExperience(16);

        LibVirtual.Teacher teacher_2 = new LibVirtual.Teacher("Arkadiy", "Saveliev", 56);
        teacher_1.SetExperience(30);

        LibVirtual.Employee employee_1 = new LibVirtual.Employee("Alexandr", "Alexandrov", 32);
        employee_1.SetSalary(50000);

        Dictionary<int, Person> faculty = new Dictionary<int, Person>()
        {
            { 0, student_1 },
            { 1, student_2 },
            { 2, student_3 },
            { 3, teacher_1 }, 
            { 4, teacher_2 }, 
            { 5, employee_1 }
        };

        IEnumerable<KeyValuePair<int, Person>> students = GetStudents(faculty);
        Console.WriteLine("Students: ");
        foreach (KeyValuePair<int, Person> person in students)
            person.Value.Show();
    }

    static IEnumerable<KeyValuePair<int, Person>> GetStudents(Dictionary<int, Person> faculty)
    {
        return from person
        in faculty
        where person.Value.GetType() == typeof(Student)
        select person;
    }
}