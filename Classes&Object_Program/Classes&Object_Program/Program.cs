public class Calcultor
{ 
public int Sum(int a,int b)
    {
         return a+ b;
    }
public int diff(int a, int b)
    {
        return a - b;
    }
public int multi(int a,int b)
    {
        return a * b;
    }
}
public class program { 
public static void Main(String[]args)
{
  Calcultor cal = new Calcultor();
        Console.WriteLine("Sum Of Two Number "+ cal.Sum(1, 2));
        Console.WriteLine("Diff Of Two Number "+ cal.diff(1, 2));
        Console.WriteLine("Multiple Of Two Number "+ cal.multi(1, 2));
    }
}