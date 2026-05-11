using System;
public class Encap
{
    private int id;
    private string name;

    public void setid(int id)
    {
        this.id = id;
    }
    public int getid()
    {
        return id;
    }
    public void setname(String Name)
    {
        this.name = Name;
    }
    public string getName()
    {
        return name;
    }
}
    public class program
    {
        public static void Main(String[] args) {

            Encap en = new Encap();
            en.setid(101);
            Console.WriteLine(en.getid());
            en.setname("Somu");
            Console.WriteLine(en.getName());

        }

    }