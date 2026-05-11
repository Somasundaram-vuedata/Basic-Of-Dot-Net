using System;
public class program{ 
 public Static Void Main(String[] args)
    {
        int[] a = { 1, 3, 5, 3,1,4 };
        Console.WriteLine("Duplicate");
        for (int i = 0; i < a.Length; i++)
        {
            int c = 0;
            for (int j =0; j < a.Length; j++)
            {
                if (a[i] == a[j])
                {
                    c++;
                }
            }

            if (c==0)
            {
                Console.WriteLine(a[i]+" ");
                break;
            }
        }
    }
}