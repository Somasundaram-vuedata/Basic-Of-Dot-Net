using System;
public class program
{
    int id;
    String name;
    double salary;
    public void display()
    {
        Console.WriteLine("Id"+id); 
        Console.WriteLine("Name" + name);
        Console.WriteLine("Salary" + salary);
    }
    public static void Main(String[] args)
    {
        program pr=new program();   
        pr.display();
    }
}