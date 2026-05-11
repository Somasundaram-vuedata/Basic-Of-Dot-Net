using System;
public class Circle
{
    public float radius;
    public void setinfo(float radius)
    {
        this.radius = radius;
    }
    public void display()
    {
        Console.WriteLine("Radius Asigned"+radius);
    }
    public double area()
    {
        return 3.14 * radius * radius;
    }
    public double perimeter()
    {
        return 2 * 3.14 * radius;
    }
}
public class program {
    public static void Main(String[] args)
    {
        Circle c= new Circle();
        float radius = 4.2f;
        c.setinfo(radius);
        c.display();
        Console.WriteLine("Area: "+c.area());
        Console.WriteLine("Perimeter: " + c.perimeter());

    }
}