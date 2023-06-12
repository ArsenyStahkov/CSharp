using System;

class main
{
    static void Main()
    {
        Console.WriteLine("How many numbers do you need?");
        int n = int.Parse(Console.ReadLine());
        if (n < 1)
            return;
        int[] arr1 = new int[n];
        Console.WriteLine("Type the numbers:");
        for (int i = 0; i < n; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("The average: " + Task1.GetAverage(arr1));

        int[] arr2 = new int[n + 1];
        Console.WriteLine("Type the numbers:");
        for (int i = 0; i < n; i++)
        {
            arr2[i] = int.Parse(Console.ReadLine());
        }
        arr2[n] = 0;
        Console.WriteLine(Task2.CountQuantity(arr2));

        Console.WriteLine(Task3.CountAlternation(n));
    }
}

public class Task1
{
    public static double GetAverage(int[] arr)
    {
        double sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        return sum / arr.Length;
    }
}

public class Task2
{
    public static string CountQuantity(int[] arr)
    {
        int negative = 0;
        int positive = 0;
        int i = 0;
        while (i < arr.Length)
        {
            if (arr[i] % 2 != 0)
                negative++;
            else
                positive++;
            i++;
        }

        if (negative > positive)
            return "negative";
        if (negative < positive)
            return "positive";
        return "equal";
    }
}

public class Task3
{
    public static int CountAlternation(int n)
    {
        int res = 0;
        int i = 1;
        do
        {
            if (i % 2 != 0)
                res += i;
            else
                res -= i;
            i++;
        } while (i <= n);

        return res;
    }
}
