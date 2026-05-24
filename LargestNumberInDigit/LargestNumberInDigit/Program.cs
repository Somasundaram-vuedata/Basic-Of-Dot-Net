using System;
using System.Diagnostics.Contracts;
public class program
{
    public static void Main()
    {
        int num = 826345678;
        int largest = 0;
        while (num > largest)
        {
            int digit = num % 10;
            if (digit>largest) {
                largest = digit;
            }
            num = num / 10;
        }
        Console.WriteLine("Largest:"+largest);
    }
}