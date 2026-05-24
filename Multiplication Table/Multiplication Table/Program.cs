using System;
class program{
public static void Main(String[] args)
{
        Console.WriteLine("Enter the Number : ");
        int num = int.Parse(Console.ReadLine());
    for(int i = 0; i <= 10; i++)
    {
        Console.WriteLine(num + " X " + i + "="+(num * i));
    }
}
}