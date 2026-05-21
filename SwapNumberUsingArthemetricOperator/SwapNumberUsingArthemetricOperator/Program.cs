using System;
public class Program
{
    public static void Main(String[] args)
    {
        int a = 47;
        int b = 49;
        Console.WriteLine("Before Swap Number A :"+a+" B:"+b);
        a = a + b;//47+49==96
        b = a - b;//96-49=47
        a = a - b;//96-47=49
        Console.WriteLine("After Swap Number A :" + a + " B:" + b);

    }
}