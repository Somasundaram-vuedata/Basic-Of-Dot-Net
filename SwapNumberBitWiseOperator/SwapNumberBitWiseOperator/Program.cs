using System;
class Program
{
    public static void Main(String[] args)
    {
        int a = 10;
        int b = 20;
        Console.WriteLine("Before Swap Number A :"+a+" B:"+b);
        a = a ^ b;
        b = a ^ b;
        a= a ^ b;
        Console.WriteLine("After Swap Number A :" + a + " B:" + b);

    }
}