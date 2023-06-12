class main
{
    static void Main()
    {
        GetStudentsByCourse();
        GetTeachersByExperience();
        GetEmployeesBySalary();
    }
    static void GetStudentsByCourse()
    {
        LibVirtual.Student[] students = new LibVirtual.Student[3];

        LibVirtual.Student st1 = new LibVirtual.Student("Ivan", "Ivanov", 21);
        st1.Init();
        st1.SetCourse(1);

        LibVirtual.Student st2 = new LibVirtual.Student("Yana", "Cherepanova", 22);
        st2.Init();

        LibVirtual.Student st3 = new LibVirtual.Student("Alexey", "Sergeev", 20);
        st3.Init();

        students[0] = st1;
        students[1] = st2;
        students[2] = st3;

        foreach (LibVirtual.Student student in students)
        {
            if (student.getCourse() == 3)
                student.Show();
        }
    }

    static void GetTeachersByExperience()
    {
        LibVirtual.Teacher[] teachers = new LibVirtual.Teacher[3];

        LibVirtual.Teacher st1 = new LibVirtual.Teacher("Nikolay", "Stepanov", 38);
        st1.Init();
        st1.SetExperience(10);

        LibVirtual.Teacher st2 = new LibVirtual.Teacher("Anna", "Savelieva", 42);
        st2.Init();
        st2.SetExperience(16);

        LibVirtual.Teacher st3 = new LibVirtual.Teacher("Olga", "Mihailova", 61);
        st3.Init();
        st3.SetExperience(35);

        teachers[0] = st1;
        teachers[1] = st2;
        teachers[2] = st3;

        foreach (LibVirtual.Teacher teacher in teachers)
        {
            if (teacher.getExperience() >= 20)
                teacher.Show();
        }
    }

    static void GetEmployeesBySalary()
    {
        LibVirtual.Employee[] employees = new LibVirtual.Employee[3];

        LibVirtual.Employee st1 = new LibVirtual.Employee("Nikolay", "Stepanov", 38);
        st1.Init();
        st1.SetSalary(50000);

        LibVirtual.Employee st2 = new LibVirtual.Employee("Anna", "Savelieva", 42);
        st2.Init();
        st2.SetSalary(60000);

        LibVirtual.Employee st3 = new LibVirtual.Employee("Olga", "Mihailova", 61);
        st3.Init();
        st3.SetSalary(50000);

        employees[0] = st1;
        employees[1] = st2;
        employees[2] = st3;

        foreach (LibVirtual.Employee employee in employees)
        {
            if (employee.getSalary() == 50000)
                employee.Show();
        }
    }
}