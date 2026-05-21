using System;
class Program
{
    public static void Main(String[] args)
    {
        int a = 45;
        int b = 46;
        Console.WriteLine("Before The Swap Number A:" + a + " B:" + b);
        // using Variable Temperature key for a;
        int temp = a; 
        a = b;
        b = temp;
        Console.WriteLine("After The Swap Number A: " + a +" B: "+b);

    }
}