using System;
public class Program
{
    public static void Main(string[] args) {

        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        for(int i = a.Length - 1; i >= 0; i--) { 
        Console.Write(a[i]+",");
            //Console.WriteLine();
        }
    
    }
}