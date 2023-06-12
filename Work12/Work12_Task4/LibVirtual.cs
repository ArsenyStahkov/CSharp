using LibInit;

namespace LibVirtual
{
    public abstract class Person : IInit
    {
        protected string _name;
        protected string _surname;
        protected int _age;
        protected int _rand;

        protected Person() { }
        protected Person(string name, string surname, int age)
        {
            this._name = name;
            this._surname = surname;
            this._age = age;
        }

        public int GetAge()
        { 
            return _age;
        }

        public virtual void Init()
        {
            this._name = "name";
            this._surname = "surname";
            this._age = 18;
        }

        public void RandomInit()
        {
            Random rnd = new Random();
            _rand = rnd.Next();
        }

        public bool Equals(Person person)
        {
            if (person._name == this._name && person._surname == this._surname)
                return true;
            return false;
        }

        public virtual void Show()
        {
            Console.WriteLine("No data");
        }
    }

    public class Student : Person
    {
        int _course;
        public int getCourse()
        { 
            return _course; 
        }

        public Student(string name, string surname, int age)
            : base(name, surname, age) { }

        public override void Init()
        {
            this._course = 3;
        }
        public void SetCourse(int course)
        {
            this._course = course;
        }

        public override void Show()
        {
            Console.WriteLine("{0} {1} age: {2}. Course: {3}", _name, _surname, _age, _course);
        }
    }

    public class Teacher : Person
    {
        int _exp;

        public int getExperience()
        {
            return _exp;
        }

        public Teacher(string name, string surname, int age)
            : base(name, surname, age) { }

        public override void Init()
        {
            this._exp = 15;
        }

        public void SetExperience(int exp)
        {
            this._exp = exp;
        }

        public override void Show()
        {
            Console.WriteLine("{0} {1} age: {2}. Expirience: {3} years", _name, _surname, _age, _exp);
        }
    }

    public class Employee : Person
    {
        int _salary;

        public int getSalary()
        {
            return _salary;
        }

        public Employee(string name, string surname, int age) 
            : base(name, surname, age) { }

        public override void Init()
        {
            this._salary = 35000;
        }

        public void SetSalary(int salary)
        {
            this._salary = salary;
        }

        public override void Show()
        {
            Console.WriteLine("{0} {1} age: {2}. Salary: {3}", _name, _surname, _age, _salary);
        }
    }
}
