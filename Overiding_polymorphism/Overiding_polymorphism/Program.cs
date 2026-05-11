using System;

public class Bank
{
    public virtual float GetInterest(int amt) 
    {
        return (3.2f * amt) / 100;
    }
}

public class Sbi : Bank
{
    public override float GetInterest(int amt) 
    {
        return (4.5f * amt) / 100; 
    }
}

public class MainClass
{
    public static void Main(String[] args)
    {
        int amt = 50000;
        Bank bk = new Bank();
        Sbi sbi = new Sbi();
        Console.WriteLine("Given Amount: " + amt);
        Console.WriteLine("Bank Interest: " + bk.GetInterest(amt));
        Console.WriteLine("SBI Interest: " + sbi.GetInterest(amt));
   }
}