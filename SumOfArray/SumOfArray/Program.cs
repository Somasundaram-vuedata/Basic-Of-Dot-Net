using System;
public class Program
{
    public static void Main(String[] args)
    {
        int [] a = { 1, 2, 3, 4, 5, 6 };
        int sum = 0;
        for(int i = 0; i < a.Length; i++)
        {
            sum = a[i] + sum;
        }
        Console.WriteLine(sum);
    }
}