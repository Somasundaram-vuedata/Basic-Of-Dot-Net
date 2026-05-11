using System;
public class program
{
    public static void Main(string[] args)
    {
        int n = 234; //2+3+4
        int s = 0;
        while (n != 0)
        {
            int r = n % 10;
            s = s + r;
            n = n / 10;
        }
        Console.WriteLine(s);
    }
}