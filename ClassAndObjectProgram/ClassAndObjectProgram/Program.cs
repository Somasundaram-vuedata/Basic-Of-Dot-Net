using System;

public class Calculation
{
    public int Sum(int a, int b)
    {
        return a + b;
    }

    public int Diff(int a, int b)
    {
        return a - b;
    }

    public int Largest(int a, int b)
    {
        return a > b ? a : b;
    }

    public static void Main(String[] args)
    {
        Calculation cal = new Calculation();
        Console.WriteLine("The Sum Of Number: " + cal.Sum(2, 3));
        Console.WriteLine("The Difference Of Number: " + cal.Diff(2, 3));
        Console.WriteLine("The Largest Of Number: " + cal.Largest(2, 3));
    }
}