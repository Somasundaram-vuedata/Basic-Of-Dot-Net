using System;
public class PRogram
{
    public static void Main(string[] args)
    {
        String n = "Somu";
        int s=n.Length;
        char[] res = new char[s];
        //store
        for(int i = 0; i < s; i++)
        {
            res[i] = n[i];

        }
        //print
        for(int i = 0; i < res.Length; i++)
        {
            Console.WriteLine(res[i]);
        }
    }
}