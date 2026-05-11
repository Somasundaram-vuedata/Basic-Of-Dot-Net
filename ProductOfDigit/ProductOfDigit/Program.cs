using System;
public class Program
{
    public static void Main(String[] args)
    {
        int n = 44;
        int p = 1;
        while (n != 0)
        {
            int r = n % 10;
            p = p * r;
            n = n / 10;
        }
        Console.WriteLine(p);
    }
}