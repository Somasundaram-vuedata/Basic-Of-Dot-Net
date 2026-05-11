using System;
public class program
{
    public static void Main(String[] args)
    {
        int n = 145;
        int s = 0, t = n;
        while (n != 0)
        {
            int r = n % 10;
            //Factorial Code 
            int p = 1;
            for(int i = n; i >= 1; i--)
            {
                p *= i;
            }
            s = s + p;
            n = n / 10;
        }
        Console.WriteLine((t==s)?"Strong":"Not Strong");
    }
}