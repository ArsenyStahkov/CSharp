using System;

class main
{
    static void Main()
    {
        Console.WriteLine("Type the count of numbers:");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0)
            return;
        int[] arr = Task1.CreateArray(n);
        Console.Write("The array: ");
        foreach (int item in arr)
            Console.Write(item + " ");
        Console.WriteLine();

        arr = Task1.RemoveMaxElement(arr);
        Console.WriteLine("The array after removal of maximum element:");
        foreach (int item in arr)
            Console.Write(item + " ");
        Console.WriteLine();

        Console.WriteLine("Type the count of adding numbers:");
        int k = int.Parse(Console.ReadLine());
        arr = Task2.AddElmntsToBegin(arr, k);
        if (n <= 0)
            return;
        Console.WriteLine("The array after adding " + k + " elements:");
        foreach (int item in arr)
            Console.Write(item + " ");
        Console.WriteLine();

        arr = Task3.TurnOver(arr);
        Console.WriteLine("The array after turning over:");
        foreach (int item in arr)
            Console.Write(item + " ");
        Console.WriteLine();

        int firstEven = Task4.GetFirstEven(arr);
        Console.WriteLine("The first even element in the array: " + firstEven);
        Console.WriteLine();

        arr = Task5.SortSimpleExchange(arr);
        Console.WriteLine("The array after sorting by simple exchange:");
        foreach (int item in arr)
            Console.Write(item + " ");
        Console.WriteLine();
    }
}

public class Task1
{
    public static int[] CreateArray(int n)
    {
        int[] arr = new int[n];
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
            arr[i] = rnd.Next();

        return arr;
    }

    public static int[] RemoveMaxElement(int[] arr)
    {
        int max = 0;
        int maxItem = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
                maxItem = i;
            }
        }

        int[] newArr = new int[arr.Length - 1];
        for (int i = 0, j = 0; i < newArr.Length; i++, j++)
        {
            if (i == maxItem)
                j++;
            newArr[i] = arr[j];
        }

        return newArr;
    }
}

public class Task2
{
    public static int[] AddElmntsToBegin(int[] arr, int k)
    {
        int[] newArr = new int[arr.Length + k];
        Random rnd = new Random();
        for (int i = 0; i < k; i++)
            newArr[i] = rnd.Next();

        for (int i = k, j = 0; i < arr.Length + k; i++, j++)
            newArr[i] = arr[j];

        return newArr;
    }
}

public class Task3
{
    public static int[] TurnOver(int[] arr)
    {
        int[] newArr = new int[arr.Length];
        for (int i = 0, j = arr.Length - 1; i < arr.Length; i++, j--)
            newArr[i] = arr[j];

        return newArr;
    }
}

public class Task4
{
    public static int GetFirstEven(int[] arr)
    {
        int firsEven = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                firsEven = arr[i];
                break;
            }
        }

        return firsEven;
    }
}

public class Task5
{
    public static int[] SortSimpleExchange(int[] arr)
    {
        bool isSorted = false;
        while (!isSorted)
        {
            isSorted = true;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    int tmp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = tmp;
                    isSorted = false;
                }
            }
        }

        return arr;
    }
}
