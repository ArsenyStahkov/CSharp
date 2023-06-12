using LibVirtual;
using LibInit;

class main
{
    static void Main()
    {
        Student student = new Student("Ivan", "Ivanov", 21);
        student.Init();

        Teacher teacher = new Teacher("Anna", "Savelieva", 42);
        teacher.Init();

        Employee employee = new Employee("Alexandr", "Alexandrov", 32);
        employee.Init();

        Person[] people = new Person[3];
        people[0] = student;
        people[1] = teacher;
        people[2] = employee;
        Array.Sort(people, new PeopleComparer("name", "surname", 1));
        foreach (Person person in people)
            person.Show();
    }

    public class PeopleComparable : Person, IComparable<Person>
    {
        public PeopleComparable(string name, string surname, int age)
            : base(name, surname, age) 
        { 
            this._age = age;
        }
        public int CompareTo(Person? person)
        {
            if (person is null)
                throw new ArgumentException("Incorrect value");
            return _age - person.GetAge();
        }
    }

    public class PeopleComparer : Person, IComparer<Person>
    {
        public PeopleComparer(string name, string surname, int age)
            : base(name, surname, age)
        {
            this._age = age;
        }
        public int Compare(Person? person1, Person? person2)
        {
            if (person1 is null || person2 is null)
                throw new ArgumentException("Incorrect value");
            return person1.GetAge() - person2.GetAge();
        }
    }

    public class StudentCloneable : Student, ICloneable
    {
        public StudentCloneable(string name, string surname, int age)
            : base(name, surname, age)
        {
            this._age = age;
        }
        public object Clone()
        {
            return new Student("name", "surname", 18);
        }
    }

    public class Headman : IInit
    {
        protected string _name;
        protected string _surname;
        protected int _age;
        protected int _rand;

        protected Headman() { }
        protected Headman(string name, string surname, int age)
        {
            this._name = name;
            this._surname = surname;
            this._age = age;
        }
        void IInit.Init()
        {
            this._name = "name";
            this._surname = "surname";
            this._age = 18;
        }

        void IInit.RandomInit()
        {
            Random rnd = new Random();
            _rand = rnd.Next();
        }
    }
}