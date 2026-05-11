using System;
public class program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Enter The Amount");
        double amt=double.Parse(Console.ReadLine());
        
        double d = 6;
        if (amt >= 5000)
        {
            double dis = (amt * d) / 100;
            amt = amt - dis;
            System.Console.WriteLine("Discount Of Rs."+dis+"is applied");
        }
        else
        {
            Console.WriteLine("Not Eligible For Offer!!");
        }
        Console.WriteLine("Pay"+amt);
    }
}