using System;
public class Calculator
{
    //Overloading mean Same Method name i.e Add but different Parameter.
    public int Add(int a,int b)
    {
        return a + b;
    }
    public int Add(int a,int b, int c)
    {
        return a + b + c;
    }
    public double Add(double a, double b)
    {
        return a + b;
    }
    //Overriding 
    public virtual void display()
    {
        Console.WriteLine("I Am Basic Calculator");
    } 
    public class ScientificCalculator : Calculator { 
    public override void display()
    {
        Console.WriteLine("I Am Scientific Calculator");
    }

    }
    public class program
    {
        public static void Main(String[] args)
        {
            Calculator cal = new Calculator();
            ScientificCalculator sci=new ScientificCalculator();
            Console.WriteLine("Sum Of Two Number: "+cal.Add(2, 3));
            Console.WriteLine("Sum Of Three Number: " + cal.Add(2, 3, 4));
            Console.WriteLine("Sum Of Two Number: " + cal.Add(2.5,5.6));
            cal.display();//parent class version runs
            sci.display();//child version runs
        }
    }
}