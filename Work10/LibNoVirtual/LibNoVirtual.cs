namespace LibNoVirtual
{
    public abstract class Person
    {
        protected string _name;
        protected string _surname;
        protected int _age;
        protected int _rand;

        protected Person() { }
        protected void Init(string name, string surname, int age)
        {
            this._name = name;
            this._surname = surname;
            this._age = age;
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

        public abstract void Show();
    }

    public class Student : Person
    {
        int _course;

        public void Init(string name, string surname, int age, int course)
        {
            base.Init(name, surname, age);
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

        public void Init(string name, string surname, int age, int exp)
        {
            base.Init(name, surname, age);
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

        public void Init(string name, string surname, int age, int salary)
        {
            base.Init(name, surname, age);
            this._salary = salary;
        }

        public override void Show()
        {
            Console.WriteLine("{0} {1} age: {2}. Salary: {3}", _name, _surname, _age, _salary);
        }
    }
}
