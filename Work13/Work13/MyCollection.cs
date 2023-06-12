using DoubleList;
using PersonClass;

namespace MyCollectionClass
{
    public class MyCollection : DoubleLinkedList<Person>
    {
        static public bool Remove(Person data)
        {
            DoubleNode<Person> current = head;

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

        static public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        static public int Count()
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
    }
}
