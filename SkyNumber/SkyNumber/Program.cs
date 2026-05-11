using System;
public class Program
{
    public static void Main(String[] args)
    {
        int n = 123;
        int p = 1, s = 0;
        while (n != 0)
        {
            int r = n % 10;
            s = s + r;
            p = p * r;
            n = n / 10;
        }
        Console.WriteLine("Sum OF Digit:" + s);
        Console.WriteLine("Product Of Digit"+p);
        String largest = (s ==p) ? "Sky Number" : "Not A Sky Number";
        Console.WriteLine(largest);
    }
}