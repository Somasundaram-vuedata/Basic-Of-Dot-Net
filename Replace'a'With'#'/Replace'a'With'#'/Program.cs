using System;
public class program
{
    public static void Main(String[] args)
    {
        String n = "Somasundaram";
        int s = n.Length;
        String res = "";
        for(int i = 0; i < s; i++)
        {
            if(n[i]!='a' && n[i] != 'A')
            {
                res = res + n[i];
            }
            else
            {
                res = res + "#";
            }
        }
        Console.WriteLine(res);

    }
}