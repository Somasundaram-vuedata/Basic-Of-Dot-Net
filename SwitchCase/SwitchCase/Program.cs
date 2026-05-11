using System;
public class program
{
    public static void Main(String[] args)
    {
        Console.Write("Enter The First Number:");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("Enter The Second Number:");
        int n2 = int.Parse(Console.ReadLine());

        int res = 0;
        Console.WriteLine("1.Add\n 2.Sub\n 3.Largest Number");
        Console.Write("Enter The Choice");
        int ch=int.Parse(Console.ReadLine());
        switch (ch)
        {
            case 1:
                res = n1 + n2;
                break;
            case 2:
                res = n1 - n2;
                break;
            case 3:
                res=n1>n2? n1:n2;
                break;
            Default:
                Console.WriteLine("Invalid Input Number");

        }
        Console.WriteLine(res);
    }
}