using System;
public class Progam
{
    public static void Main(String[]args) {
        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18};
        int sum = 0;
        int product = 1;
        for(int i = 0; i < a.Length; i++)
        {
            sum = a[i] + sum;
            product = a[i] * product;
        }
        Console.WriteLine("Sum Of Array:"+sum);
        Console.WriteLine("Product OF Array:"+product);


    }
}