using System;
public class Employee
{
    protected int id = 101;
    protected float bpay = 18000;
    public string display()
    {
        return "Id: " + id + "\nSalary " + bpay;
    }
}
public class Developer : Employee
{
    float bonus = 5000;
    float inc = 15;
    public float calsalary()
    {
        float tsal = bpay + bonus + (bpay *inc) / 100;
        return tsal;
    }
}
public class Mainclass
{
    public static void Main(String[]args) {
        Developer dev = new Developer();
        Console.WriteLine("Employee Data");
        Console.WriteLine(dev.display()); 
        Console.WriteLine("After Increment Salary"+dev.calsalary());
        
    }
}