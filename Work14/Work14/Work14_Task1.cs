using LibVirtual;
using System;
using System.Linq;
using System.Runtime.ConstrainedExecution;

class Task1
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

        List<Person> university = new List<Person>()
        {
            student_1, student_2, student_3, teacher_1, teacher_2, employee_1
        };

        IEnumerable<Person> students = GetStudents(university);
        Console.WriteLine("Students: ");
        foreach (Person person in students)
            person.Show();

        Console.WriteLine("\nThe count of people who is yanger than 40:\n" + GetCountByAge(university, 40));

        IEnumerable<Person> diff = GetStudentsByAge(university, 23);
        Console.WriteLine("\nStudents who are yanger than 23:");
        foreach (Person person in diff)
            person.Show();

        int maxAge = GetTeacherMaxAge(university);
        Console.WriteLine("\nTeacher max age:");
        Console.WriteLine(maxAge);
    }

    static IEnumerable<Person> GetStudents(List<Person> university)
    {
        return from person
            in university
            where person.GetType() == typeof(Student)
            select person;
    }

    static int GetCountByAge(List<Person> university, int age)
    {
        return (from person
            in university
            where person.GetAge() < age
            select person).Count<Person>();
    }

    static IEnumerable<Person> GetStudentsByAge(List<Person> university, int age)
    {
        return (from person
            in university
            where person.GetType() == typeof(Student)
            select person).Except
                (from person
                 in university
                 where person.GetAge() >= age
                 select person);
    }

    static int GetTeacherMaxAge(List<Person> university)
    {
        return (from person
                in university
                where person.GetType() == typeof(Teacher)
                select person.GetAge()).Max();
    }
}