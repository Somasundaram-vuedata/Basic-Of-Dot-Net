using System;
public class welcome
{
    public welcome()
    {
        Console.WriteLine("Welcome Guest");
    }
    public welcome(String name)
    {
        Console.WriteLine("Welcome "+name);
    }

}
public class program
{
    public static void Main(String[] args)
    {
        welcome wel=new welcome();
        welcome guest= new welcome("Somu");
    }
}