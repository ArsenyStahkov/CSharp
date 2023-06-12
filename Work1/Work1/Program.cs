using System;

class main
{
    static void Main(string[] args)
    {
        Console.WriteLine("Type the first number (m)");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Type the second number (n)");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("n+++m : " + Task1.Incr(m, n));
        Console.WriteLine("m-- >n : " + Task1.CompareDecrFirst(m, n));
        Console.WriteLine("n-- >m : " + Task1.CompareDecrSecond(m, n));

        Console.WriteLine("Type the third number (x)");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Type the fourth number (y)");
        double y = double.Parse(Console.ReadLine());

        Console.WriteLine("First expression value: " + Task1.CalculateExpr(x));

        Console.WriteLine("Area: " + Task2.IsInArea(x, y));

        Console.WriteLine("Second expression value: " + Task3.CalculateExpr());
    }
}

public class Task1
{
    public static int Incr(int m, int n)
    {
        return n++ + m;
    }

    public static bool CompareDecrFirst(int m, int n)
    {
        return m-- > n;
    }

    public static bool CompareDecrSecond(int m, int n)
    {
        return n-- > m;
    }

    public static double CalculateExpr(double x)
    {
        double sin = Math.Sin(x);
        double pow = Math.Pow(x, 3);
        double div = 1 / (x * x + 1);

        return sin + pow + div;
    }
}

public class Task2
{
    public static bool IsInArea(double x, double y)
    {
        if (x < 0.0 || x > 5.0)
            return false;
        if (y < 0.0 || y > 2.0)
            return false;

        return true;
    }
}

public class Task3
{
    public static double CalculateExpr()
    {
        int a = 1000;
        double b = 0.0001;
        double square = (a + b) * (a + b);
        double dvdnd = square - (a * a + 2 * a * b);

        return dvdnd;
    }
}
