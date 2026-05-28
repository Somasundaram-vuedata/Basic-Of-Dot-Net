using System;
class program
{
    private String name;
    private int Age;

    public void setName(String StudentName)
    {
        this.name = StudentName;
    }
    public void setAge(int StudentAge)
    {
        if (StudentAge > 0)
        { this.Age = StudentAge; }
        else { Console.WriteLine("Enter The Correct Age"); }
    }
    public string getName() {
        return name;
    }
    public int getAge()
    {
        return Age;
    }
}
public class MainClass
{
    public static void Main(String[] args) {

        program p = new program();
        p.setName("Somu");
        p.setAge(5);
        Console.WriteLine("Student Name:"+p.getName());
        Console.WriteLine("Student Age: "+p.getAge());
    }

}