using DoubleList;
using MyCollectionClass;
using PersonClass;

namespace MyNewCollectionClass
{
    // Delegate
    public delegate void PeopleHandler(int n);
    public class MyNewCollection : MyCollection
    {
        // Event
        public static event PeopleHandler Handler;

        public static void Remove(Person p)
        {
            if (MyCollection.Remove(p))
            {
                Handler = Journal.NotifyChangedObject;
                Handler(0);
            }
        }

        public static void Add(ref DoubleLinkedList<Person> linkedList, Person p)
        {
            linkedList.Add(p);
            Handler = Journal.NotifyChangedObject;
            Handler(1);
        }

        public static void ChangeElement(ref DoubleLinkedList<Person> linkedList, Person p1, Person p2)
        {
            for (int i = 0; i < linkedList.Count(); ++i)
            {
                Person new_p = linkedList.ElementAt(i);
                if (new_p == p1)
                    new_p = p2;
            }
            Handler = Journal.NotifyChangedObject;
            Handler(3);
        }
    }

    public class Journal
    {
        public static void NotifyChangedObject(int n)
        {
            switch (n)
            {
                case 0:
                    Console.WriteLine("An object was removed");
                    break;
                case 1:
                    Console.WriteLine("An object was added");
                    break;
                case 3:
                    Console.WriteLine("Objects was changed");
                    break;
            }
        }
    }
}
