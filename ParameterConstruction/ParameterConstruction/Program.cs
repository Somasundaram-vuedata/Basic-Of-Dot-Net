using System;
public class Employee
{
    int id;
    string name;
    float age;
    public Employee(int id, String name,float age)
    {
        this.id = id;
        this.name = name;
        this.age = age;
    }
    public void display()
    {
        Console.WriteLine("ID " + id);
        Console.WriteLine("Name " + name);
        Console.WriteLine("Age " + age);
    }
    public class Parameterized
    {
        public static void Main(String[] args)
        {
            Employee emp = new Employee(101,"Somu",24);
            emp.display();
        }
    }
}