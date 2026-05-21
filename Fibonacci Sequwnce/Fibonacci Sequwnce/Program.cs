using System;
public class Program {
    public static void Main(string[] args) {
        int a, b, c, n;
        a = 0; b = 1;
        Console.Write("Enter The Number Of Terms: ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine(a);
        Console.WriteLine(b);

        for (int i = 1; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
            Console.WriteLine(c);
        }
            Console.ReadLine();
        
    }
}