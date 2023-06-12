using System;

class Task3
{
    static void Main()
    {
        TestCollections collections = new TestCollections();
    }

    public class Person
    {
        protected string _name;
        protected string _surname;
        protected int _age;

        public Person(string name, string surname, int age)
        {
            this._name = name;
            this._surname = surname;
            this._age = age;
        }
    }

    public class Student : Person
    {
        int _course;

        public Student(string name, string surname, int age)
            : base(name, surname, age) { }

        public Person BasePerson
        {
            get
            {
                return new Person("Name", "Surname", 0);
            }
        }
    }

    public class TestCollections
    {
        List<Person> peopleList = new List<Person>();
        List<string> peopleListStr = new List<string>();
        Dictionary<int, Person> peopleDict = new Dictionary<int, Person>();
        Dictionary<string, Person> peopleDictStr = new Dictionary<string, Person>();

        public TestCollections()
        {
            Student student = new Student("Name", "Surname", 18);
            for (int i = 0; i < 1000; i++)
            {
                peopleList.Add(student);
                peopleListStr.Add("Student");
                peopleDict.Add(i, student);
                peopleDictStr.Add(i.ToString(), student);
            }
        }
    }
}