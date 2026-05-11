using System;
public class Program
{
    public static void Main(String[] args)
    {
        int n = 15, p = 1;
        for (int i = n; i >= 1; i--)
        {
            p *= i;
        }
        Console.WriteLine("Factorial Number OF "+n+" "+p);
    }
}