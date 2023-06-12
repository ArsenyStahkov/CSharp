using System;
using System.Collections.Generic;
using LibVirtual;

public class Task2
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
        student.Init();

        Tree.BinaryTree<Person> tree = new Tree.BinaryTree<Person>(student, null, 0);
        tree.add(teacher, 1);
        tree.add(employee, 2);
        tree.add(student_2, 3);

        tree.Print();
    }
}

namespace Tree
{
    public class BinaryTree<T>
    {
        private BinaryTree<T> parent, left, right;
        private T val;
        private int key;
        private List<T> listForPrint = new List<T>();

        public BinaryTree(T val, BinaryTree<T> parent, int key)
        {
            this.val = val;
            this.parent = parent;
            this.key = key;
        }

        public void add(T val, int key)
        {
            if (key.CompareTo(this.key) < 0)
            {
                if (this.left == null)
                {
                    this.left = new BinaryTree<T>(val, this, key);
                }
                else if (this.left != null)
                    this.left.add(val, key);
            }
            else
            {
                if (this.right == null)
                {
                    this.right = new BinaryTree<T>(val, this, key);
                }
                else if (this.right != null)
                    this.right.add(val, key);
            }
        }

        private BinaryTree<T> _search(BinaryTree<T> tree, T val, int key)
        {
            if (tree == null) return null;
            switch (key.CompareTo(tree.val))
            {
                case 1: 
                    return _search(tree.right, val, key);
                case -1: 
                    return _search(tree.left, val, key);
                case 0: 
                    return tree;
                default: 
                    return null;
            }
        }

        public BinaryTree<T> search(T val, int key)
        {
            return _search(this, val, key);
        }

        private void _print(BinaryTree<T> node)
        {
            if (node == null)
                return;
            _print(node.left);
            listForPrint.Add(node.val);
            Console.Write(node + "\n");
            if (node.right != null)
                _print(node.right);
        }
        public void Print()
        {
            listForPrint.Clear();
            _print(this);
            Console.WriteLine();
        }
    }
}