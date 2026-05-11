public class A
{
    public A()
    {
        Console.WriteLine("Welcome");
    }
    public A(String name)
    {
        Console.WriteLine("Welcome " + name);
    }
}
public class program
{
    public static void Main(String[] args)
    {
        A a = new A();
        A a1 = new A("Somu");
    }
}
