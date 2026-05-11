using System;
public class Program
{
    public static void Main(String[] args)
    {
        int[] a = {1,2,3,4,5,3,2,4,5,3,2};
        for(int i = 0; i < a.Length; i++)
        {
            int c = 0;
            for(int j = 0; j < a.Length; j++)
            {
                if (a[i] == a[j])
                {
                    c++;
                }
            }
            Console.WriteLine(a[i]+"Repeated "+c+" Times.");
        }
    }
}