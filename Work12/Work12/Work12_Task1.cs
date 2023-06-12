using System.Collections;
using LibVirtual;

public class Task1
{
    public static void Main()
    {
        LibVirtual.Student student = new LibVirtual.Student("Ivan", "Ivanov", 21);
        student.Init();

        LibVirtual.Teacher teacher = new LibVirtual.Teacher("Anna", "Savelieva", 42);
        teacher.Init();

        LibVirtual.Employee employee = new LibVirtual.Employee("Alexandr", "Alexandrov", 32);
        employee.Init();

        LibVirtual.Student student_2 = new LibVirtual.Student("Anastasia", "Cherepanova", 22);
        student_2.Init();

        List.DoubleLinkedList<Person> linkedList = new List.DoubleLinkedList<Person>
        {
            student,
            teacher,
            employee
        };

        foreach (Person person in linkedList)
            person.Show();
        Console.WriteLine();

        Console.WriteLine("Adding a student into list");
        linkedList.Add(student_2);
        Console.WriteLine();

        foreach (Person person in linkedList)
            person.Show();
    }
}

public class DoubleNode<T>
{
    public DoubleNode(T data)
    {
        Data = data;
    }
    public T Data 
    { 
        get; 
        set; 
    }
    public DoubleNode<T> Previous 
    { 
        get; 
        set; 
    }
    public DoubleNode<T> Next 
    { 
        get; 
        set; 
    }
}

namespace List
{
    public class DoubleLinkedList<T> : IEnumerable<T>
    {
        DoubleNode<T> head;
        DoubleNode<T> tail;
        int count;

        public void Add(T data)
        {
            DoubleNode<T> node = new DoubleNode<T>(data);

            if (head == null)
                head = node;
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            count++;
        }

        public void AddFirst(T data)
        {
            DoubleNode<T> node = new DoubleNode<T>(data);
            DoubleNode<T> temp = head;
            node.Next = temp;
            head = node;
            if (count == 0)
                tail = head;
            else
                temp.Previous = node;
            count++;
        }

        public bool Remove(T data)
        {
            DoubleNode<T> current = head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                    break;
                current = current.Next;
            }
            if (current != null)
            {
                if (current.Next != null)
                    current.Next.Previous = current.Previous;
                else
                    tail = current.Previous;

                if (current.Previous != null)
                    current.Previous.Next = current.Next;
                else
                    head = current.Next;
                count--;
                return true;
            }
            return false;
        }

        public int Count()
        { 
            return count;
        }
        public bool IsEmpty 
        { 
            get 
            { 
                return count == 0; 
            } 
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public bool Contains(T data)
        {
            DoubleNode<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            DoubleNode<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public IEnumerable<T> BackEnumerator()
        {
            DoubleNode<T> current = tail;
            while (current != null)
            {
                yield return current.Data;
                current = current.Previous;
            }
        }
    }
}